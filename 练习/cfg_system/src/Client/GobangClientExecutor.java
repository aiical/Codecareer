package Client;

public class GobangClientExecutor {
	public static void main(String[] args) {
		GobangClient gobangClient;
		if (args.length == 0)
			gobangClient = new GobangClient("127.0.0.1"); // localhost
		else
			gobangClient = new GobangClient(args[0]); // use args

		gobangClient.setVisible(true);
	}
}
