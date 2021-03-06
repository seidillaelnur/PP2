﻿using System;
using System.IO;

namespace Task1
{
    class FarManager
    {
        public int cursor;
        public string path;
        public int sz;
        public int k = 0;
        public bool ok;
        DirectoryInfo directory = null;
        FileSystemInfo currentFs = null;

        public FarManager()
        {
            cursor = 0;
        }

        public FarManager(string path)
        {
            this.path = path;
            cursor = 0;
            directory = new DirectoryInfo(path);
            sz = directory.GetFileSystemInfos().Length;
            ok = true;
        }

        public void Color(FileSystemInfo fs, int index)    //  создание цвета
        {
            if (cursor == index)   //  мы находимся на этом
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                currentFs = fs;
            }
            else if (fs.GetType() == typeof(DirectoryInfo))    //  если папка
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else   //  если файл
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            for (int i = 0, k = 0; i < fs.Length; i++)
            {
                if (ok == false && fs[i].Name[0] == '.')
                {
                    continue;
                }
                Color(fs[i], k);
                Console.WriteLine(fs[i].Name);
                k++;
            }
            //Console.WriteLine(path);
        }
        public void Up()
        {
            cursor--;
            if (cursor < 0)
                cursor = sz - 1;
        }
        public void Down()
        {
            cursor++;
            if (cursor == sz)
                cursor = 0;
        }

        public void CalcSz()
        {
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            sz = fs.Length;
            if (ok == false)
                for (int i = 0; i < fs.Length; i++)
                    if (fs[i].Name[0] == '.')  //  уменьшает размер, если есть скрытые файлы и ok равен нулю
                        sz--;
        }

        public void openfile(FileSystemInfo fsi)
        {
            k = 1;

            Console.BackgroundColor = ConsoleColor.White;   
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            StreamReader sr = new StreamReader(fsi.FullName);   //  открытие файла  .txt
            Console.WriteLine(sr.ReadToEnd());
        }


        public void Start()
        {
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            while (consoleKey.Key != ConsoleKey.Escape)  //  когда ESС, выходит
            {
                if (k == 0)
                {
                    Show();
                }
                else
                {
                    openfile(currentFs);
                }

                CalcSz();

                consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.UpArrow)  //  вверх и вниз
                    Up();
                if (consoleKey.Key == ConsoleKey.DownArrow)
                    Down();
                if (consoleKey.Key == ConsoleKey.RightArrow)  // скрывает скрытые файлы
                {
                    ok = false;
                    cursor = 0;
                }
                if (consoleKey.Key == ConsoleKey.LeftArrow)  // показывает скрытые файлы
                {
                    cursor = 0;
                    ok = true;
                }
                if (consoleKey.Key == ConsoleKey.Enter)   //  вход, если это папка
                {
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                    {
                        cursor = 0;
                        path = path + "/" + currentFs.Name;
                    }
                    else k = 1;
                }
                if (consoleKey.Key == ConsoleKey.Backspace)  //  возвращение назад
                {
                    if (k == 0)
                    {
                        cursor = 0;
                        path = directory.Parent.FullName;
                    }
                    else k = 0;

                }
                if (consoleKey.Key == ConsoleKey.Delete)
                {
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                    {
                        Directory.Delete(currentFs.FullName, true);
                    }
                    else
                    {
                        File.Delete(currentFs.FullName);
                    }
                    if (cursor != 0)
                    {
                        cursor--;
                    }

                }
                if (consoleKey.Key == ConsoleKey.S)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.Write("Enter new name: ");
                    string s = Console.ReadLine();
                    Console.WriteLine("Press enter to confirm");

                    if (consoleKey.Key == ConsoleKey.Enter)
                    {
                        string s1 = currentFs.FullName;

                        if (currentFs.GetType() == typeof(FileInfo))
                        {
                            FileInfo f = new FileInfo(currentFs.FullName);
                            string a = Path.Combine(f.DirectoryName, s);

                            File.Move(f.FullName, a);
                        }
                        else
                        {
                            DirectoryInfo d = new DirectoryInfo(currentFs.FullName);
                            string a = Path.Combine(d.Parent.FullName, s);
                            Directory.Move(currentFs.FullName, a);
                        }

                    }

                }
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\PP2";
            FarManager farManager = new FarManager(path);
            farManager.Start();
        }
    }
}