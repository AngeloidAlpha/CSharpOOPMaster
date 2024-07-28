using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    public class Box
    {
        // Option #1 - get-only properties
        /*
        public Box(double length, double width, double height)
        {
            // условията за нулеви и негативни стойности
            if (length <= 0) throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
            if (width <= 0) throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
            if (height <= 0) throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
            Length = length;
            Width = width;
            Height = height;
        }
        // създаваме параметрите ни
        public double Length { get; }
        public double Width { get; }
        public double Height { get; }
        */

        // Option #2 - standart properties, but private set
        // това е опция само в случаите които трябва да имам set-ер + валидация на параметрите към тоя set-er
        // които да се изпълняват във всяка една промяна на параметъра
        // тука си пишем фиилдовете на един ред те може да се манипулират при не-перфектен input за да заложим
        // перфектен input за програмата ни в property-тата ни Length (с главна буква)
        private double _length, _width, _height;
        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double Length 
        {
            get => this._length;
            private set
            {
                if (_length <= 0) throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
                this._length = value;
            }
        }
        public double Width
        {
            get => this._width;
            private set
            {
                if (_width <= 0) throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                this._width = value;
            }
        }
        public double Height
        {
            get => this._height;
            private set
            {
                if (_height <= 0) throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
                this._height = value;
            }
        }
        public double SurfaceArea() => this.LateralSurfaceArea() + 2 * this.Length * this.Width;

        // пресмятане на лицето, всяка страна дължина по височина (и те са 3 такива еднакви страни които се дублират горе/долу)
        public double LateralSurfaceArea() => 2 * (this.Length * this.Height + this.Width * this.Height);
        public double Volume() => this.Length * this.Width * this.Height;
    }
}
