using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Program

    {
        public int id;
        public String name;
        public float salary;
        public Program employee(int i, String n, float s)
        {
            id = i;
            name = n;
            salary = s;
            return this;
        }
        public Program display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
            return this;
        }
    }
    class TestProgram
    {
        public static void Main(string[] args)
        {
            Program e1 = new Program().employee(101, "Sonoo", 890000f).display();
            //Program e2 = new Program(102, "Mahesh", 490000f);      //for void in function v can't use this builder pattern
            //e1.display();
            //e2.display();
            Console.ReadKey();

        }
    }
}
