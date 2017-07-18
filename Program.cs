using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNDObjects
{
    class Program
    {
         static void method(int i,int j)
        {
            Console.WriteLine(i << j);
        }
        static void Main(string[] args)
        {
            //Program p = new Program();
            //p.method(10, 2);                      //use obj OR function call through static
            method(10, 2);
            Console.ReadKey();
        }
    }
}
