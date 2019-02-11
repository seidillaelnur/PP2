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
            List<string> list = new List<string>();  // создаю вектор

            for (int i = 0; i < Arr.Length; i++)
            {
                list.Add(Arr[i]);  //  добавляю в вектор массив 2 раза каждый
                list.Add(Arr[i]);
            }

            for (int i=0; i<list.Count; i++)
            {
                Console.Write(list[i] + " ");  //  вывожу вектор
            }
            Console.ReadKey();
        }
    }
}
