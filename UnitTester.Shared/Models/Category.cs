using System;

namespace UnitTester.Models
{

	public class Category
	{
		public string ApiUrl { get; set; }
		public string DisplayName { get; set; }
		public string Name { get; set; }
		public bool IsNew { get; set; }
		public string TextColor { get; set; }
		public string Url { get; set; }
		public int IsNewColumn { get; set; }
		public string NavType { get; set; }

		public void DoSomething()
		{
			throw new NotImplementedException();
		}
	}
}

