using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Teacher:Person
    {
        protected string position;
        protected int experience;

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public int Experience
        {
            get { return experience; }
            set { experience  = value; }
        }

        public Teacher(string name, string lastname, DateTime birth, string faculty, string position, int experience) : base(name, lastname, birth, faculty)
        {
            this.position = position;
            this.experience = experience;
        }

        public override void Info()
        {
            Console.WriteLine($"Teacher: {name}, {lastname}, Age: {Age()}, Faculty:{faculty}, Position: {position}, Experience: {experience}");
        }

        public static Teacher Input()
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("введите фамилию");
            string lastname = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите факультет");
            string faculty = Console.ReadLine();
            Console.WriteLine("Введите должность");
            string position = Console.ReadLine();
            Console.WriteLine("введите стаж");
            int experience = Convert.ToInt32(Console.ReadLine());
            return new Teacher(name, lastname, birth, faculty, position, experience);
        }
    }
}
