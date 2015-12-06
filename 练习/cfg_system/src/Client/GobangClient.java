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
	private final int GRID_AMOUNT = 15; // 15*15����
	private Socket connect;
	private Scanner input;
	private Formatter output;
	private String hostName;
	private ChessBoard board; // ����
	private int piecesColor; // ������ɫ,��ɫ=1�� ��ɫ=2
	private int[][] placed;// ��¼�������Ƿ�������,�����ӵ���ɫ����ɫ=0�� ��ɫ=1,��=-1
	private boolean myTurn;		//����Ƿ��Ǳ���ҵĻغ�

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
		this.setSize(576, 599); // ����30*30��С���õĴ��ڴ�С
		this.setResizable(false); // ���ܸı��С��������ӻ᲻���ȣ��������йأ�
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		runClient();
	}

	// ����һ�����
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

		// ���������Ϊһ���߳���������
		Executors.newFixedThreadPool(1).execute(this);
	}

	@Override
	public void run() {

		while (input.hasNext()) {
			processMessage(input.next());
		}

	}

	// �����������������Ϣ
	private void processMessage(String message) {

		switch (message) {
		// ��ɫ��Ϣ�ɷ��������ƣ����õ��ķ���
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
			
		// ����Ϣֻ�����2���ӵ�ʱ���͵����1
		case "begin":
			myTurn = true;
			break;
		// ����֪���������һ�ţ��������ϻ��Ƴ���������Ϣ����Ҷ����յ�
		case "oneStep":
			int whichPlayer = input.nextInt();	//�õ����ĸ���������
			int X = input.nextInt();
			int Y = input.nextInt();
			int winner = input.nextInt();
			
			placed[X][Y] = whichPlayer;
			
			myTurn = !myTurn;	//��������Ȩ
			
			board.repaint();
			
			//ʤ���Ѷ�����Ϸ����
			if (winner != -1) {
				if (winner == piecesColor)
					JOptionPane.showMessageDialog(this, "��Ӯ�ˣ�");
				else
					JOptionPane.showMessageDialog(this, "�����ˣ�");
			}
			
			break;
		}

	}

	boolean win(int X, int Y) {
		int horizontalNum = 1,	//����������
			verticalNum = 1,	//����������
			northWestNum = 1,	//10��뷽��������
			southEastNum = 1;	//1��뷽��������
		int w, h;
		
		//���������������
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
		
		//����������������
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
		
		//����10��뷽����������
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
		
		//����1��뷽����������
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
		
		//���ؽ��
		if (horizontalNum >= 5 || verticalNum >= 5
				|| northWestNum >= 5 || southEastNum >= 5)
			return true;
		return false;
	}
	
	// ���̣���¼����λ�á������û������Ϣ
	class ChessBoard extends JPanel {
		
		private int boardWidth; // ���̿�
		private int boardHeight;// ���̸�
		private int gridWidth; // ���ӿ�
		private int gridHeight; // ���Ӹ�
		private Point[][] locations; // �������н�����λ�ã��Ż��㷨
		private boolean locationCounted = false; // ��ʾλ���Ƿ�����

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
						if (placed[X][Y] == -1) { // �õ�������
							//������λ�ø�֪������
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

			// �������н�����λ��
			if (!locationCounted)
				countLocation();

			paintBoard(g); // ��������
			paintPieces(g); // ��������
		}

		// �������ϻ�����
		private void paintBoard(Graphics g) {
			// �õ�����һ��Ĵ�С��Ŀ���������߽�
			int halfGridWidth = gridWidth / 2;
			int halfGridHeight = gridHeight / 2;
			// ����
			for (int i = 0; i < GRID_AMOUNT; i++) {
				g.drawLine(i * gridWidth + halfGridWidth, halfGridHeight, i
						* gridWidth + halfGridWidth, boardHeight
						- halfGridHeight);
			}
			// ����
			for (int i = 0; i < GRID_AMOUNT; i++) {
				g.drawLine(halfGridWidth, i * gridHeight + halfGridHeight,
						boardWidth - halfGridWidth, i * gridHeight
								+ halfGridHeight);
			}
		}

		// ���Ѵ��ڵ����ӻ���������
		private void paintPieces(Graphics g) {

			int halfGridWidth = gridWidth / 2;
			int halfGridHeight = gridHeight / 2;

			for (int i = 0; i < GRID_AMOUNT; i++) {
				for (int j = 0; j < GRID_AMOUNT; j++) {
					if (placed[i][j] != -1) {	//������
						
						//������ɫ
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

		// �������н�����λ��
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

			locationCounted = true;	//�����ظ�����
		}

	}
}
