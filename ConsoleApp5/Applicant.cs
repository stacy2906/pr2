﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Applicant:Person
    {
        public Applicant(string name, string lastname, DateTime birth, string faculty) : base(name, lastname, birth, faculty)
        {
           
        }

        public override void Info()
        {
            Console.WriteLine($"Applicant: {name}, {lastname}, Age: {Age()}, Faculty:{faculty}");
        }
        public static Applicant Input()
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("введите фамилию");
            string lastname = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите факультет");
            string faculty = Console.ReadLine();
            return new Applicant(name, lastname, birth, faculty);
        }

    }
}
