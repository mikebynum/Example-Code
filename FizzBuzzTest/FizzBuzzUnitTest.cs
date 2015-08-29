using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzKata;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzUnitTest
    {
        [TestMethod]
        public void TestFizz()
        {
            
            FizzBuzz fb = new FizzBuzz();
            int num = 3;
            string value = fb.DetermineOutput(num);
            Assert.AreEqual("Fizz", value);

        }

        [TestMethod]
        public void TestBuzz()
        {
            FizzBuzz fb = new FizzBuzz();
            int num = 5;
            string value = fb.DetermineOutput(num);
            Assert.AreEqual("Buzz", value);
        }

        [TestMethod]
        public void TestFizzBuzz()
        {
            FizzBuzz fb = new FizzBuzz();
            int num = 15;
            string value = fb.DetermineOutput(num);
            Assert.AreEqual("FizzBuzz", value);
        }

        [TestMethod]
        public void TestNormal()
        {
            FizzBuzz fb = new FizzBuzz();
            int num = 7;
            string value = fb.DetermineOutput(num);
            Assert.AreEqual(num.ToString(), value);
        }

    }

}
