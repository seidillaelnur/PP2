using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = @"D:\PP2\Lab2\Task4\1\1.txt";    //  путь файла s (1)
            string s1 = @"D:\PP2\Lab2\Task4\2\2.txt";   //  путь файла s1 (2)
            if (!File.Exists(s))
            {
                using (StreamWriter sw = File.CreateText(s))   //    поиск файла s
                {
                    sw.WriteLine("Done");
                }
            }
            File.Copy(@s, @s1);   //  копирование файла
            File.Delete(@s);      //  удаление

            Console.ReadKey();
        }
    }
}