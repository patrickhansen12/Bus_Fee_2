using System;
using System.Runtime.ExceptionServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusTest
{
    [TestClass]
    public class UnitTest1
    {

        private int passengers;
        private int kilometers;
        private double price;
        private int fee = 130;

        [TestMethod]
        public void TestMethod1()
        {
            kilometers = 120;
            passengers = 10;
            price = 2.75;

            if (passengers < 12 && kilometers > 100)
            {
                price = fee + (kilometers * price);
                Assert.AreEqual(price, 460);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            kilometers = 90;

            price = 3.20;
            if (kilometers < 100)
            {
                price = fee + (kilometers * price);
                Assert.AreEqual(price, 418);
            }

        }

        [TestMethod]
        public void TestMethod3()
        {
            kilometers = 120;
            passengers = 10;
            price = 2.75;

            if (passengers < 12 && kilometers > 100)
            {
                price = fee + (kilometers * price);
                Assert.AreEqual(price, 460);
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            kilometers = 120;
            passengers = 10;
            price = 2.75;

            if (passengers < 12 && kilometers > 100)
            {
                price = fee + (kilometers * price);
                Assert.AreEqual(price, 460);
            }
        }
    }
}