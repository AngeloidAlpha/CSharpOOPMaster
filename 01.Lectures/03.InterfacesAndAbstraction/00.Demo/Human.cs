using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    public abstract class Human
    {
        protected Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public abstract void PrintNameAndAge();
    }
    public class Person : Human
    {
        public Person(string name, int age, string egn) : base(name, age)
        {
            EGN = egn;
        }
        public string EGN { get; set; }
        public override void PrintNameAndAge()
        {
            Console.WriteLine(Name + " " + Age);
        }
    }
}
