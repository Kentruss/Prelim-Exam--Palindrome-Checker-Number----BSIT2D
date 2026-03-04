using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Checker__Number____BSIT2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string num = Console.ReadLine();

            string reverse = "";

            for (int i = num.Length - 1; i >= 0; i--)
            {
                reverse += num[i];
            }

            if (num == reverse)
            {
                Console.WriteLine(num + " is a palindrome");
            }
            else
            {
                Console.WriteLine(num + " is not a palindrome");
            }
            Console.ReadLine();
        }
    }
}