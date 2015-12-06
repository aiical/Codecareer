package Server;

import java.awt.Point;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Formatter;
import java.util.Scanner;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.locks.Condition;
import java.util.concurrent.locks.Lock;
import java.util.concurrent.locks.ReentrantLock;
import javax.swing.JFrame;
import javax.swing.JTextArea;
import javax.swing.SwingUtilities;

public class GobangServer extends JFrame {

	private ServerSocket server;
	private JTextArea textArea; // 显示游戏进程信息
	private Player[] players; // 与两个玩家交互
	private ExecutorService runGame;
	private Lock gameLock;
	private Condition otherPlayerConnected; // 控制玩家一的进程用来等待玩家二
	private boolean isGameOver = false; // 判断游戏是否结束
	private volatile int winner = -1; // 胜者，黑=0， 白=1，无=-1
	private volatile int lastPlayer = -1; // 记录上一个走棋的人，黑=0，白=1，无=-1
	private volatile Point location; // 记录一个玩家下子的位置,为两玩家所公用

	public GobangServer() {
		super("GobangServer");

		players = new Player[2];
		runGame = Executors.newFixedThreadPool(2);

		gameLock = new ReentrantLock();
		otherPlayerConnected = gameLock.newCondition();

		location = new Point();

		textArea = new JTextArea();
		this.add(textArea);

		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setSize(300, 300);
		this.setLocation(300, 50);

		displayMessage("等待玩家链接……\n");
	}

	// 运行服务器
	public void runServer() {
		// 创建服务器
		try {
			server = new ServerSocket(12345);
		} catch (IOException e) {
			e.printStackTrace();
		}

		// 链接所有玩家
		for (int i = 0; i < players.length; i++) {
			try {
				players[i] = new Player(server.accept(), i);
				runGame.execute(players[i]);
			} catch (IOException e) {
				e.printStackTrace();
			}
		}

		// 玩家2已连接，唤醒玩家1
		gameLock.lock();

		try {
			players[0].suspended = false;
			otherPlayerConnected.signal();
		} finally {
			gameLock.unlock();
		}

	}

	// 显示一条信息到输出区域
	private void displayMessage(final String message) {
		SwingUtilities.invokeLater(new Runnable() {
			@Override
			public void run() {
				textArea.append(message);
			}
		});
	}

	// ***************************************
	// 与一个玩家交互的线程
	class Player implements Runnable {

		private Socket connect;
		private Scanner input;
		private Formatter output;
		private int playerID; // 标示是哪一个玩家
		private boolean myStep = false; // 标示是否是本玩家的回合
		public boolean suspended = true; // 标示线程是否阻塞

		public Player(Socket socket, int index) {
			connect = socket;
			playerID = index;

			try {
				
				output = new Formatter(connect.getOutputStream());
				input = new Scanner(connect.getInputStream());
			} catch (IOException e) {
				e.printStackTrace();
			}

			displayMessage("玩家 " + playerID + "已链接\n");
		}

		// 告知玩家一次落子的信息
		private synchronized void sendOneStep() {
			output.format("oneStep\n");
			output.format("%d\n", lastPlayer);
			output.format("%d\n", location.x);
			output.format("%d\n", location.y);
			output.format("%d\n", winner);
			output.flush();
		}

		//走一步棋
		private synchronized void goOneStep() {
			location.x = input.nextInt();
			location.y = input.nextInt();
			winner = input.nextInt();
			lastPlayer = playerID;
			
			// 告知玩家落子位置
			sendOneStep();	

			myStep = false;
		}
		
		@Override
		public void run() {

			// 为玩家分配颜色
			if (playerID == 0)
				output.format("black\n");
			else
				output.format("white\n");
			output.flush();

			// 若玩家2没链接，则等待玩家2
			if (playerID == 0) {
				if (suspended) {
					gameLock.lock();

					try {
						otherPlayerConnected.await();
					} catch (InterruptedException e) {
						e.printStackTrace();
					} finally {
						gameLock.unlock();
					}
					// 通知玩家1可以开始游戏了
					myStep = true;
					output.format("begin\n");
					output.flush();
				}
			}

			displayMessage("玩家" + playerID + "已运行\n");

			//游戏进程主循环
			while (!isGameOver) {

				// 从一个玩家那里得到落子位置
				if (myStep && input.hasNext()) {
					
					goOneStep();	//把走一步棋的过程放在一个同步块中

					try {
						Thread.sleep(200);	//睡一会等待对方正确显示
					} catch (InterruptedException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
					Thread.yield();
				} else if (!myStep) {
					//不是本玩家回合，从另一玩家处得到一个位置
					if (lastPlayer != -1 && lastPlayer != playerID) {	
						sendOneStep();
						myStep = true;
						lastPlayer = -1;
						
						//胜负已定，游戏结束
						if (winner != -1 && winner != playerID) {
							isGameOver = true;
						}
					}
				}
			}
		}
	}
}
