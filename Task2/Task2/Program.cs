using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Student
    {
        string name, Id;
        int year;

        public Student(string name, string Id)
        {
            this.name = name;
            this.Id = Id;
            this.year = 1;
        }

        public string getName()
        {
            return this.name;
        }

        public string getId()
        {
            return this.Id;
        }

        public void incYear()
        {
            this.year++;
        }

        public override string ToString()
        {
            return name + " " + Id + " " + year;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Yelnur", "18BD110385");
            Console.WriteLine(s);
            s.incYear();
            Console.WriteLine(s);
            s.incYear();
            Console.WriteLine(s);
            s.incYear();
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
