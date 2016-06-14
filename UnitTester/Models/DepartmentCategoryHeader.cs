using System;
using UnitTester.Enums;

namespace UnitTester.Models
{
	public class DepartmentCategoryHeader
	{
		public string HeaderName { get; set; }
		public bool IsNewColumn { get; set; }

		public static CategoryHeaderType HeaderTypeFromString(string type)
		{
			if (!string.IsNullOrEmpty(type) && type.ToLower() == "header")
				return CategoryHeaderType.CategoryTypeHeader;
			else
				return CategoryHeaderType.CategoryTypeLink;
		}
	}
}

