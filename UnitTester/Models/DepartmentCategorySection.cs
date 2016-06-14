using System;
using System.Collections.Generic;

namespace UnitTester.Models
{
	public class DepartmentCategorySection
	{
		public DepartmentCategoryHeader Header { get; set; }
		public List<Category> Categories { get; private set; } = new List<Category>();


		// Explicit add existed in iOS.Core, could just expose Categories set
		public void AddCategory(Category category)
		{
			Categories.Add(category);
		}
	}
}

