using System;
using System.Security.Cryptography.X509Certificates;

namespace _02
{
    class KronaEllerKlave
    {
        public static string kr = "Krona";
        public static string kl = "Klave";

        public static void Jedziesz()
        {
            Console.WriteLine("Krona eller klave");
            Console.WriteLine("Skriv hur många gånger vill du singla slant? : ");
            int howMuch = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < howMuch; i++)
            {
                Losowanie();
            }
        }

        public static void Losowanie()
        {
            Random losowanie = new Random();

            string [] monety = {kr, kl};
            int randomINDEX = losowanie.Next(monety.Length);
            Console.Out.WriteLine("Wylosowano: " + monety[randomINDEX]);
            
            string [] noweMonety = {monety[randomINDEX]};
            System.Console.WriteLine(noweMonety);

            /* zobaczyć to:
                https://www.youtube.com/watch?v=MtOYVONXEk0
                czwarta minuta
            */

        }

    }
}