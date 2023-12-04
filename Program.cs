using System;
using System.Security.Cryptography;

namespace _02 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hello.SayHello(); // prosi o imię i wita tym imieniem
            //Math.GivMeTwoInteger(); // prosi o dwa int-y i wyświetla wynik dodawania
            
            //ExercisesWithNumbers.GivTwoIntAndAdd(); // prosi o dwa int-y i wyświetla wynik dodawania
            //ExercisesWithNumbers.GivThreeIntAddAndAverage(); // prosi o trzy int-y, wyświetla ich sumę oraz podaje średnią i  zaokrągla do najbliższej
            ExercisesWithNumbers.ToFloat();

            


//*******************************************************************
            Console.ResetColor();
            System.Console.WriteLine("Pres any key...");
            Console.ReadKey();
            Console.Clear();

        }
    }
}