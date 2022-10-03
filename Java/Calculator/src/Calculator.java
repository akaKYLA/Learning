import java.util.Scanner;
public class Calculator {
	
	public static void printandset(double result) {
		System.out.println("\nResult: "+ result );
		baseNum = (int)result;
	}
	
	static int baseNum;
	
	public static void main(String[] args) {
		
		Scanner Input = new Scanner(System.in);
		Calculate Calc = new Calculate();
		GetNumber GetNum = new GetNumber();
		
		int process;
		double result;
	
		baseNum = GetNum.get();

		while(true) {
			System.out.println(""
					+ "\nAddition(+):1 "
					+ "| Subtraction(-):2 "
					+ "| Multiple(*):3 "
					+ "| Division(/):4 "
					+ "| Percent(%):5 "
					+ "| Power(**):6 "
					+ "| Clear(AC):7 "
					+ "| QUIT:0\n");
			System.out.print("Enter the process number: ");
			process = Input.nextInt();
			
			if (process == 0) {
				break;
			}
			
			switch(process) {
				case 1:
					result = Calc.add(baseNum, GetNum.get());
					printandset(result);
					break;
				case 2:
					result = Calc.sub(baseNum, GetNum.get());
					printandset(result);
					break;
				case 3:
					result = Calc.multi(baseNum, GetNum.get());
					printandset(result);
					break;
				case 4:
					if (GetNum.get() == 0) {
						System.out.println("Can not divide by zero!!");
						break;
					}
					else {
						result = Calc.div(baseNum, GetNum.get());
						printandset(result);
						break;
					}
				case 5:
					result = Calc.percent(baseNum, GetNum.get());
					printandset(result);
					break;
				case 6:
					result = Calc.power(baseNum, GetNum.get());
					printandset(result);
					break;
				case 7:
					process = 0;
					System.out.println("Cleared. Enter the new number: ");
					baseNum = Input.nextInt();
					break;
				default:
					System.out.println("Invalid process!!");
					break;
			}
		}
	}
}



