using System.Collections.Generic;

namespace UnitTester.Models
{
	public class Spread
	{
		int imageRetryCount = 0;

		public string ApiUrl
		{
			get;
			set;
		}

		public string AssetUrl
		{
			get;
			set;
		}

		public string Book
		{
			get;
			set;
		}

		public string Occurence
		{
			get;
			set;
		}

		//TODO: Mabe can be converted to an int??
		public string Page
		{
			get;
			set;
		}

		public int PageIndex
		{
			get;
			set;
		}

		public List<Shot> Shots
		{
			get;
			set;
		} = new List<Shot>();

		public bool Story
		{
			get;
			set;
		}

		public string Url
		{
			get;
			set;
		}

		public bool IsLoadingFullSpreadData
		{
			get;
			set;
		}

		public bool IsImageLoaded
		{
			get;
			set;
		}

		public float PercentDownloaded
		{
			get;
			set;
		}

		public bool IsDataLoaded
		{
			get;
			set;
		}

		public bool IsInUse
		{
			get;
			set;
		}

		//TODO: Populate Method
		public void LoadFullData()
		{

		}

		//TODO: Populate Method lowMemoryDataClearing:
		public void ClearData()
		{

		}

		//TODO: Populate Method loadSpeadImage:
		public void LoadSpeadImage()
		{

			if (imageRetryCount == 2)
				return;

			//var url = UrlHelper.
			/*@synchronized(self)
            {

                if (self.imageRetryCount ==2) {
                    return; // aint happening
                }
                NSString * url = [NXTUrlHelper CDNSpreadImageForPage:self.page forSize:NXTSpreadImageSizeFull inBook:self.book];
                if ([[UIImageView sharedImageCache]cachedImageForRequest:[NSURLRequest requestWithURL:[NSURL URLWithString:url]]]) {
                    self.imageLoaded = true;
                    return;
                }

                [[NXTService catalogueService] getSpreadImageForUrl:url completion:^(UIImage * __nonnull image) {
                    __block UIImage * fullimage= image;

                    NSURLRequest* request = [NSURLRequest requestWithURL:[NSURL URLWithString:url]];
                    [[UIImageView sharedImageCache] cacheImage:fullimage forRequest:request];
                    self.imageLoaded = true;
                    self.imageRetryCount = 0;

                } andProgressUpdateBlock:^(CGFloat progress) {
                    if (progress > self.percentDownloaded) {
                        self.percentDownloaded = progress;
                    }
                } errorBlock:^(NXTError * __nonnull error) {
                    if (error) {
                        self.imageRetryCount ++;
                    }
                }];

            }*/
		}
	}


}

