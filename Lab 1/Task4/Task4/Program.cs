using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  // присваивание значение к int

            for (int i = 1; i <= n; i++)  //  цикл 1
            {
                for (int j = 1; j <= i; j++)  //  цикл 2
                {
                    Console.Write("[*]"); // вывод
                }
                Console.WriteLine();  // переход на следующюю строку
            }
            Console.ReadKey();
        }
    }
}
