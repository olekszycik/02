using System;
using System.Security.Cryptography.X509Certificates;

namespace _02

{
    class Saga
    {
        public static void SagaAboutTwoPeople()
        {            
            string? man = null; 
            string? woman;
            string? dog = "KoKo";
            string? cat = "Fifi";

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Saga om två personer");
            Console.ResetColor();

            Console.WriteLine("Föreslå ett mansnamn och skriv: ");
            man = Console.ReadLine();
            Console.WriteLine("Föreslå ett kvinnonamn och skriv: ");
            woman = Console.ReadLine();

            StringOne(man, woman);
            StringTwo(dog, cat, woman);
            StringThree(man, dog);
        }

        public static void StringOne(string man, string woman)
        {
            Console.WriteLine(string.Format("{0} gifte sig med {1}, men {0} visste inte att {1} gillar röka cigaretter.", man, woman));
        }
       
        public static void StringTwo(string dog, string cat, string woman)
        {
            Console.WriteLine("Hans hund {0} var agresiv mot hennes catten {1} och problemet löste sig självt.\n{2} bestämde sig för att flytta ut med {1}.", dog, cat, woman);
        }

        public static void StringThree(string man, string dog)
        {
            Console.WriteLine("Nu behöver {0} och {1} inte vara nervösa för någonting.", man, dog);
        }


        
    }
        
}