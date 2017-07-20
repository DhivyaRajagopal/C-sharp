//Member(variable) overloading

//same function name with differnt return type.

using System;
namespace Memberoverloading
{
 public class Program
    {
        public static int left(int a,int b)
        {
            return a << b;
        }
        public static double right(int a,int b)
        {
            return a >> b;
        }
        
       public static void Main(string[] args)
        {
            Console.WriteLine(left(10, 2));
            Console.WriteLine(right(10,2));
            Console.ReadKey();

        }
    }
}
