using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCS.UITests.Web.Selenium.Helpers
{
    public class RandomGenerator
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

        public virtual int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
