using System;

namespace _02

{
    class SampleClass
    {
        public static void Info()
        {
            System.Console.WriteLine("Krona eller klave");
            System.Console.WriteLine("Hur många gånger vill du singla slant?");

            int howMuch = Convert.ToInt32(Console.ReadLine());
        }

    }



}