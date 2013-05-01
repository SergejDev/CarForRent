using CarForRent.Models;
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

        public static bool ValidatePersonalInformation(UserProfile user)
        {
            return (!String.IsNullOrEmpty(user.UserFirstName) && !String.IsNullOrEmpty(user.UserMidleName)
                && !String.IsNullOrEmpty(user.UserLastName) && !String.IsNullOrEmpty(user.PassportNumber));
        }

        public static bool ValidateAutosCount(Auto auto)
        {
            return (auto.AutoCount > 0);
        }
    }
}