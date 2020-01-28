using System;
using System.Collections.Generic;

namespace Project14_3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Neighbour> floorNeighbours = new List<Neighbour>();
            floorNeighbours.Add(new Neighbour("Ivanov", 12, "+375291001010"));
            floorNeighbours.Add(new Neighbour("Petrov", 11, "+375291002020"));
            floorNeighbours.Add(new Neighbour("Sidorov", 13, "+375291003030"));
            floorNeighbours.Add(new Neighbour("Trump", 15, "+375291000000"));
            floorNeighbours.Add(new Neighbour("Obama", 16, "+375291001000"));
            Console.WriteLine("Please a flat number");
            ushort userChoise = ushort.Parse(Console.ReadLine());
            foreach (var item in floorNeighbours)
            {
                if (item.FlatNumber == userChoise)
                    item.DisplayInfo();
            }
        }
    }
}
