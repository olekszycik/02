using System.Collections;
using System.Globalization;

namespace _02

{
    class Math
    {
        public static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public static void GivMeTwoInteger()
        {
            string? a;
            string? b;
            //Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Giv me two integer. \nNow first: ");


            a = Console.ReadLine();

            if(int.TryParse(a, out int integerA))
            {
                Console.WriteLine("Second number please...");
                b = Console.ReadLine();

                if(int.TryParse(b, out int integerB))
                {
                    int suma = Math.Add(Convert.ToInt32(a), Convert.ToInt32(b));

                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Result is: " + suma);
                }
            }
            else
            {
                do
                {
                //Convert.ToInt32(a);
                Console.WriteLine("You must giv NUMBER - no space, no letter");
                System.Console.WriteLine("wprowadź pierwszą cyfrę:");
                a = Console.ReadLine();
                }
                //while (string.IsNullOrEmpty(a) || string.IsNullOrWhiteSpace(a));
                while (string.IsNullOrEmpty(a) || string.IsNullOrWhiteSpace(a) || int.TryParse(a, out int integerC));
                //while(int.TryParse(a, out int integerC));
            }





/*
            
            do
            {
                //Convert.ToInt32(a);
                Console.WriteLine("You must giv NUMBER - no space, no letter");             
            }

            while (string.IsNullOrEmpty(a) || string.IsNullOrWhiteSpace(a));

            
            
            

            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Second number please...");
            string? b = Console.ReadLine();

            int suma = Math.Add(Convert.ToInt32(a), Convert.ToInt32(b));

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Result is: " + suma);
*/
            
            //Console.WriteLine("Close program");
        }

/*        public static IsOK()
        {
            while (string.IsNullOrEmpty(a) || string.IsNullOrWhiteSpace(a))
            {
                string msg = System.Console.WriteLine("You must giv NUMBER - no space, no letter");
                return msg;
            }
        }
*/
    }



}