using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Waiter
            IOrderable cook = new Cook();

            cook.Order("Lasagna Bolognese");

            // Client Relevant
            // А като го извикаме чрез Interface-a така той може да прави само поръчката и е анонимен не може да достъпваме личната информация на сервитьора
            IOrderable waiter = new Waiter();
            waiter.Order("Lasagna Bolognese");
            /* Client Irelevent
            създавайки го чрез класа Waiter имаме достъпност до ненужни данни за сервитьора който може да изпълни поръчата ни
            Waiter waiter = new Waiter();
            waiter.Name = "Slavi";
            waiter.Age = 19;
            waiter.Salary = 3500;
            waiter.Order("Lasagna Bolognese");
            */
            // Managment
            IEmployee waiter2 = new Waiter();
            // тези неща са Relevant за мениджмънта
            waiter2.Name = "Slavi";
            waiter2.Age = 19;
            waiter2.Salary = 3500;
            // неща които не са relevant
            // няма да се компилира нямаме видимуст върху този метод
            // waiter2.Order("Lasagna Bolognese");
            Console.WriteLine(waiter2.Name);
            Console.WriteLine(waiter2.Salary);

            IEmployee cook2 = new Cook();
            cook2.Name = "Drago";
            cook2.Age = 33;
            cook2.Salary = 4500;

            Console.WriteLine(cook2.Name);
            Console.WriteLine(cook2.Salary);
            
            // те са различни типове но изпълняват условието IEmployee
            List<IEmployee> list = new();
            list.Add(cook2);
            list.Add(waiter2);
            list = list.OrderBy(e => e.Name)
                .ThenBy(e => e.Age)
                .ToList();

            Console.WriteLine("================");
            foreach(IEmployee item in list)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Age);
                Console.WriteLine(item.Salary);
                Console.WriteLine("//---------//");
            }
            foreach (IOrderable item in list)
            {
                item.Order("Lasagna Bolognese");
                Console.WriteLine("//---------//");
            }
            // така създаваме ние обект но без никакъв контекст в програмата която сме написали
            // обект без контекст притежава всичко достъпно с waiter3.
            Waiter waiter3 = new();
            waiter3.Name = "Context";

            // идеята на интерфейса е да знем какво прави а не как т.е.
            // искаме да поръчва но не как прави поръчката
            // искаме да приготвя ястието не как го прави
            // искаме да достави поръчката не как го прави

        }
    }
}
