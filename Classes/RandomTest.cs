using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace _02

{
    public class RandomTest
    {
        private static string [] firstName = { "Donald", "Krzysztof", "Antoni"};
        private static string [] lastName = {"Bosak", "Tusk", "Macierewicz", "Kaczyński", "Czarnek"};
        private static string [] coins = {"A", "B"};


//-----------------------------------------------------------------------------
        public static string GenerateName() // łączy dwa wyrazy z dwóch tablic, np: imię i nazwisko.
        {
            var rand = new Random();
            string randomFirstName = firstName[rand.Next(firstName.Length)];
            string randomLastName = lastName[rand.Next(lastName.Length)];
            return $"{randomFirstName} {randomLastName}";
        }

        public static void ShowResult()
        {
            var randomWords = GenerateName();
            Console.WriteLine(randomWords);
        }

//  Throws of coins ======================================================
//  ==============================================================================

        public static void Coin()
        {
            int numberOfThrows = 0; //ilość rzutów, czyli ilość wyrazów w tablicy

            Console.WriteLine("How many times do you want to flip a coin?");
            numberOfThrows = Convert.ToInt32(Console.ReadLine());

            var rand = new Random();

            string[] newCoinArray = new string[numberOfThrows]; // Utworzenie tablicy o nazwie "newCoinArray", która posiada "numberOfHthrows" wyrazów
            

            for (int i = 0; i < numberOfThrows; i++)
            {
                newCoinArray[i] = coins[rand.Next(coins.Length)]; // wypełniam tablicę wyrazami w ilości "numberOfThrows", które są losowane
            }
            


            int howManyA = 0;
            int howManyB = 0;

            foreach (var item in newCoinArray) // sprawdzam ilość występowania wyrazów w tablicy
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

            Console.WriteLine(coins[0] + " is flip: " + howManyA + " and " + coins[1] + "is flip: " + howManyB);

        }
        
//  ==============================================================================





        public static void GenerateArray() //buduje nową tablicę "tablicaImion" poprzez losowanie wyrazów z innej tablicy.
        {
            int howManyTimes = 0;

            Console.WriteLine("How many times do you want to say Lastname?");
            howManyTimes = Convert.ToInt32(Console.ReadLine());

            var rand = new Random();
        
            string[] tablicaImion = new string[howManyTimes];

            for (int i = 0; i < howManyTimes; i++)
            {
                tablicaImion [i] = lastName[rand.Next(lastName.Length)];
            }
            
            foreach (var item in tablicaImion)
            {
                System.Console.WriteLine(item);
            }

            int ileWTablicy = tablicaImion.Length;
            System.Console.WriteLine("ilość wyrazów w tablicy: " + ileWTablicy);
        }
//-----------------------------------------------------------------------------       

        public static void RandomNames()
        {
            //GenerateName();
            //ShowResult(); //pokazuje wynik GenerateName
            GenerateArray();

        }


    }
    
}


