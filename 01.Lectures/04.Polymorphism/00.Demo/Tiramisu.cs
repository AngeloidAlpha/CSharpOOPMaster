using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    public class Tiramisu : IRecipe
    {
        public void GetIngridents()
        {
            Console.WriteLine("Get coffee and biscuites and eggs");
        }

        public void Mix()
        {
            Console.WriteLine("Mix them all together");
        }

        public void Prepare()
        {
            Console.WriteLine("Put in form and after in the fridge for 2 hours");
        }
    }
}
