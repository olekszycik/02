using System;
using System.Runtime.ConstrainedExecution;
using static System.Formats.Asn1.AsnWriter;


namespace _02

{
    class KronaEllerKlave
    {
        public static string krona = "Krona";
        public static string klave = "Klave";
        
        

        public static void Rand()
        {
            Console.WriteLine("How many times will you flip:");
            int howManyFlip = Convert.ToInt32(Console.ReadLine());

            string[] arrayCoin = new string[howManyFlip];

            var rand = new Random();

            var coins = new List<string>();
            coins.Add(krona);
            coins.Add(klave);
            //coins.Add("Zośka i Małgośka");
            
            for (int i = 0; i < howManyFlip; i++)
            {
                arrayCoin[i] = coins[rand.Next(coins.Count)]; //arrayCoin.Length
            }

            int howManyA = 0;
            int howManyB = 0;

            foreach (var item in arrayCoin) // sprawdzam ilość występowania wyrazów w tablicy
            {
                if (item == coins[0])
                {
                    howManyA++;
                }
                else if (item == coins[1])
                {
                    howManyB++;
                }
            }

            int differenceValue = howManyA - howManyB;
            int absoluteValue;

            if (differenceValue >0)
            {
                absoluteValue = differenceValue;
            }
            else
            {
                absoluteValue = differenceValue * -1;
            }

            Console.WriteLine(coins[0] + " is flip: " + howManyA + " and " + coins[1] + " is flip: " + howManyB + "\nDifference is: " + absoluteValue);

        }
    }

}