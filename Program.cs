using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for input
            Console.WriteLine("Enter a number(x): ");
            String xStr = Console.ReadLine();
            int x = Convert.ToInt32(xStr);
            Console.WriteLine("Enter a second number(y):");
            String yStr = Console.ReadLine();
            int y = Convert.ToInt32(yStr);
            //Create a DelegateInt instance to pass the AddFunction
            DelegateInt del = AddFunction;
            //Call the method that passes a delegate, referencing the addfunction method
            AddCallerMethod(x, y, del);

            //Ask for more input
            Console.WriteLine("\n\nNow give me a sentence.");
            string sentenceOne = Console.ReadLine();
            Console.WriteLine("And a second sentence.");
            string sentenceTwo = Console.ReadLine();
            //Create DelegateString instance
            DelegateString del2 = ConcatenateFunction;
            ConcatenateCallerMethod(sentenceOne, sentenceTwo, del2);

            Console.ReadLine();
        }
        //Define the delegate with the same parameters as what it is referencing
        public delegate int DelegateInt(int a, int b);
        public delegate string DelegateString(string a, string b);

        //The method that the delegate will reference
        public static int AddFunction(int x, int y)
        {
            return x + y;
        }

        public static string ConcatenateFunction(string x, string y)
        {
            return x + y;
        }

        //Create a caller method for the add function
        public static void AddCallerMethod(int a, int b, DelegateInt delInt)
        {
            Console.WriteLine("\n\nThe sum of the numbers is equal to " + delInt(a, b) + ".\n\n");
        }
        //Create a caller method for the concatenate function
        public static void ConcatenateCallerMethod(string a, string b, DelegateString delString)
        {
            Console.WriteLine("\n\nCombined that says: " + delString(a, b) + ".\n\n");
        }

    }
}
