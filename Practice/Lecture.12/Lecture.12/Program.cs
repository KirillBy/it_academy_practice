using System;
using System.Collections.Generic;

namespace HW_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
             
            Shapes[] figures = new Shapes[6];
            figures[0] = new Square(random.Next(0, 10));
            figures[1] = new Square(random.Next(0, 10));
            figures[2] = new Circle(random.Next(0, 10));
            figures[3] = new Circle(random.Next(0, 10));
            int sideofTringle = random.Next(0, 10);
            figures[4] = new Triangle(sideofTringle, sideofTringle, sideofTringle);
            sideofTringle = random.Next(0, 10);
            figures[5] = new Triangle(sideofTringle, sideofTringle, sideofTringle);


            foreach (var item in figures)
            {
                Console.WriteLine($"This is {item.GetType().Name.ToString()}." +
                        $" It's CLR Type is {item.GetType().ToString()}. " +
                        $" It's square is {item.FigureSquare()}");
                Console.WriteLine("---------------------------------------------");
            }
        }

    }
}
