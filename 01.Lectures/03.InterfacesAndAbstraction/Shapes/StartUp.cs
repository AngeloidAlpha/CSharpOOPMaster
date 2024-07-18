using System;
using Shapes.Models;
using Shapes.Models.Interfaces;
using System.Collections.Generic;

namespace Shapes
{
    public class StartUp
    {
        static void Main()
        {
            var radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);

            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(width, height);

            ICollection<IDrawable> figures = new List<IDrawable>();
            
            figures.Add(circle);
            figures.Add(rect);

            foreach (IDrawable figure in figures)
            {
                figure.Draw();
            }

        }
    }
}
