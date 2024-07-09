using _00.Demo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    // некапсулиран клас всичко е достъпно от външния свят
    // в програмирането нещо което не е разрешено е позволено (т.е. експлатира се)
    /*
        public class Student
    {
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            AvarageGrades = new Dictionary<string, double>();
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public Dictionary<string, double> AvarageGrades { get; set; }
    }
    */

    // ако изпишем класа да е internal class Student той тогава ще иска класове само в scope-a 00.Demo
    public class Student
    {
        // за да премахнем изцяло възможноста за променяне на имената на студентите
        // private string name;
        // после пишем this.name = name;
        // и после отдолу е public string Name { get => name; }

        private string name;
        private int age;
        // ще капсулирам AvarageGrades
        private readonly Dictionary<string, double> avarageGrades;
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            this.avarageGrades = new Dictionary<string, double>();
        }
        // ще трябва да валидираме приети стойности (имена или години) 
        // не може да приемем отрицателни години например
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2) // така не мога да го създам с null или празно
                    // 2рия въпрос е за под 2 букви да не е валидна стойност
                {
                    throw new ArgumentException("Name is invalid");
                }
                name = value;
            }
        }
        // protected int Age може да бъде достъпен от Junior но не и от Program
        protected int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18)
                {
                    throw new ArgumentException("Age is invalid");
                }
                age = value;
            }
        }
        // така написахме че да влизаме в Dictinary с оценките но да не използваме 
        /*
        public Dictionary<string, double> AvarageGrades 
        { 
            get => avarageGrades;
            set => avarageGrades = value;
        }
        */
        public void AddAvarageGrade(string subject, double avarageGrade)
        {
            if (string.IsNullOrWhiteSpace(subject))
            {
                throw new ArgumentException("Invalid Subject");
            }
            if (avarageGrade < 2 || avarageGrade > 6)
            {
                throw new ArgumentException("Invalid AvarageGrade");
            }
            avarageGrades.Add(subject, avarageGrade);
        }
        public void PrintAvarageGrade()
        {
            foreach (var item in avarageGrades)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
        public void DoClear()
        {
            // ако нямаме горе private readonly Dictionary<string, double> avarageGrades;
            // то ние ще може да презапишем нова бибютека която е празна
            // avarageGrades = new Dictionary<string, double>();

            // но по този начин ще може да влезнем и изтрием
            avarageGrades.Clear();
        }
        public Student GetCurrent()
        {
            return this;
        }
    }
}
public class Junior : Student
{
    public Junior(string name, int age) : base(name, age)
    {
    }
    public void DoJunior()
    {
        Age = 20;
    }
}
