using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the size of an array");
            int arr_size = Convert.ToInt32(Console.ReadLine()); 
            int[] arr = new int[arr_size];
            for(i=0;i<arr_size;i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < arr_size; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}