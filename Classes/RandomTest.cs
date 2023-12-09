namespace _02

{
    public class RandomTest
    {
        private static string [] firstName = { "Donald", "Krzysztof", "Antoni"};
        private static string [] lastName = {"Bosak", "Tusk", "Macierewicz", "Kaczyński", "Czarnek"};


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

//-----------------------------------------------------------------------------
        public static void GenerateArray() //buduje nową tablicę "tablicaImion" poprzez losowanie wyrazów z innej tablicy.
        {
            var rand = new Random();
            
            string[] tablicaImion = new string[5];

            for (int i = 0; i < 5; i++)
            {
                tablicaImion [i] = lastName[rand.Next(lastName.Length)];
            }
            
            foreach (var item in tablicaImion)
            {
                System.Console.WriteLine(item);
            }
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


