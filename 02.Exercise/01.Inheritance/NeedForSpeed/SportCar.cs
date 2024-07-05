using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        // защото имаме private не правим конфликт с останалите константи
        private const double DefaultFuelConsumption = 10;
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
        public override double FuelConsumption => DefaultFuelConsumption;
    }
}
