
public class Calculate {
	
	public double add(int num1, int num2) {
		return num1 + num2;
		}

	public double sub(int num1, int num2) {
		return num1 - num2;
		}
	
	public double multi(int num1, int num2) {
		return num1 * num2;	
		}
		
	public double div(int num1, int num2) {
		return num1 / num2;
		}
	
	public double percent(int num1, int num2) {
		return (num1 * num2) / 100;
		}
	
	public double power(int num1, int num2) {
		return Math.pow(num1,num2);
		}
}
