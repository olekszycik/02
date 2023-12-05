using System;

namespace _02

{
    class VarArDetKallast
    {
        static string info = "Hej! Mata in temperaturen för två städer";
        static string st1 = "Stad 1";
        static string st2 = "Stad 2";
        static string st3 = "Stad 3";
        static string infoKallare = "Det är kallare i ";

        public static void TwoCities()
        {
            Console.WriteLine(info);
            Console.WriteLine("Först " + st1 + " :");
            int st1Temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Och nu " + st2 + " :");
            int st2Temp = Convert.ToInt32(Console.ReadLine());

            //Convert.ToInt32(st1Temp);
            //Convert.ToInt32(st2Temp);

            if (st1Temp > st2Temp)
            {
                System.Console.WriteLine($"I  {st1} är varmare än i {st2}.");
            }
            else if (st1Temp < st2Temp)
            {
                System.Console.WriteLine($"I {st1} är kallare än i {st2}.");
            }
            else if (st1Temp == st2Temp)
            {
                System.Console.WriteLine($"I {st1} och {st2} temperaturen är densamma.");
            }
            else
            {
                System.Console.WriteLine("Du har antagligen angett felaktig information!");
            }
        }
        
    }



}