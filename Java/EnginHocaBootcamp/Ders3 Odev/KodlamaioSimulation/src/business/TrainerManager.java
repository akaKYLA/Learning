package business;

import core.logging.BaseLogger;
import dataAccess.TrainerDao;
import entities.Trainer;

public class TrainerManager {

	private TrainerDao trainerDao;
	private BaseLogger[] loggers;

	public TrainerManager(TrainerDao trainerDao, BaseLogger[] loggers) {
		this.trainerDao = trainerDao;
		this.loggers = loggers;

	}

	public void add(Trainer trainer) {
		trainerDao.add(trainer);

		for (BaseLogger baseLogger : loggers) {
			baseLogger.log(trainer.getFirsName() + " " + trainer.getLastName());
		}
	}

}
