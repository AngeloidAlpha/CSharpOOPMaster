using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    public class CoughSyrup : IRecipe
    {
        public void GetIngridents()
        {
            Console.WriteLine("Get ingredients needed");
            Console.WriteLine("//---------------//");
        }

        public void Mix()
        {
            Console.WriteLine("Mix and shake the Bottle");
            Console.WriteLine("//---------------//");
        }

        public void Prepare()
        {
            Console.WriteLine("Close the Bottle in the Factory");
            Console.WriteLine("//---------------//");
        }
    }
}
