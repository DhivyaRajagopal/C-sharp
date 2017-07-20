using System;
using System.Collections.Generic;
using System.Linq;
//same as C

using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Program
    { 
        struct Usage
        {
           public  int i;
            public Boolean j;

        };
        static void Main(string[] args)
        {
            Usage u;
            u.i = 10;
            u.j = false;
            Console.WriteLine(u.i + " " + u.j);
            Console.ReadKey();

        }
    }
}
