using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Student:Person
    {
        protected int course;

        public int Course
        {
            get { return course; }
            set { course = value; }
        }
        public Student(string name, string lastname, DateTime birth, string faculty, int course):base(name, lastname, birth,faculty)
        {
            this.course = course;
        }

        public override void Info()
        {
            Console.WriteLine($"Student: {name}, {lastname}, Age: {Age()}, Faculty:{faculty}, Course: {course}");
        }

        public static Student Input()
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("введите фамилию");
            string lastname = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите факультет");
            string faculty = Console.ReadLine();
            Console.WriteLine("Введите курс");
            int course = Convert.ToInt32(Console.ReadLine());
            return new Student(name, lastname, birth, faculty,course);
        }
    }
}
