using System;
namespace UnitTester
{
	public class Shot
	{
		public string ApiUrl { get; set; }

		// TODO: Possible re-name?
		public string Coords { get; set; }
		//public string Coordinates { get; set; }

		public bool IsExternalLink { get; set; }
		//public ShotMedia Media { get; set; }
		public string Sequence { get; set; }
		public string Shape { get; set; }
		//public List<Style> Styles { get; set; } = new List<Style>();
		public string Url { get; set; }
	}
}

