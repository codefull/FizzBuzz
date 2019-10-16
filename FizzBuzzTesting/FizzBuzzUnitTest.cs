using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzLib;


namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzUnitTest
    {
        FizzBuzzBL fb = new FizzBuzzBL();

        [TestMethod]
        public void TestFizz()
        {
            Assert.IsTrue(fb.isFizz(3), "Failing Fizz Test");
        }

        [TestMethod]
        public void TestBuzz()
        {
            Assert.IsTrue(fb.isBuzz(5), "Failing Buzz Test");
        }

        [TestMethod]
        public void TestFizzBuzz()
        {
            int num = 15;
            Assert.IsTrue(fb.isFizz(num) && fb.isBuzz(num), "Failing FizzBuzz Test");
        }

        [TestMethod]
        public void TestNotFizzBuzzNumber()
        {
            Assert.IsTrue(fb.isNotFB(22), "Failing FizzBuzz Test, The Number is not Fizz or Buzz");
        }
    }
}
