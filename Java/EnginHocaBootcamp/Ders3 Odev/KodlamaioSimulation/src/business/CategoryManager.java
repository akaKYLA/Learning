package business;

import java.util.ArrayList;

import core.logging.BaseLogger;
import dataAccess.CategoryDao;
import entities.Category;

public class CategoryManager {

	private BaseLogger[] loggers;
	private CategoryDao categoryDao;
	ArrayList<Category> categoryNames = new ArrayList<>();

	public CategoryManager(CategoryDao categoryDao, BaseLogger[] loggers) {
		this.categoryDao = categoryDao;
		this.loggers = loggers;

	}

	public void add(Category category) throws Exception {
		for (Category category1 : categoryNames) {
			if (category1.getName().equals(category.getName())) {
				throw new Exception("Category is already exist.");
			}
		}

		categoryNames.add(category);
		categoryDao.add(category);

		for (BaseLogger loggers : loggers) {
			loggers.log(category.getName());
		}
	}
}
