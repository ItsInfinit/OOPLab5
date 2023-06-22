using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfOOPLab5
{
    internal class Program
    {
        public static bool IsIntegerWithSign(string input)
        {
            input = input.Trim();

            if (input.Length > 0 && (input[0] == '+' || input[0] == '-'))
            {
                input = input.Substring(1);
            }

            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check if it represents a valid signed integer:");
            string input = Console.ReadLine();

            bool isValid = IsIntegerWithSign(input);

            if (isValid)
            {
                Console.WriteLine("The input represents a valid signed integer.");
            }
            else
            {
                Console.WriteLine("The input does not represent a valid signed integer.");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
