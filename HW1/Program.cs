using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a string: ");
                string input = Console.ReadLine();

                if (input == "*")
                    break;

                string reversed = "";
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversed += input[i];
                }

                bool isPalindrome = (input.ToLower() == reversed.ToLower());

                Console.WriteLine();
                Console.WriteLine($"{"Original String",-20}{"Reversed String",-25}{"Palindrome?"}");
                Console.WriteLine($" {input,-20}{reversed.ToLower(),-25}{(isPalindrome ? "Yes" : "No")}");
                Console.WriteLine();

            }

            Console.WriteLine();

        }
    }
}