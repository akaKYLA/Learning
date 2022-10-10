package core.logging;

public class DatabaseLogger implements BaseLogger {
	public void log(String data) {
		System.out.println("Logged to database: " + data);
	}
}
