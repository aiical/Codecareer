package Client;

import java.awt.Color;
import java.awt.Graphics;
import java.awt.Point;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.InetAddress;
import java.net.Socket;
import java.net.UnknownHostException;
import java.util.Formatter;
import java.util.Scanner;
import java.util.concurrent.Executors;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.border.LineBorder;

public class GobangClient extends JFrame implements Runnable {
	private final int GRID_AMOUNT = 15; // 15*15棋盘
	private Socket connect;
	private Scanner input;
	private Formatter output;
	private String hostName;
	private ChessBoard board; // 棋盘
	private int piecesColor; // 棋子颜色,黑色=1， 白色=2
	private int[][] placed;// 记录格子上是否有棋子,或棋子的颜色，黑色=0， 白色=1,无=-1
	private boolean myTurn;		//标记是否是本玩家的回合

	public GobangClient(String host) {

		super("GobangClient");

		hostName = host;
		placed = new int[GRID_AMOUNT][GRID_AMOUNT];
		for (int i = 0; i < this.GRID_AMOUNT; i++) {
			for (int j = 0; j < this.GRID_AMOUNT; j++)
				placed[i][j] = -1;
		}
		
		board = new ChessBoard();
		this.add(board);
		this.setLocation(200, 50);
		this.setSize(576, 599); // 按照30*30大小设置的窗口大小
		this.setResizable(false); // 不能改变大小，否则格子会不均匀（和整除有关）
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		runClient();
	}

	// 运行一个玩家
	private void runClient() {
		try {
			connect = new Socket(InetAddress.getByName(hostName), 12345);
			input = new Scanner(connect.getInputStream());
			output = new Formatter(connect.getOutputStream());
			output.flush();
		} catch (UnknownHostException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}

		// 将本玩家作为一个线程运行起来
		Executors.newFixedThreadPool(1).execute(this);
	}

	@Override
	public void run() {

		while (input.hasNext()) {
			processMessage(input.next());
		}

	}

	// 处理服务器发来的消息
	private void processMessage(String message) {

		switch (message) {
		// 颜色消息由服务器控制，不用担心发错
		case "black":
			myTurn = false;
			this.setTitle("player Black");
			piecesColor = 0;
			break;
			
		case "white":
			myTurn = false;
			this.setTitle("player White");
			piecesColor = 1;
			break;
			
		// 此消息只在玩家2连接到时发送到玩家1
		case "begin":
			myTurn = true;
			break;
		// 被告知对玩家下了一着，在棋盘上绘制出来，此消息两玩家都能收到
		case "oneStep":
			int whichPlayer = input.nextInt();	//得到是哪个玩家落的子
			int X = input.nextInt();
			int Y = input.nextInt();
			int winner = input.nextInt();
			
			placed[X][Y] = whichPlayer;
			
			myTurn = !myTurn;	//交换控制权
			
			board.repaint();
			
			//胜负已定，游戏结束
			if (winner != -1) {
				if (winner == piecesColor)
					JOptionPane.showMessageDialog(this, "你赢了！");
				else
					JOptionPane.showMessageDialog(this, "你输了！");
			}
			
			break;
		}

	}

	boolean win(int X, int Y) {
		int horizontalNum = 1,	//横向棋子数
			verticalNum = 1,	//纵向棋子数
			northWestNum = 1,	//10点半方向棋子数
			southEastNum = 1;	//1点半方向棋子数
		int w, h;
		
		//计算横向连续棋子
		w = X + 1;
		h = Y;
		while (w < this.GRID_AMOUNT && placed[w][h] == piecesColor) {
			horizontalNum++;
			w++;
		}
		w = X - 1;
		while (w >= 0 && placed[w][h] == piecesColor) {
			horizontalNum++;
			w--;
		}
		
		//计算纵向连续棋子
		w = X;
		h = Y + 1;
		while (h < this.GRID_AMOUNT && placed[w][h] == piecesColor) {
			verticalNum++;
			h++;
		}
		h = Y - 1;
		while (h >= 0 && placed[w][h] == piecesColor) {
			verticalNum++;
			h--;
		}
		
		//计算10点半方向连续棋子
		w = X + 1;
		h = Y + 1;
		while (w < this.GRID_AMOUNT && h < this.GRID_AMOUNT &&
				placed[w][h] == piecesColor) {
			northWestNum++;
			w++;
			h++;
		}
		w = X - 1;
		h = Y - 1;
		while (w >= 0 && h >= 0 
				&& placed[w][h] == piecesColor) {
			northWestNum++;
			w--;
			h--;
		}
		
		//计算1点半方向连续棋子
		w = X + 1;
		h = Y - 1;
		while (w < this.GRID_AMOUNT && h >= 0
				&& placed[w][h] == piecesColor) {
			southEastNum++;
			w++;
			h--;
		}
		w = X - 1;
		h = Y + 1;
		while (w >= 0 && h < this.GRID_AMOUNT
				&& placed[w][h] == piecesColor) {
			southEastNum++;
			w--;
			h++;
		}
		
		//返回结果
		if (horizontalNum >= 5 || verticalNum >= 5
				|| northWestNum >= 5 || southEastNum >= 5)
			return true;
		return false;
	}
	
