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

            string s = Console.ReadLine();

            int n = s.Length;
            bool a = true;
            for (int i = 0; i < n / 2; i++) // цикл 1
            {
                if (s[i] != s[n - i - 1]) a = false; // сравниваю 0 и n-1, 1 и n-2 и.т.д
            }

            if ( a == true ) Console.WriteLine("Yes");
            else Console.WriteLine("No");
            Console.ReadKey();
        }
    }
}