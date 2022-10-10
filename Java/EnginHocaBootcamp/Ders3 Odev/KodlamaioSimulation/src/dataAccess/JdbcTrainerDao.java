package dataAccess;

import entities.Trainer;

public class JdbcTrainerDao implements TrainerDao{

	@Override
	public void add(Trainer trainer) {
		System.out.println("Trainer saved to database with Jdbc");		
	}

}
