using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods_Video
{
    [TestClass]

    public class MethodExamples
    {
        //Input
        //What we do
        //Output

        //1) Access Modifier
        //2) return type (what we are going to output)
        //3) Method signature (name and list of parameters)

        // Example 1: method takes in 2 integers, add them together, and returns the sum
        //1     //2   //3
        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        private int SubtractTwoNumbers(int a, int b)
        {
            int num = a - b;
            return num;
        }

        private int MultipleTwoNumbers(int x, int z)
        {
            int prod = x * z;
            return prod;
        }

        private int DivideTwoNumbers(int apricot, int cherry)
        {
            int fruitSalad = apricot / cherry;
            return fruitSalad;
        }

        private int FindRemainder(int a, int numTwo)
        {
            int remainder = a % numTwo;
            return remainder;
        }

        // Question 5 
        private int IntOutput(string numFromString)
        {
            int newNumber = Convert.ToInt32(numFromString);
            return newNumber;
        }

        // Question 6
        private void FullGreeting(string firstName)
        {
            Console.WriteLine($"Hello, {firstName}!");
        }

        // Question 7  
        private int MaxOutput(int numOne, int numTwo)
        {
            if (numOne > numTwo)
            {
                return numOne;
            }
            else
            {
                return numTwo;
            }

        }

        // Question 8
        private double Quotient(int numOne, int numTwo)
        {
            double quotientDouble = numOne / numTwo;
            return quotientDouble;
        }

        // Question 9 
        private int CalcAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int userAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return userAge;
        }


        //Question 10 
        private void FizzBuzz(int inputNumber)
        {
   
            for (int gold = 0; gold <= inputNumber; gold++)
            {
                if (gold % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                if (gold % 3 == 0)
                    Console.WriteLine("Fizz");

                else if (gold % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                {
                    Console.WriteLine(gold);
                }
            }
        }
        [TestMethod]
        public void MethodTests()
        {
            int banana = AddTwoNumbers(7, 12);
            Assert.AreEqual(19, banana);

            int subtractedBanana = SubtractTwoNumbers(10, 5);
            Assert.AreEqual(5, subtractedBanana);

            int product = MultipleTwoNumbers(12, 5);
            Assert.AreEqual(60, product);

            int fruitSalad = DivideTwoNumbers(10, 4);
            Assert.AreEqual(2, fruitSalad);

            int reminder = FindRemainder(10, 4);
            Assert.AreEqual(2, reminder);

            //output of Question 5 
            int convertedNumber = IntOutput("3");
            Assert.AreEqual(3, convertedNumber);

            //output of Question 6
            FullGreeting("AJ");
           
            // output of Question 7
            int maxNumber = MaxOutput(1, 5);

            // output of Question 8 
            double quotientDouble = Quotient(15, 5);
            Assert.AreEqual(3, quotientDouble);

            //output of Question 9;
            int userAge = CalcAge(new DateTime(1988, 03, 22));
            Console.WriteLine($"You are {userAge} years old.");

            //output of Question 10;
            FizzBuzz(50);

        }
    }
}
