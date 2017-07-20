/*Properties*/
//value is a keyword


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //private int id;
        private string name;
        //public int Id
        public string Name
        {
           
            set
            {
                //id = value;
                name = value+"Java";
            }
            get
            {
                return name;
            }

        }
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.Name = "Sab";
            //prog.Id = 10;
            //Console.WriteLine("ID is :" + prog.Id);
            Console.WriteLine("Name is:" + prog.Name);
            Console.ReadKey();
        }
    }
}
