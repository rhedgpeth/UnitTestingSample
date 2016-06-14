using System;
using System.Collections.Generic;
using System.Linq;
using UnitTester.Enums;

namespace UnitTester.Models
{
	public class Department
	{
		public string ApiUrl { get; set; }
		public List<Category> Categories { get; set; } = new List<Category>();
		// TODO: Add SubCategories to Category objects
		public List<Collection> Collections { get; set; } = new List<Collection>();
		// TODO: SaleCategories is declared but never used
		// public List<Category> SaleCategories { get; set; } = new List<Category>();
		public string DescriptionText { get; set; }
		public string DisplayName { get; set; }
		public bool IconOnly { get; set; }
		public string Name { get; set; }
		public bool NewIn { get; set; }
		public string Url { get; set; }
		public string HighlightColor { get; set; }
		public string TextColor { get; set; }
		public DepartmentShowOn ShowOn { get; set; }
		public Homepage HomePageData { get; set; }

		// An array of post service logic applied categories. This aids in the collection view used to display the Department Categories
		public List<DepartmentCategorySection> SortedCategories { get; set; } = new List<DepartmentCategorySection>();

		public int CountOfAllStories
		{
			get
			{
				return Collections.Sum(x => x.Stories.Count);
			}
		}

		public int CountOfAllItems
		{
			get
			{
				return 15; //Collections.Sum(x => x.Stories.Sum(y => y.Spreads.Count));
			}
		}

		public void SortCategories()
		{
			if (Categories.Count == 0)
				return;

			var category = Categories[0];

			// Assume that this category contains only link, no header
			if (category.NavType.ToLower() == "link")
			{
				var section = new DepartmentCategorySection
				{
					Header = new DepartmentCategoryHeader { HeaderName = this.Name, IsNewColumn = true }
				};

				SortedCategories.Add(section);
			}

			for (int i = 0; i < Categories.Count; i++)
			{
				category = Categories[i];

				var lastSection = SortedCategories.LastOrDefault() ?? new DepartmentCategorySection();

				var type = DepartmentCategoryHeader.HeaderTypeFromString(category.NavType);

				if (type == CategoryHeaderType.CategoryTypeHeader)
				{
					var section = new DepartmentCategorySection
					{
						Header = new DepartmentCategoryHeader { HeaderName = category.Name, IsNewColumn = true }
					};

					SortedCategories.Add(section);
				}
				else if (type == CategoryHeaderType.CategoryTypeLink)
				{
					lastSection.AddCategory(category);
				}
			}
		}

		public Story StoryAtGlobalIndex(int globalIndex)
		{
			int counterValue = 0;

			foreach (var collection in Collections)
			{
				int index = globalIndex - counterValue;
				int storyCount = collection.Stories.Count;

				if ((globalIndex - counterValue) < storyCount)
					return collection.Stories[index];
				else
					counterValue += storyCount;
			}

			return null;
		}

		// TODO: Implement
		// -(NXTSpread *__nullable)spreadAtGivenIndexPath:(NSIndexPath *__nonnull)path;
		/*public Spread SpreadAtGivenIndexPath()
		{
			throw new NotImplementedException();
		}*/

		public int? IndexOfCollectionAtGlobalSection(int globalIndex)
		{
			int counterValue = 0;

			foreach (var collection in Collections)
			{
				int index = globalIndex - counterValue;
				int storyCount = collection.Stories.Count;

				if ((index) < storyCount)
					return Collections.IndexOf(collection);
				else
					counterValue += storyCount;
			}

			return null;
		}

		public int? IndexOfStoryAtGivenIndex(int globalIndex)
		{
			int counterValue = 0;

			foreach (var collection in Collections)
			{
				int index = globalIndex - counterValue;
				int storyCount = collection.Stories.Count;

				if ((index) < storyCount)
					return index;
				else
					counterValue += storyCount;
			}

			return null;
		}

		// TODO: Finish implementing
		/**
		 *  used to generate a timeline collection view for a given story and its page number
		 *
		 *  @param collectionIdx collection idx
		 *  @param story         story idx
		 *  @param spread        spread idx
		 *
		 *  @return index path
		 */
		//-(NSIndexPath * __nullable)indexPathForTimeLineForCollectionIndex:(NSInteger)collectionIdx andStory:(NSInteger)story andSpread:(NSInteger)spread;
		public object IndexPathForTimeLineForCollectionIndex(int collectionIdx, int story, int spread)
		{
			int counter = 0;

			for (int i = 0; i <= collectionIdx; i++)
			{
				var collection = Collections[i];

				if (i < collectionIdx)
					counter += collection.Stories.Count;
				else {
					counter += story;
					break;
				}
			}

			// Not *fully* implemented
			throw new NotImplementedException();

			// TODO: NSIndexPath?
			//return [NSIndexPath indexPathForRow:spread inSection:counter+1]; // -1 for the landiong page 
		}

		/*
		public string GetDisplayNameForPrimaryNav()
		{
			if (Configuration.BuildConfiguration.DepartmentNameOverrides.ContainsKey(Url))
			{
				return Configuration.BuildConfiguration.DepartmentNameOverrides[Url];
			}
			else if (!string.IsNullOrEmpty(DisplayName))
			{
				return DisplayName;
			}
			else
			{
				return Name;
			}
		}*/
	}
}

