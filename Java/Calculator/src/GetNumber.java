import java.util.Scanner;

public class GetNumber {
	
	public int get() {
		Scanner input = new Scanner(System.in);
		System.out.print("\nEnter the number: ");
		return input.nextInt();
	}
}
