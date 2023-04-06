using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracCSharp
{
    internal class Teacher : User
    {
        public int YearsOfExp { get; set; }

        public Teacher(string name, string email, int age, int yearsOfExp) 
            :base(name, email, age)
        { 
            this.YearsOfExp = yearsOfExp;
        }

        public override void WelcomeUser()
        {
            Console.WriteLine("Welcome Mr. " + this.Name + " as a Teacher");
            Console.WriteLine("");
        }

        public void IntroductionTeacher()
        {
            Console.WriteLine("Hello! " + "I am " + this.Name + ", a Teacher.");
            Console.WriteLine("I have " + this.YearsOfExp + " of experience.");
            Console.WriteLine("");
        }

        public void IntroductionTeacher(string course)
        {
            Console.WriteLine("Hello! " + "I am " + this.Name + ", a Teacher.");
            Console.WriteLine("I have " + this.YearsOfExp + " of experience.");
            Console.WriteLine("I will teach " + course);
            Console.WriteLine("");
        }
    }
}
