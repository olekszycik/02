using System;

namespace _02

{
    internal class ExercisesWithNumbers
    {
        public static void AddTwoInt()
        {
            Console.WriteLine("Giv me two integer.\nFirs one:");
            string? x1 = Console.ReadLine();
            
            System.Console.WriteLine("Second one:");
            string? x2 = Console.ReadLine();

            int lastResult = AddTwoInt(Convert.ToInt32(x1),Convert.ToInt32(x2));

            Console.WriteLine(lastResult);
        }

        public static int AddTwoInt(int x1, int x2)
        {
            int result = x1 + x2;
            return result;
        }
    }



}