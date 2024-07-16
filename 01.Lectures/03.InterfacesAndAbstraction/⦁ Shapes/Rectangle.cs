using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace __Shapes
{
    internal class Rectangle : IDrawable
    {
        // todo
        public void Draw()
        {
            DrawLine(this.width, '*', '*');
            for (int i = 1; i< this.height - 1; i++)
            {
                DrawLine(this.width, '*', ' ');
            }
            DrawLine(this.width, '*', '*');
        }
        private void DrawLine(int width, char end, char mid)
        {
            Console.WriteLine(end);
            for (int i = 1; i < width - 1; ++i)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }
    }
}
