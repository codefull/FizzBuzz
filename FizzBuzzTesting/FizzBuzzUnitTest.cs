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
    }
}
