package entities;

public class Course {
	int id;
	String name;
	double price;
	String trainer;
	String category;

	public Course() {
		super();
	}

	public Course(int id, String name, double price, String trainer, String category) {
		super();
		this.id = id;
		this.name = name;
		this.price = price;
		this.trainer = trainer;
		this.category = category;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public double getPrice() {
		return price;
	}

	public void setPrice(double price) {
		this.price = price;
	}

	public String getTrainer() {
		return trainer;
	}

	public void setTrainer(String trainer) {
		this.trainer = trainer;
	}

	public String getCategory() {
		return category;
	}

	public void setCategory(String category) {
		this.category = category;
	}

}
