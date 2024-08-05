using PizzaCalories.Enums;
using PizzaCalories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Dough : IIngredient
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 200;

        // достъпваме дадения енъм и му задаваме тип който да носи в случая double
        private static readonly Dictionary<FlourType, double> FlourTypeModifiers = new() 
        {
            // вземаме enum-ите и им предоставяме стойности
            [FlourType.White] = 1.5, 
            [FlourType.Wholegrain] = 1 
        };
        // достъпваме дадения енъм и му задаваме тип който да носи в случая double
        private static readonly Dictionary<BakingTechnique, double> BakingTechniqueModifiers = new() 
        { 
            // вземаме enum-ите и им предоставяме стойности
            [BakingTechnique.Crispy] = 0.9, 
            [BakingTechnique.Chewy] = 1.1, 
            [BakingTechnique.Homemade] = 1 
        };

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            if (!Enum.TryParse<FlourType>(flourType, ignoreCase: true, out var parsedFlourType)
                || !Enum.TryParse<BakingTechnique>(bakingTechnique, ignoreCase: true, out var parsedBakingTechnique)) 
                throw new ArgumentException("Invalid type of dough.");
            if (weight < MinWeight || weight > MaxWeight) 
                throw new ArgumentException($"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");

            this.Weight = weight;
            this.FlourType = parsedFlourType;
            this.BakingTechnique = parsedBakingTechnique;
        }
        // идеята на енъма е че го създаваме веднъж и може да добавяме и изваждаме променливи
        // тези променливи може да ги достигнем с FlourType.дадена променлива
        public double Weight { get; }
        public FlourType FlourType { get; }
        public BakingTechnique BakingTechnique { get; }

        public double CalculateCalories() => 
            IIngredient.BaseWeightModifier * this.Weight * FlourTypeModifiers[this.FlourType] * BakingTechniqueModifiers[this.BakingTechnique];
    }
}
