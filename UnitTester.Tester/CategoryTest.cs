using NUnit.Framework;
using UnitTester.Models;

namespace UnitTester.Tester
{
	public class CategoryTest
	{
		[SetUp]
		public void CategoryTestSetup()
		{
			// Do initialization type things here
		}

		[Test()]
		public void TestDepartment_Categories_IsNotNull()
		{
			Assert.IsNotNull(new Category());
		}

		[Test()]
		public void TestCategory_DoSomething_ThrowsException()
		{
			var category = new Category();
			//Assert.DoesNotThrow(() => { category.DoSomething(); } );
		}
	}
}

