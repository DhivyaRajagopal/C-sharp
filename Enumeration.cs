using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    class Program
    {
        public enum Month { Jan=1,Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dec}
        static void Main(string[] args)
        {
            foreach (string res in Enum.GetNames(typeof(Month)))
            {
                Console.WriteLine(res);
            }
            Console.ReadKey();
        }
    }
}
