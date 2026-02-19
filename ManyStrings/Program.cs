using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int x = 4;
            int y = 6;
            string s1 = "Love \t = \u2661 = \t Home";
            string s2 = x + "it's a number";
            string s3 = s2 + s1;
            string s4 = "a" + 2;
            string s5 = "abc" + x;
            string s6 = $"value of x it's {x}";
            string s7 = $"{x} plus {y} it's {x + y}";

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
        }
    }
}
