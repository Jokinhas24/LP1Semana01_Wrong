using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            sbyte int1 = 2;
            short int2 = 4;
            int int3 = 6;
            long int4 = 8;

            char char1 = '\u2661';
            char char2 = '\u2605';
            char char3 = '\uFF04';
            char char4 = '\u2691';

            float ft1 = 1.5f;
            double ft2 = 3.5;
            decimal ft3 = 5.5m;

            bool bl1 = true;
            bool bl2 = false;

            Console.WriteLine(int1);
            Console.WriteLine(int2);
            Console.WriteLine(int3);
            Console.WriteLine(int4);

            Console.WriteLine(char1);
            Console.WriteLine(char2);
            Console.WriteLine(char3);
            Console.WriteLine(char4);

            Console.WriteLine(ft1);
            Console.WriteLine(ft2);
            Console.WriteLine(ft3);

            Console.WriteLine(bl1);
            Console.WriteLine(bl2);
        }
    }
}
