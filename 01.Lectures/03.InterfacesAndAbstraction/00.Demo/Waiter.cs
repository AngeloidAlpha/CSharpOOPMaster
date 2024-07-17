using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    public class Waiter : IOrderable, IEmployee
    {
        // тези са условието за IEmployee, няма да се компилира ако липсват тези части
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        // това е условието за IOrderable, няма да се компилира ако липсват тези части
        public void Order(string menuItem)
        {
            Console.WriteLine($"Here is your {menuItem}");
        }
    }
}
