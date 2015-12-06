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
	private JTextArea textArea; // ��ʾ��Ϸ������Ϣ
	private Player[] players; // ��������ҽ���
	private ExecutorService runGame;
	private Lock gameLock;
	private Condition otherPlayerConnected; // �������һ�Ľ��������ȴ���Ҷ�
	private boolean isGameOver = false; // �ж���Ϸ�Ƿ����
	private volatile int winner = -1; // ʤ�ߣ���=0�� ��=1����=-1
	private volatile int lastPlayer = -1; // ��¼��һ��������ˣ���=0����=1����=-1
	private volatile Point location; // ��¼һ��������ӵ�λ��,Ϊ�����������

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

		displayMessage("�ȴ�������ӡ���\n");
	}

	// ���з�����
	public void runServer() {
		// ����������
		try {
			server = new ServerSocket(12345);
		} catch (IOException e) {
			e.printStackTrace();
		}

		// �����������
		for (int i = 0; i < players.length; i++) {
			try {
				players[i] = new Player(server.accept(), i);
				runGame.execute(players[i]);
			} catch (IOException e) {
				e.printStackTrace();
			}
		}

		// ���2�����ӣ��������1
		gameLock.lock();

		try {
			players[0].suspended = false;
			otherPlayerConnected.signal();
		} finally {
			gameLock.unlock();
		}

	}

	// ��ʾһ����Ϣ���������
	private void displayMessage(final String message) {
		SwingUtilities.invokeLater(new Runnable() {
			@Override
			public void run() {
				textArea.append(message);
			}
		});
	}

	// ***************************************
	// ��һ����ҽ������߳�
	class Player implements Runnable {

		private Socket connect;
		private Scanner input;
		private Formatter output;
		private int playerID; // ��ʾ����һ�����
		private boolean myStep = false; // ��ʾ�Ƿ��Ǳ���ҵĻغ�
		public boolean suspended = true; // ��ʾ�߳��Ƿ�����

		public Player(Socket socket, int index) {
			connect = socket;
			playerID = index;

			try {
				
				output = new Formatter(connect.getOutputStream());
				input = new Scanner(connect.getInputStream());
			} catch (IOException e) {
				e.printStackTrace();
			}

			displayMessage("��� " + playerID + "������\n");
		}

		// ��֪���һ�����ӵ���Ϣ
		private synchronized void sendOneStep() {
			output.format("oneStep\n");
			output.format("%d\n", lastPlayer);
			output.format("%d\n", location.x);
			output.format("%d\n", location.y);
			output.format("%d\n", winner);
			output.flush();
		}

		//��һ����
		private synchronized void goOneStep() {
			location.x = input.nextInt();
			location.y = input.nextInt();
			winner = input.nextInt();
			lastPlayer = playerID;
			
			// ��֪�������λ��
			sendOneStep();	

			myStep = false;
		}
		
		@Override
		public void run() {

			// Ϊ��ҷ�����ɫ
			if (playerID == 0)
				output.format("black\n");
			else
				output.format("white\n");
			output.flush();

			// �����2û���ӣ���ȴ����2
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
					// ֪ͨ���1���Կ�ʼ��Ϸ��
					myStep = true;
					output.format("begin\n");
					output.flush();
				}
			}

			displayMessage("���" + playerID + "������\n");

			//��Ϸ������ѭ��
			while (!isGameOver) {

				// ��һ���������õ�����λ��
				if (myStep && input.hasNext()) {
					
					goOneStep();	//����һ����Ĺ��̷���һ��ͬ������

					try {
						Thread.sleep(200);	//˯һ��ȴ��Է���ȷ��ʾ
					} catch (InterruptedException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
					Thread.yield();
				} else if (!myStep) {
					//���Ǳ���һغϣ�����һ��Ҵ��õ�һ��λ��
					if (lastPlayer != -1 && lastPlayer != playerID) {	
						sendOneStep();
						myStep = true;
						lastPlayer = -1;
						
						//ʤ���Ѷ�����Ϸ����
						if (winner != -1 && winner != playerID) {
							isGameOver = true;
						}
					}
				}
			}
		}
	}
}
