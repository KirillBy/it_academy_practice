using System;

namespace Lecture._05
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan currentTime = System.DateTime.Now.TimeOfDay;
            if(currentTime.Hours > 9 && currentTime.Hours <=12)
            {
                Console.WriteLine("Good morning, guys");
            }
            else if (currentTime.Hours > 12 && currentTime.Hours <= 15)
            {
                Console.WriteLine("Good day, guys");
            }
            else if (currentTime.Hours > 15 && currentTime.Hours <= 22)
            {
                Console.WriteLine("Good evening, guys");
            }
            else { Console.WriteLine("Have a good sleep....zzzzzzz"); }
            Console.WriteLine(currentTime.Hours);
        }
    }
}
