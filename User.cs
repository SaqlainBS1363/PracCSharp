using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracCSharp
{
    internal class User
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int? Age { get; set; }

        public User() 
        { 

        }

        public User(string email, int age)
        {
            this.Email = email;
            this.Age = age;
        }

        public User(string name, string email, int age)
            :this(email, age)
        {
            this.Name = name;
        }

        public void Rules()
        {
            Console.WriteLine("");
            Console.WriteLine("Rules and regulations of 2023");
            Console.WriteLine("");
        }

        public virtual void WelcomeUser()
        {
            Console.WriteLine("----System of C#----");
        }
    }
}
