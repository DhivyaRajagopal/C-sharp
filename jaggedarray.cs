using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][];   //declaration
            a[0] = new int[] { 10, 20 };
            a[1] = new int[] { 25, 45 };
            a[2] = new int[] { 45, 78 };
            for(int i=0;i<a.Length;i++)
            {
                for(int j=0;j<a[i].Length;j++)
                {
                    Console.WriteLine(a[i][j]);
                }
            }
            Console.ReadKey();
        }
    }
}
