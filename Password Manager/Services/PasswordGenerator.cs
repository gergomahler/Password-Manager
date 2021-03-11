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
            List<char> pswChars = new List<char>();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < numOfEachCharType; i++)
            {
                pswChars.Add(LOWER_CASE.ToCharArray()[random.Next(LOWER_CASE.Length - 1)]);
                pswChars.Add(UPPER_CAES.ToCharArray()[random.Next(UPPER_CAES.Length - 1)]);
                pswChars.Add(NUMBERS.ToCharArray()[random.Next(NUMBERS.Length - 1)]);
                pswChars.Add(SPECIALS.ToCharArray()[random.Next(SPECIALS.Length - 1)]);
            }

            Shuffle(pswChars);

            foreach (char c in pswChars)
            {
                stringBuilder.Append(c);
            }

            string Password = stringBuilder.ToString();


            return Password;
        }

        public void Shuffle<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                int k = (random.Next(0, n) % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
