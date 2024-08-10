using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Pizza
    {
        private const int MaxNameLength = 15;
        private const int MaxToppingsCount = 10;

        private readonly List<Topping> _toppings;

        public Pizza(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length > MaxNameLength) 
                throw new ArgumentException($"Pizza name should be between 1 and {MaxNameLength} symbols.");
            this.Name = name;

            this._toppings = new List<Topping>();
            this.Toppings = this._toppings.AsReadOnly();
        }

        public string Name { get; }
        public Dough Dough { get; set; }
        public IReadOnlyCollection<Topping> Toppings { get; }
        public int ToppingsCount => this._toppings.Count;
        public double TotalCalories => this.Dough.CalculateCalories() + this._toppings.Sum(t => t.CalculateCalories());

        public void AddTopping(Topping topping)
        {
            // ако достигнем максималния брой топпинг изписваме грешка
            // поставяме нов топинг само ако не изпише че вече сме на макс (втората част няма да се изпълни от кода)
            if (this._toppings.Count == MaxToppingsCount) 
                throw new InvalidOperationException($"Number of toppings should be in range [0..{MaxToppingsCount}].");
            this._toppings.Add(topping);
        }
        // в програмата като извиквам отговора с Console.WriteLine(pizza); то всъщност достъпвам ToString() който сме написали отдолу
        public override string ToString() => $"{this.Name} - {this.TotalCalories:f2} Calories.";
    }
}
