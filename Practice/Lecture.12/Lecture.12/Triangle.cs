using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11
{
    class Triangle : Shapes
    {
        private readonly double _ab;
        private readonly double _bc;
        private readonly double _ca;

        public Triangle(double ab, double bc, double ca)
        {
            if (ab <= 0 || bc <= 0 || ca <= 0)
            {
                 this._ab = 1;
                 this._bc = 1;
                 this._ca = 1;
            }
            else if(ab > 10 || bc > 10 || ca > 10)
            {
                this._ab = 10;
                this._bc = 10;
                this._ca = 10;
            }
            else
            {
                this._ab = 10;
                this._bc = 10;
                this._ca = 10;
            }
           
        }
        public override double FigureSquare()
        {
            double halfPer = (_ab + _bc + _ca) / 2;
            return Math.Sqrt(halfPer * (halfPer - _ab) * (halfPer - _bc) * (halfPer - _ca));
        }
    }
}
