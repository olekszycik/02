using System;

namespace _02

{
    class NumbersNext
    {
        public static void Twenty()
        {
            Console.WriteLine("Program skriver ut alla tal mellan 1 och 20.");
            
            for (int i = 1; i < 21; i++)
            {
                Console.Write(i);

                if(i < 20)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }


        public static void FreeNumber()
        {
            Console.WriteLine("Program skriver ut alla tal mellan tal du väljer och 100.\nSkviv tal: ");

            int yourNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = yourNumber; i < 101; i++)
            {
                Console.Write(i);

                if (i < 100)
                {
                    System.Console.Write(", ");
                }              
            }
            System.Console.WriteLine();
        }
        

        
    }



}