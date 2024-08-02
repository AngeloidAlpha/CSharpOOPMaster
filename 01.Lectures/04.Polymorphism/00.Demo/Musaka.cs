using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    public abstract class Musaka : IRecipe
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
            // не се пише проверка is в майчините класове
            // начин по който не трябва да проверяваме за създадената инстанция
            // защото всеки нов клас с нов вид мусака ще трябва да създаваме нов иф
            /*
            if (this is VegetableMusaka)
            {
                Console.WriteLine("I am vegetable Musaka");
            }
            if (this is OnlyMeatMusaka)
            {
                Console.WriteLine("I am only meat Musaka");
            }
            */
            Console.WriteLine("I am musaka");
        }
        // така ще може всеки клас да си имплементира свой override за името
        // той ще е празен тук а в дъщерните ще е описан каквото е нужно за него
        public abstract void PrintAbstractName();
    }
}
