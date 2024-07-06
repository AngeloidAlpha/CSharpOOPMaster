using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double DefaultCoffeeMilliliters = 50;
        private const decimal DefaultCoffeePrice = 3.50m;
        public Coffee(string name, double caffeine) : base(name, DefaultCoffeePrice, DefaultCoffeeMilliliters)
        {
            this.Caffeine = caffeine;
        }

        public double Caffeine { get; }
    }
}
