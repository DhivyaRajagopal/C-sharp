using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static int arr_size; 
        static int[] arr;

        static void printArray(int[] ar)
        {
            int i;
            arr_size= Convert.ToInt32(Console.ReadLine());
           arr=new int[arr_size];
            for (i = 0; i < arr_size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < arr_size; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of an array");
            printArray(arr);
            Console.ReadKey();
        }
    }
}
