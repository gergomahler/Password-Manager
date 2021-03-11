using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Password_Manager.Services
{
    class PasswordGenerator
    {

        const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        const string UPPER_CAES = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string NUMBERS = "123456789";
        const string SPECIALS = @"!@£$%^&*()#€";

        Random random = new Random();

        private string GeneratePassword(int numOfEachCharType)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < numOfEachCharType; i++)
            {
                stringBuilder.Append(LOWER_CASE.ToCharArray()[random.Next(LOWER_CASE.Length - 1)]);
                stringBuilder.Append(UPPER_CAES.ToCharArray()[random.Next(UPPER_CAES.Length - 1)]);
                stringBuilder.Append(NUMBERS.ToCharArray()[random.Next(NUMBERS.Length - 1)]);
                stringBuilder.Append(SPECIALS.ToCharArray()[random.Next(SPECIALS.Length - 1)]);
            }
            char[] selectedChars = stringBuilder.ToString().ToCharArray();
            string Password = selectedChars.OrderBy(x => random.Next()).ToString();


            return Password;
        }
    }
}
