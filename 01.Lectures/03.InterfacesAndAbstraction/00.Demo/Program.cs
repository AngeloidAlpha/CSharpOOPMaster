using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new("Slavi", 20);
            person.PrintNameAndAge();
        }
    }
}
