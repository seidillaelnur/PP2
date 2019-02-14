using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Student    //  новая функция Студент
    {
        string name, Id;
        int year;

        public Student(string name, string Id)  //  функция студент которая используется
        {                                       //  в начале
            this.name = name;
            this.Id = Id;
            this.year = 1;
        }

        public string getName()  //  имя остается не изменным
        {
            return this.name;
        }

        public string getId()  //  Id остается не изменным
        {
            return this.Id;
        }

        public void incYear()   // увеличиваем год
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
            Student s = new Student("Yelnur", "18BD110385");  //  мои данные
            Console.WriteLine(s);    
            s.incYear();
            Console.WriteLine(s);     // вывожу 4 раза (имя, Id, год)
            s.incYear();
            Console.WriteLine(s);
            s.incYear();
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
