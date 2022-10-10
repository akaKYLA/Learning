package dataAccess;

import entities.Trainer;

public class HibernateTrainerDao implements TrainerDao {

	@Override
	public void add(Trainer trainer) {
		
		System.out.println("Trainer saved to database with Hibernate");
	}

}
