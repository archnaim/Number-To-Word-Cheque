using System;
using ConsoleApplication.Utils;
using NUnit.Framework;

namespace Testing
{
    [TestFixture]
    public class IntegrationTests
    {
        private readonly WordsIntoMoney _money = new WordsIntoMoneyImpl();
        
        [Test]
        public void Test1()
        {
            Assert.AreEqual("Forty-Five Dollars", _money.inDollar("45"));
            Assert.AreEqual("Eleven Dollars", _money.inDollar("11"));
            Assert.AreEqual("Twelve Dollars And Thirteen Cents", _money.inDollar("12.13"));
            Assert.AreEqual("One Hundred And One Dollars And Twenty-Three Cents", _money.inDollar("101.23"));
            Assert.AreEqual("One Hundred And Eleven Dollars And One Cents", _money.inDollar("111.01"));
            Assert.AreEqual("One Million  Dollars", _money.inDollar("1000000"));
            Assert.AreEqual("Two Billion Thirty Million Twenty-Four Thousand One Hundred And Twenty-Five Dollars And Ninety-One Cents", _money.inDollar("2030024125.91"));
            
        }
    }
}