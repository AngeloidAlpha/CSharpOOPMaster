using Cars.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Models
{
    // абстрактен клас за да ни служи като шаблон за шаблоните които са Seat/Tesla
    public abstract class Car : ICar
    {
        protected Car(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get; set; }
        public string Color { get; set; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
        public override string ToString()
        {
            return $"{Color} {Model}";
        }
    }
}
