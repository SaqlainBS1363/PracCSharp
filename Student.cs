using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracCSharp
{
    internal class Student : User
    {
        public string Department { get; set; }

        public Student(string name, string email, int age, string dept)
            : base(name, email, age)
        {
            this.Department = dept;
        }

        public override void WelcomeUser()
        {
            Console.WriteLine("Welcome Mr. " + this.Name + " as a Student");
            Console.WriteLine("\n\n");
        }

        public void IntroductionStudent()
        {
            Console.WriteLine("Hello! " + "I am " + this.Name + ", a Student.");
            Console.WriteLine("I'm in " + this.Department + " deparment");
            Console.WriteLine("\n\n");
        }

        public void IntroductionStudent(string interest)
        {
            Console.WriteLine("Hello! " + "I am " + this.Name + ", a Student.");
            Console.WriteLine("I'm in " + this.Department + " deparment");
            Console.WriteLine("I have interest in " + interest);
            Console.WriteLine("\n\n");
        }
    }
}
