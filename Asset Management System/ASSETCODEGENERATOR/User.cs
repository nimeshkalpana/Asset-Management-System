using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASSETCODEGENERATOR
{
    public static class User
    {
        private static string username = "";
        private static string userType = "";

        public static void setUserName(string user_Name)
        {
            username = user_Name;
        }

        public static string getUserName()
        {
            return username;
        }

        public static void setUserType(string user_Type)
        {
            userType = user_Type;
        }

        public static string getUserType()
        {
            return userType;
        }
    }
}
