using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public int HorsePower { get; set; }
        public double Fuel { get ; private set; }
        public virtual double FuelConsumption => DefaultFuelConsumption;
        //public virtual double FuelConsumption { get; } = DefaultFuelConsumption;
        public virtual void Drive(double kilometers)
        {
            // ще запише грешка ако имаме само { get;} но не и set (private set ще го вижда само този клас никой друг)
            this.Fuel -= kilometers * this.FuelConsumption;
        }
    }
}
