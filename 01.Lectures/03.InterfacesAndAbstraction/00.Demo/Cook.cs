using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    public class Cook : IOrderable, IEmployee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public void Order(string menuItem)
        {
            Console.WriteLine($"Preparing your {menuItem}");
        }
    }
}
