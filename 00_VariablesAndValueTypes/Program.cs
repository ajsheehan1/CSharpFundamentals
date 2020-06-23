using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_VariablesAndValueTypes
{
    enum PastryType{Cake, Cupcake, Croissant, Donut, Cookie, Scone, Danish }
    class Program
    {
        static void Main(string[] args)
        {
            // This is how you take notes

            // Bools
            bool isDeclared;
            isDeclared = true;

            bool isDeclaredAndInitialized = false;
            isDeclaredAndInitialized = true;

            // Characters - can only initialize single digits
            char character = 'a';
            char symbol = '&';
            char number = '3';
            char space = ' ';
            char specialCharacters = '\n';

            // Wole numbers
            // All numbers listed below have a certain number of digits
            // No quotes because you are assigning a numerical value 
            byte byteExample = 255;
            // byte max is 255 ^^ 
            sbyte sByteExample = -128;
            // represents an 8-bit signed integer

            // short and Int16 are the same
            short shortExample = 32767;
            Int16 anotherShortExample = 32767;

            //Int is most commonly used
            int intMin = -2147483648; // smallest an Int can be
            Int32 intMax = 2147483647; // highest an Int can be

            // long is longer than int - same as INT64
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;

            int a = 7;
            int b = -7000;

            byte age = 104;


            // Decimals - 
            // Float - MUST have the f at the end, 
            // double- doesn't necessarily need the d
            float floatExample = 1.045231f;
            double doubleExample = 1.789053278907036d;
            decimal decimalExample = 1.2578907289045789789789789787897m;
            Console.WriteLine(1.2578907289045789789789789787897f); // prints 1.257891
            Console.WriteLine(1.2578907289045789789789789787897d); // prints 1.25789072890458
            Console.WriteLine(1.2578907289045789789789789787897m); // prints 1.2578907289045789789789789788


            Console.ReadKey();

            // Enums
            PastryType myPastry = PastryType.Croissant;
            PastryType anotherOne = PastryType.Donut;

            //Structs 
            Int32 num = 42;
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(1805,11,24);
            DateTime test = new DateTime();

        }
    }
}