	// 棋盘，记录棋子位置、处理用户鼠标信息
	class ChessBoard extends JPanel {
		
		private int boardWidth; // 棋盘宽
		private int boardHeight;// 棋盘高
		private int gridWidth; // 格子宽
		private int gridHeight; // 格子高
		private Point[][] locations; // 保存所有交叉点的位置，优化算法
		private boolean locationCounted = false; // 标示位置是否计算过

		public ChessBoard() {
			locations = new Point[GRID_AMOUNT][GRID_AMOUNT];

			this.setForeground(Color.blue);
			this.setBorder(new LineBorder(Color.black, 3));
			this.addMouseListener(new MouseAdapter() {

				@Override
				public void mouseReleased(MouseEvent e) {
					if (myTurn) {
						int X = e.getX() / gridWidth;
						int Y = e.getY() / gridHeight;
						if (placed[X][Y] == -1) { // 该点无棋子
							//将棋子位置告知服务器
							output.format("%d\n", X);
							output.format("%d\n", Y);
							if (win(X, Y))
								output.format("%d\n", piecesColor);
							else
								output.format("%d\n", -1);
							output.flush();
						}
					}
				}

			});
		}

		@Override
		protected void paintComponent(Graphics g) {
			boardWidth = this.getWidth();
			boardHeight = this.getHeight();
			gridWidth = boardWidth / GRID_AMOUNT;
			gridHeight = boardHeight / GRID_AMOUNT;

			// 计算所有交叉点的位置
			if (!locationCounted)
				countLocation();

			paintBoard(g); // 绘制棋盘
			paintPieces(g); // 绘制棋子
		}

		// 在棋盘上画格子
		private void paintBoard(Graphics g) {
			// 得到格子一半的大小，目的是留出边界
			int halfGridWidth = gridWidth / 2;
			int halfGridHeight = gridHeight / 2;
			// 画列
			for (int i = 0; i < GRID_AMOUNT; i++) {
				g.drawLine(i * gridWidth + halfGridWidth, halfGridHeight, i
						* gridWidth + halfGridWidth, boardHeight
						- halfGridHeight);
			}
			// 画行
			for (int i = 0; i < GRID_AMOUNT; i++) {
				g.drawLine(halfGridWidth, i * gridHeight + halfGridHeight,
						boardWidth - halfGridWidth, i * gridHeight
								+ halfGridHeight);
			}
		}

		// 将已存在的棋子画在棋盘上
		private void paintPieces(Graphics g) {

			int halfGridWidth = gridWidth / 2;
			int halfGridHeight = gridHeight / 2;

			for (int i = 0; i < GRID_AMOUNT; i++) {
				for (int j = 0; j < GRID_AMOUNT; j++) {
					if (placed[i][j] != -1) {	//有棋子
						
						//控制颜色
						if (placed[i][j] == 0)
							g.setColor(Color.black);
						else
							g.setColor(Color.lightGray);
						
						g.fillOval(locations[i][j].x - halfGridWidth,
								locations[i][j].y - halfGridHeight, gridWidth,
								gridHeight);
					}
				}

			}
		}

		// 计算所有交叉点的位置
		private void countLocation() {

			int halfGridWidth = gridWidth / 2;
			int halfGridHeight = gridHeight / 2;

			for (int i = 0; i < GRID_AMOUNT; i++) {
				for (int j = 0; j < GRID_AMOUNT; j++) {
					locations[i][j] = new Point();
					locations[i][j].x = i * gridWidth + halfGridWidth;
					locations[i][j].y = j * gridHeight + halfGridHeight;
				}
			}

			locationCounted = true;	//避免重复计算
		}

	}
}
