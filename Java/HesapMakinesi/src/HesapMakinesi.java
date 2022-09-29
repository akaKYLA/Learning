import java.util.Scanner;
public class HesapMakinesi {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int sayi1,sayi2,islem;
		double sonuc;
		Scanner input = new Scanner(System.in);
		System.out.print("Sayi Giriniz: ");
		sayi1 = input.nextInt();
		while(true) {		
			System.out.println("Toplama:1 - Cikarma:2 - Carpma:3 - Bolme:4 - Yuzde:5 - Ussu:6 - Temizle:7 - Uygulamayi Kapat:0");
			System.out.print("Yapmak istediginiz islemi seciniz: ");
			islem = input.nextInt();
			
			if (islem == 0) {
				break;
			}
			
			switch(islem) {
				case 1:
					System.out.print("Sayi Giriniz: ");
					sayi2 = input.nextInt();
					sonuc = sayi1 + sayi2;
					System.out.println("Sonuc: "+ sonuc);
					sayi1 = (int)sonuc;
					break;
				case 2:
					System.out.print("Sayi Giriniz: ");
					sayi2 = input.nextInt();
					sonuc = sayi1 - sayi2;
					System.out.println("Sonuc: "+ sonuc);
					sayi1 = (int)sonuc;
					break;
				case 3:
					System.out.print("Sayi Giriniz: ");
					sayi2 = input.nextInt();
					sonuc = sayi1 * sayi2;
					System.out.println("Sonuc: "+ sonuc);
					sayi1 = (int)sonuc;
					break;
				case 4:
					System.out.print("Sayi Giriniz: ");
					sayi2 = input.nextInt();
					if (sayi2 == 0) {
						System.out.println("Sifira Bolunemez!!");
						break;
					}
					else {
						sonuc = sayi1 / sayi2;
						System.out.println("Sonuc: "+ sonuc);
						sayi1 = (int)sonuc;
						break;
					}
				case 5:
					System.out.print("Sayi Giriniz: ");
					sayi2 = input.nextInt();
					sonuc = (sayi1 * sayi2)/100;
					System.out.println("Sonuc: "+ sonuc);
					sayi1 = (int)sonuc;
					break;
				case 6:
					System.out.print("Sayi Giriniz: ");
					sayi2 = input.nextInt();
					sonuc = Math.pow(sayi1,sayi2);
					System.out.println("Sonuc: "+ sonuc);
					sayi1 = (int)sonuc;
					break;
				case 7:
					sonuc = 0;
					System.out.println("Islemler sifirlandi. Yeni sayiyi giriniz: ");
					sayi1 = input.nextInt();
					break;
				default:
					System.out.println("Lutfen gecerli bir islem giriniz...");
					break;
			}
		}
	}
}



