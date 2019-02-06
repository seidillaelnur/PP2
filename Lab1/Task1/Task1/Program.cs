using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();

            string s = Console.ReadLine();

            string[] Arr = s.Split();

            List<int> list = new List<int>();

            for (int i = 0; i < Arr.Length; i++)
            {

                int a = 0;

                for (int j = 2; j <= Math.Sqrt(double.Parse(Arr[i])); j++)
                {
                    if (int.Parse(Arr[i]) % j == 0) a = 1;
                }
                if (a == 0 && int.Parse(Arr[i]) != 1) list.Add(int.Parse(Arr[i]));
                a = 0;
            }

            Console.WriteLine(list.Count);
            for (int i=0; i<list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
