using Cars.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Models
{
    public class Seat : Car
    {
        public Seat(string model, string color) : base(model, color)
        {
        }
    }
}
