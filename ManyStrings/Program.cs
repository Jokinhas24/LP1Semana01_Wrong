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
            string s1 = "Love \t = \u2661 = \t Home";
            string s2 = x + "it's a number";
            string s3 = s2 + s1;

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}
