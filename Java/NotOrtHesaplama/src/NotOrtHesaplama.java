import java.util.Scanner;

public class NotOrtHesaplama {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		System.out.println("Not Ortalamasi Hesaplama Programina Hosgeldiniz..");
		
		Scanner input = new Scanner(System.in);
		
		int ilksinav,ikincisinav,ucuncusinav;
		float ortalama;
		
		System.out.print("Ilk sinav notu :");
		ilksinav = input.nextInt();
		System.out.print("Ikinci sinav notu :");
		ikincisinav = input.nextInt();
		System.out.print("Ucuncu sinav notu :");
		ucuncusinav = input.nextInt();
		
		ortalama = (ilksinav + ikincisinav + ucuncusinav) / 3;
		String durum = (ortalama >=50) ? "Gectiniz" : "Kaldiniz";
		System.out.println("Ortalamaniz : "+ortalama + " " + durum);

	}

}
