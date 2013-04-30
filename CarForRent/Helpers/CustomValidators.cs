using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarForRent.Helpers
{
    public static class CustomValidators
    {
        public static bool ValidateFile(HttpPostedFileBase file)
        {
            return (file != null && file.ContentLength > 0);
        }
    }
}