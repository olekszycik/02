using System;

namespace _02

{
    class Hello
    {
        public static void SayHello()
        {
            Console.WriteLine("Hej, what is your name?");
            string? yourName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Hej " + yourName);
            //Console.ReadKey();
            //Console.ResetColor();
            //Console.Clear();
        }
    }



}