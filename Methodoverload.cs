//Method overloading- same function name with differnet parameters




using System;

namespace Methodoverloading
{
    public class Program
    {
        public static int left(int a,int b) //same function name
        {
            return a << b;
        }
        public static int left(int a,int b,int c)
        {
            return c = a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(left(10, 2));
            Console.WriteLine(left(10, 2,0));
            Console.ReadKey();
        }
    }
}
