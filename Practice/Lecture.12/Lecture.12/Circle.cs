using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11
{
    class Circle : Shapes
    {
        private readonly double _radius;
        public Circle(double radius)
        {
            if (radius <= 0)
            {

                this._radius = 1;
            }
            else if (radius > 10)
            {
                this._radius = 10;
            }
            else
                this._radius = radius;
        }
        public override double FigureSquare() => Math.PI * _radius * _radius;
    }
}
