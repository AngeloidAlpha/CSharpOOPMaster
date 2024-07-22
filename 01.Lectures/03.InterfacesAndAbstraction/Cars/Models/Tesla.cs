using Cars.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Models
{
    public class Tesla : Car
    {
        public Tesla(string model, string color, int battery) : base(model, color)
        {
            Battery = battery;
        }

        public int Battery { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} with {Battery} Batteries";
        }
    }
}
