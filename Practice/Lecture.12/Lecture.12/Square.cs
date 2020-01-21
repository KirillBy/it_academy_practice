using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11
{
    class Square : Shapes
    {
        private readonly double _side;
        public Square(int side)
        {
            if (side <= 0)
            {
                this._side = 1;
            }
            else if(side > 10)
            {
                this._side = 10;
            }           
            else
                this._side = side;

        }
        public override double FigureSquare() => _side * _side;
    }
}
