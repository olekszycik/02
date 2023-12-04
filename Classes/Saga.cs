using System;

namespace _02

{
    internal class Saga
    {
        string[] yes = {"ja", "Ja", "JA", "jA", "j", "J"};
        string[] no = {"nej", "Nej", "n", "N", "NEJ"};
        //string[] yesno = yes.Union(no).ToArray(); //łączenie dwóch tablic

/*
        foreach(string abc in yes) 
        {
            Console.WriteLine(abc);
        }
*/


        Console.WriteLine("Är det fint väder?\ntillåtna ord är:");
        Console.WriteLine("ja, Ja, JA, jA, j, J");
        Console.WriteLine("eller:");
        Console.WriteLine("nej, Nej, n, N, NEJ");
                

        string? svar = Console.ReadLine();
        


        foreach(string jaja in yes)
        {
            if (jaja.Equals(svar))
            {
                Console.WriteLine("Vi går på picknick!");
                //break;
            }
        }


        foreach(string nejnej in no)
        {
            if (nejnej.Equals(svar))
            {
                Console.WriteLine("Vi stannar inne och läser en bok");
            }
        }

        //
        // Jeśli nie zawiera słów z połączonych tablic, to ma zadziałać, inaczej pominąć.
        //
        foreach(string inget in yesno)
        {
            if (!inget.Equals(svar))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Jag förstår inte");
                Console.ResetColor();
                break;
            }
        }
    }



}

