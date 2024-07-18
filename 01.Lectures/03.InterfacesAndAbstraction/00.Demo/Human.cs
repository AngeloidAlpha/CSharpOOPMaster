using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    public abstract class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Person : Human
    {
        public string EGN { get; set; }
    }
}
