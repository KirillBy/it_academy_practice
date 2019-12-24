using System;

namespace Lecture._07
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();           
        }
        static void Task1()
        {
            Console.WriteLine("//невозможно создать пустой массив, тк он автоматически заполняется дефолтными значениями напр. int - 0, bool - false");
        }

        static void Task2()
        {
            object[] arrayTask2 = new object[3];
            arrayTask2[0] = 32;
            arrayTask2[1] = 'A';
            arrayTask2[2] = "Hello";
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arrayTask2[i]);
            }
        }
        static void Task3()
        {
            var rand = new Random();
            int[] arrayTask3 = new int[13];
            for (int i = 0; i < 13; i++)
            {
                arrayTask3[i] = rand.Next();
                Console.WriteLine(arrayTask3[i]);
            }

            int max = arrayTask3[0];
            for (int i = 0; i < 13; i++)
            {
                if (arrayTask3[i] > max)
                    max = arrayTask3[i];
            }
            Console.WriteLine("Maximum number is " + max);
        }
        static void Task4()
        {
            short unboxShort = 10;
            object boxedShort = unboxShort;
            System.SByte unboxSByte = Convert.ToSByte(boxedShort);
            Console.WriteLine(unboxSByte);
        }
    }
}
