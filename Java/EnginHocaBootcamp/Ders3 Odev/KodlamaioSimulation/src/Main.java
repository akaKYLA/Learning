import business.CategoryManager;
import business.CourseManager;
import business.TrainerManager;
import core.logging.BaseLogger;
import core.logging.DatabaseLogger;
import core.logging.FileLogger;
import core.logging.MailLogger;
import dataAccess.HibernateCategoryDao;
import dataAccess.HibernateTrainerDao;
import dataAccess.JdbcCategoryDao;
import dataAccess.JdbcCourseDao;
import dataAccess.JdbcTrainerDao;
import entities.Category;
import entities.Course;
import entities.Trainer;

public class Main {

	public static void main(String[] args) throws Exception {

		BaseLogger[] loggers = { new DatabaseLogger(), new FileLogger(), new MailLogger() };

		Trainer trainer = new Trainer(1, "Kadir", "Secgil");
		Category category = new Category(1, "Programing");
		Course course = new Course(1, "JavaCamp", 0, "Kadir Secgil", "Programing");

		TrainerManager trainerManager = new TrainerManager(new JdbcTrainerDao(), loggers);
		CategoryManager categoryManager = new CategoryManager(new HibernateCategoryDao(), loggers);
		CourseManager courseManager = new CourseManager(new JdbcCourseDao(), loggers);

		trainerManager.add(trainer);
		categoryManager.add(category);
		courseManager.add(course);
	}

}
