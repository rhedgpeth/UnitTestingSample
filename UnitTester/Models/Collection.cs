using System;
using System.Collections.Generic;

namespace UnitTester.Models
{
	public class Collection
	{
		public string ApiUrl
		{
			get;
			set;
		}

		public string DescriptionText
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public bool IsNew
		{
			get;
			set;
		}

		public bool NoTransitions
		{
			get;
			set;
		}

		public List<Story> Stories
		{
			get;
			set;
		} = new List<Story>();

		public string Url
		{
			get;
			set;
		}

		public string OverrideUrl
		{
			get;
			set;
		}

		public string Image
		{
			get;
			set;
		}
	}
}

