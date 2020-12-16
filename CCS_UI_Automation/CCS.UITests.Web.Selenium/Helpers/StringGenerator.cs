using System;
using System.Text;

namespace CCS.UITests.Web.Selenium.Helpers
{
    public class StringGenerator
    {
        public static Random random = new Random();
        public string GenerateRandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            string randomString = String.Empty;
            char ch;

            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            randomString = builder.ToString().ToLower();
            randomString = char.ToUpper(randomString[0]) + randomString.Substring(1);

            return randomString;
        }

        public string GenerateRandomEmail(int size)
        {
            StringBuilder builder = new StringBuilder();
            string randomString = String.Empty;
            char ch;

            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            randomString = builder.ToString().ToLower();
            randomString = char.ToUpper(randomString[0]) + randomString.Substring(1);

            return randomString.ToLower() + "@yopmail.com";


        }

        public string GenerateRandomNumber(int size)
        {
            string randomString = String.Empty;
            string ch;

            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToString(random.Next(0, 10));
                randomString = randomString + ch;
            }
            return randomString;
        }
    }
}