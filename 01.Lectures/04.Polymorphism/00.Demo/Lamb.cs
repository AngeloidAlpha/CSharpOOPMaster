using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    public class Lamb : IRecipe
    {
        public void GetIngridents()
        {
            Console.WriteLine("GetSalt and pepper");
            Console.WriteLine("Buy lamb leg");
            Console.WriteLine("Buy Oil");
            Console.WriteLine("=========");
        }

        public void Mix()
        {
            Console.WriteLine("Put together the salt, the pepper and the oil");
            Console.WriteLine("Rub the meat");
            Console.WriteLine("=========");
        }

        public void Prepare()
        {
            Console.WriteLine("Put in the oven for 4 hours on 180 degrees");
            Console.WriteLine("=========");
        }
    }
}
