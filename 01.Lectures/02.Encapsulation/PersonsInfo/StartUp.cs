using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    // за да запишем като default namespace може да влезем в dependencies
    // там след това записваме <RootNamespace>PersonsInfo</RootNamespace> 
    // има с десен клик и на опции може да се стигне до default namespace
    // така всеки клас ще има записан namespace
    public class StartUp
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                try // в try питаме дали може да има грешка в кода?
                {
                    // проверява още докато създава човека дали годините му са нормални
                    // защото не са той спира програмата и дава exeption
                    var person = new Person(cmdArgs[0],
                                            cmdArgs[1],
                                            int.Parse(cmdArgs[2]), // ето тук
                                            decimal.Parse(cmdArgs[3]));
                    // за да ни изпише какъв е проблема както сме записали в класа Person
                    // тябва да изпишем нещата с try and catch
                    persons.Add(person);
                }
                catch (Exception ex) // ако имаме грешка в try то в catch-a ще вземе throw exeption-a и ще ни го изпише в конзолата
                { 
                    Console.WriteLine(ex.Message); 
                } 
            }
            /* задача 3
            var parcentage = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(parcentage));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
            */
            Team team = new Team("SoftUni");

            foreach (Person person in persons)
            {
                team.AddPlayer(person);
            }
        }
    }
}
