using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    // за какво ни е кух интерфейс? за да сортираме неща 
    // в програм имаме List<IvegetableRecipe> list = new();
    // в този лист ще може да имплементираме обекти които съдържат и тоя интерфейс.
    public interface IVegetableRecipe
    {

    }
    public class VegetableMusaka : Musaka, IVegetableRecipe
    {
        public void PrintType()
        {
            Console.WriteLine("I am vegetables only!");
        }
    }
}
