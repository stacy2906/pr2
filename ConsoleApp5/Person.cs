using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class Person
    {
        protected string name;
        protected string lastname;
        protected DateTime birth;
        protected string faculty;

        public string Name
        {
            get { return name; }
            set { Name = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public DateTime Birth
        {
            get { return birth; }
            set { birth = value; }
        }

        public string Faculty
        {
            get { return faculty; }
            set { Faculty = value; }
        }

        public Person(string name, string lastname, DateTime birth, string faculty)
        { 
            this.name = name;
            this.lastname = lastname;
            this.birth = birth;
            this.faculty = faculty;
        }

        public abstract void Info();
          

        public int Age()
        {
            DateTime now = DateTime.Now;
            int age = now.Year - birth.Year;
            if (now < birth.AddYears(age))
                age--;
            return age;

            //return DateTime.Now.Year-Birth.Year;
        }

    }
}
