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
        public static float left(float a,float b)
        {
            return a+ b;            //shiftinf can't be applied to othr than int ????
        }
        
       public static void Main(string[] args)
        {
            Console.WriteLine(left(10, 2));
            Console.WriteLine(left(10f,2f));
            Console.ReadKey();

        }
    }
}
