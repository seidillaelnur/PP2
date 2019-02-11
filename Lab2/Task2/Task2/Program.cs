using System;
using System.IO;
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
            StreamReader sr = new StreamReader("input.txt");  //  читает текстовый файл

            string s = sr.ReadLine();     //   даем значение строке s
            string[] Arr = s.Split();
            sr.Close();     //  закрытие текстового файла input.txt

            StreamWriter sw = new StreamWriter("output.txt");     //   открытие текстового файла output.txt
            for (int i = 0; i < Arr.Length; i++)   
            {
                bool a = true;           
                int n = int.Parse(Arr[i]);
                if (int.Parse(Arr[i]) == 1) a = false;
                for (int j = 2; j <= Math.Sqrt(n); j++)
                {
                    if (int.Parse(Arr[i]) % j == 0) a = false;
                }
                if (a == true) sw.Write(Arr[i] + " ");           // проверка на простоту и вывод простого чила
            }

            sw.Close();   //  закрытие текстового файла output.txt
        }
    }
}
