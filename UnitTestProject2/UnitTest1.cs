using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        public int GetMaxValue(int[] numbers, int upperBound)
        {
            int maxValue = numbers.Max();

            if (maxValue < upperBound)
            {
                return maxValue;
            }
            else
            {
                return 0;
            }
        }
    }
}
