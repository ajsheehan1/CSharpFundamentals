using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Question6
    {
        public void QuestionExample()
        {
            Greeting("AJ");
        }

        public void Greeting(string myName) 
        { 
            Console.WriteLine($"Greetings, {myName}!");
        }
    }
}
