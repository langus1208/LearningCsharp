// See https://aka.ms/new-console-template for more information

using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string digits = "1234567890";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string specialChars = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            int score = 0;

            Console.WriteLine("Input your password: ");
            string password = Console.ReadLine();

            if (password.Length >= 8)
            {
                score += 1;
            }
            if (Tools.Contains(password, digits))
            {
                score += 1;
            }
            if (Tools.Contains(password, lowercase))
            {
                score += 1;
            }
            if (Tools.Contains(password, uppercase))
            {
                score += 1;
            }
            if (Tools.Contains(password, specialChars))
            {
                score += 1;
            }

            switch (score)
            {
                case 1:
                    Console.WriteLine("Your password is weak");
                    break;
                case 2:
                    Console.WriteLine("Your password is medium");
                    break;
                case 3:
                    Console.WriteLine("Your password is strong");
                    break;
                case 4:
                    Console.WriteLine("Your password is very strong");
                    break;
                case 5:
                    Console.WriteLine("Your password is extremely strong");
                    break;
                default:
                    break;

            }


            


        }
    }
}

