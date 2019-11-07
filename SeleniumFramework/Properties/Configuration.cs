using System;
namespace SeleniumFramework.Properties
{
    public static class Configuration
    {
        public static string baseURL = "http://www.todorvachev.com";

        public static class Credentials
        {
            public static class Valid
            {
                public static string username = "Clayton";
                public static string password = "12345";
                public static string repeatPassword = "12345";
            }

            public static class Invalid
            {
                public static string usernameLessThanFive = "Clay";
                public static string usernameMoreThanTweleve = "ClaytonAdamss";
                public static string password = "12345";
                public static string wrongPassword = "12345678";
                public static string repeatPassword = "12345";
            }
        }
    }
}
