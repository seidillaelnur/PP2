using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            string s = Console.ReadLine();
            string[] Arr = s.Split();

            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write(Arr[i] + " " + Arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
