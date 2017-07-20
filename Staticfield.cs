using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticField
{
    static class Program
    {
        
        public static int i = 10;
        public static void display()
        {
            Console.WriteLine("hello"+i);
        }
      
        static void Main(string[] args)
        {
            i = 100;
            Program.display();
            Console.ReadKey();
        }
    }
}
