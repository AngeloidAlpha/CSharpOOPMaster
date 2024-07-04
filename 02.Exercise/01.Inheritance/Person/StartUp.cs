using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (age < 0)
            {
                Console.WriteLine("Age must be positive!");
            }
            else if (age > 15)
            {
                Person person = new Person(name, age);
                Console.WriteLine(person);
            }
            else
            {
                Child child = new Child(name, age);
                Console.WriteLine(child);
            }
        }
    }
}
