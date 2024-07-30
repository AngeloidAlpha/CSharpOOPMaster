using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    public class Musaka : IRecipe
    {
        public void GetIngridents()
        {
            Console.WriteLine("GetSalt and pepper");
            Console.WriteLine("Buy carrots, onions, potatos and minced meat");
            Console.WriteLine("Buy Oil");
            Console.WriteLine("=========");
        }

        public void Mix()
        {
            Console.WriteLine("Cut the vegetables and mix them together");
            Console.WriteLine("Cut minced meat in smal pieces");
            Console.WriteLine("=========");
        }

        public void Prepare()
        {
            Console.WriteLine("Fry the vegetables");
            Console.WriteLine("Add meat to them");
            Console.WriteLine("Put in the over for 2 hours on 180 degrees");
            Console.WriteLine("=========");
        }
        public void PrintName()
        {
            Console.WriteLine("I am musaka");
        }
    }
}
