using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.XPath;

namespace _02

{
    internal class ExercisesWithNumbers
    {
        public static void GivTwoIntAndAdd()
        {
            Console.WriteLine("Addition two numbers.\nGiv me two integer.\nFirs one:");
            string? x1 = Console.ReadLine();
            
            Console.WriteLine("Second one:");
            string? x2 = Console.ReadLine();

            int lastResult = AddTwoInt(Convert.ToInt32(x1),Convert.ToInt32(x2));

            Console.WriteLine("Addition result: " + lastResult);
        }

        public static int AddTwoInt(int x1, int x2)
        {
            int result = x1 + x2;
            return result;
        }

//--------------------------------------------------------------------------------------------------
        public static void GivThreeIntAddAndAverage()
        {
            Console.WriteLine("Giv me three numbers. \nI add these and giv You their average\nFirst:");
            string? y1 = Console.ReadLine();

            Console.WriteLine("Second int:");
            string? y2 = Console.ReadLine();

            Console.WriteLine("And now last one:");
            string? y3 = Console.ReadLine();

            int addThreeNumbers = AddThreeInt(Convert.ToInt32(y1),Convert.ToInt32(y2), Convert.ToInt32(y3));
            Console.WriteLine("Result of add three int is: " + addThreeNumbers);

            double showAvarageOfThreeNumbers = AvarageOfThreeNumbers(addThreeNumbers);
            Console.WriteLine("Avarage of those three numbers is: " + showAvarageOfThreeNumbers);

            int showConvertDoubleToInt = RoundDoubleToInt(showAvarageOfThreeNumbers);
            Console.WriteLine("round of " + showAvarageOfThreeNumbers + " is: " + showConvertDoubleToInt);
        }
        
        public static int AddThreeInt(int y1,int y2,int y3)
        {
            int addResult = y1 + y2 + y3;
            return addResult;
        }

        public static double AvarageOfThreeNumbers(double addResult)
        {
            double avgResult = addResult / 3;
            return avgResult;
        }

        public static int RoundDoubleToInt(double xyz)
        {
            int result = Convert.ToInt32(xyz);
            return result;

        }


//--------------------------------------------------------------------------------------------------

        public static void ToFloat()
        {
            int a = 1;
            int b = 2;
            
            //przekonwertować to na int32 czy na single?
            float c = Convert.ToInt32(a)/Convert.ToSingle(b);
            //float c = a/b; //daje niepoprawny wynik -> 1/2=0
            Console.WriteLine(c);

            float x = a;
            float y = b;
            float c2 = x/y;
            Console.WriteLine(c2);
        }
    }



}