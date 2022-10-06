package oop1;

public class Main {

	public static void main(String[] args) {
		//String mesaj = "Vade oran1";

		Product product1 = new Product();
		product1.setName("Delonghi Kahve Makinesi");
		product1.setDiscount(7);
		product1.setUnitPrice(7500);
		product1.setUnitsInStock(3);
		product1.setImageUrl("imagel. jpg");

		Product product2 = new Product();
		product2.setName("Delonghi Kahve Makinesi");
		product2.setDiscount(7);
		product2.setUnitPrice(7500);
		product2.setUnitsInStock(3);
		product2.setImageUrl("imagel. jpg");

		Product product3 = new Product();
		product3.setName("Kitchen Kahve Makinesi");
		product3.setDiscount(7);
		product3.setUnitPrice(7500);
		product3.setUnitsInStock(3);
		product3.setImageUrl("imagel. jpg");

		Product[] products = { product1, product2, product3 };
		
		System.out.println("<ul>");
		for (Product product : products) {
			System.out.println("<li>" + product.getName() + "</li>");
		}
		System.out.println("</ul>");

		IndividualCustomer individualCustomer = new IndividualCustomer();
		individualCustomer.setId(1);
		individualCustomer.setPhone("@565468534");
		individualCustomer.setCustomerNumber("123456");
		individualCustomer.setFirstName("Kadir");
		individualCustomer.setLastName("Secgil");
		
		CorporateCustomer corporateCustomer = new CorporateCustomer();
		corporateCustomer.setId(2);
		corporateCustomer.setCompanyName("Kodlama.io");
		corporateCustomer.setPhone("@554896534");
		corporateCustomer.setTaxNumber ("45187435768") ;
		corporateCustomer.setCustomerNumber ("54321") ;
		
		Customer[] customers = {individualCustomer,corporateCustomer};
	}

}
