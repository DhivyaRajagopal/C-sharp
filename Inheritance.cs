using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        public void sum()
        {
            int c = 5, d = 10;
            int res = c + d;
            Console.WriteLine(res);
        }
    }
    class end:Program
    {
        public void mul()
        {
            int c = 5, d = 10;
            int res = c * d;
            Console.WriteLine(res);
        }
        static void Main(String[] args)
        {
            end e = new end();
            e.sum();
            e.mul();
            Console.ReadKey();
        }
    }

}
