using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            string[] Arr = s.Split();

            for (int i=0; i < Arr.Length; i++)
            {
                Console.Write(Arr[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
