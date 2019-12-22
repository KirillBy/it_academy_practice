using System;

namespace LettersA
{
    class Program
    {
        static void Main(string[] args)
        {
            string newWord;
            int counterSmalla = 0;
            int counterBiga = 0;
            newWord = Console.ReadLine();
            foreach(var i in newWord)
            {
                if(i == 'a')               
                    counterSmalla++;
                if (i == 'A')
                    counterBiga++;
            }

            Console.WriteLine("a = " + counterSmalla);
            Console.WriteLine("A = " + counterBiga);
        }
    }
}
