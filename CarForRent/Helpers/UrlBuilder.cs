using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarForRent.Helpers
{
    public static class UrlBuilder
    {
        public static String BuildAutoImageUrl(String fileName)
        {
            return String.Format("{0}{1}", UrlConstants.AutoImagesFilesDirectory, fileName);
        }
    }
}