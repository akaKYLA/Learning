package business;

import java.util.ArrayList;

import core.logging.BaseLogger;
import dataAccess.CourseDao;
import entities.Course;

public class CourseManager {

	private CourseDao courseDao;
	private BaseLogger[] loggers;
	ArrayList<Course> courseNames = new ArrayList<>();

	public CourseManager(CourseDao courseDao, BaseLogger[] loggers) {
		this.loggers = loggers;
		this.courseDao = courseDao;
	}

	public void add(Course course) throws Exception {

		if (course.getPrice() < 0) {
			throw new Exception("Course price is can not set lower than 0 ");
		}

		for (Course course1 : courseNames) {
			if (course1.getName().equals(course.getName())) {
				throw new Exception("This course already exist. ");
			}
		}
		courseDao.add(course);
		courseNames.add(course);
		for (BaseLogger baselogger : loggers) {
			baselogger.log(course.getName());
		}
	}
}
