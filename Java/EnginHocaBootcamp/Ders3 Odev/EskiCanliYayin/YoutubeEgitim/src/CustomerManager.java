
public class CustomerManager {

	private Customer _customer;
	private ICreditManager _creditManager;

	public CustomerManager(Customer customer,ICreditManager creditManager) {
		_customer = customer;
		_creditManager = creditManager;
	}

	public void Save() {
		System.out.println("Musteri Kaydedildi: ");
	}

	public void Delete() {
		System.out.println("Musteri Silindi: ");
	}
	
	public void GiveCredit() {
		_creditManager.Calculate();
		System.out.println("Kredi Verildi.");
	}
}
