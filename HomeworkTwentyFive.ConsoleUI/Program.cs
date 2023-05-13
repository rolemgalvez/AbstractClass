using HomeworkTwentyFive.Library;
using System;

namespace HomeworkTwentyFive.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IProfession profession = new Manager();

            profession.Industry = "Information Technology";

            Console.ReadLine();
        }
    }
}
