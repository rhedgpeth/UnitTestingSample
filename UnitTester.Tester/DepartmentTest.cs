using System.Collections.Generic;
using NUnit.Framework;
using UnitTester.Models;

namespace UnitTester.Tester
{
	[TestFixture()]
	public class DepartmentTest
	{
		Department department;

		[SetUp]
		public void DepartmentCreation()
		{
			department = CreateNewDummyDepartment();
		}

		[Test()]
		public void TestDepartment_Categories_IsNotNull()
		{
			Assert.IsNotNull(department.Categories);
		}

		[Test()]
		public void TestDepartment_Collections_NotNull()
		{
			Assert.IsNotNull(department.Collections);
		}

		[Test()]
		public void TestDepartment_BadNullTest_Example()
		{
			Assert.IsNotNull(null);
		}

		[Test()]
		public void TestDepartment_CountOfAllStories_NoContents_NoException()
		{
			Assert.DoesNotThrow(() => { int count = department.CountOfAllStories; });
		}

		[Test()]
		public void TestDepartment_CountOfAllItems_NoContents_NoException()
		{
			Assert.DoesNotThrow(() => { int count = department.CountOfAllStories; });
		}

		[Test()]
		public void TestDepartment_Create_Department_Add_Categories_NoException()
		{
			Assert.DoesNotThrow(() =>
			{
				CreateNewDummyDepartment(true);
			});
		}

		[Test()]
		public void TestDepartment_Create_Department_Add_Categories_Sort_Categories_NoException()
		{
			Assert.DoesNotThrow(() =>
			{
				var dept = CreateNewDummyDepartment(true);
				dept.SortCategories();
			});
		}

		private Department CreateNewDummyDepartment(bool withCategories = false)
		{
			//throw new Exception("This is an exception!");

			department = new Department
			{
				ApiUrl = "http://someurl",
				Collections = new List<Collection> { new Collection(), new Collection() },
				DescriptionText = "Description",
				DisplayName = "Name",
				IconOnly = true,
				Name = "Name",
				Url = "http://someurl",
				ShowOn = new DepartmentShowOn { Desktop = true },
				HomePageData = new Homepage()
			};

			if (withCategories)
			{
				var category1 = new Category
				{
					ApiUrl = "http://somecategoryurl",
					DisplayName = "Category 1",
					NavType = "Header"
				};

				var category2 = new Category
				{
					ApiUrl = "http://somecategoryurl",
					DisplayName = "Category 1",
					NavType = "Header"
				};

				department.Categories.AddRange(new List<Category> { category1, category2 });
			}

			return department;
		}
	}
}

