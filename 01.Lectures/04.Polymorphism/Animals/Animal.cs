using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        // за да може само наследниците на анимал да използват класа Animal го пишем protected Animal
        protected Animal(string name, string favoriteFood)
        {
            Name = name;
            FavouriteFood = favoriteFood;
        }

        public string Name { get; private set; }
        public string FavouriteFood { get; private set; }
        public virtual string ExplainSelf() => $"I am {Name} and my fovourite food is {FavouriteFood}";
    }
}
