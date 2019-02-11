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
        static void DDD(DirectoryInfo directory, int lvl)
        {
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();

            foreach (FileInfo file in files)
            {
                for (int i = 0; i < lvl; i++) Console.Write(" ");
                Console.WriteLine(file.Name);
            }

            foreach (DirectoryInfo d in directories)
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
