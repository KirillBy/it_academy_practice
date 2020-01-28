using System;

namespace Lecture14
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "this is test string";
            testString = testString.LeaveFirstFive();
            Console.WriteLine(testString);
        }
    }
    public static  class StringExtension
    {
        public static string LeaveFirstFive(this string str)
        {
            str = str.Substring(0, 5);
            return str;
        }
        
    }
}
