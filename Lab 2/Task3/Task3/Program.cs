// using TPower
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void DDD(DirectoryInfo directory, int lvl)  //  ds, 0
        {
            FileInfo[] files = directory.GetFiles();   //  список файлов текущего каталога
            DirectoryInfo[] directories = directory.GetDirectories();  //  список файлов подкаталога текущего каталога

            foreach (FileInfo f in files)  // для каждого файла цикл
            {
                for (int i = 0; i < lvl; i++) Console.Write(" ");
                Console.WriteLine(f.Name);
            }

            foreach (DirectoryInfo d in directories)  //  для каждой папки цикл
            {
                for (int i = 0; i < lvl; i++) Console.Write(" ");
                Console.WriteLine(d.Name);
                DDD(d, lvl + 3);
            }
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            DirectoryInfo ds = new DirectoryInfo(@s);
            DDD(ds, 0);
            Console.ReadKey();
        }
    }
}
