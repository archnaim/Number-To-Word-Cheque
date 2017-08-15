using System.Collections.Generic;
using NUnit.Framework;
using ConsoleApplication.Utils;

namespace Testing
{
    [TestFixture]
    public class ClassificationTest
    {
        private readonly Classification _cls = new ClassificationImpl();
        
        [Test]
        public void nestedDivisionTest()
        {
            Assert.AreEqual("Forty-Five", _cls.nestedDivision("45"));
            Assert.AreEqual("Eleven", _cls.nestedDivision("11"));
            Assert.AreEqual("Twelve", _cls.nestedDivision("12"));
            Assert.AreEqual("One Hundred And One", _cls.nestedDivision("101"));
            Assert.AreEqual("One Hundred And Eleven", _cls.nestedDivision("111"));
            Assert.AreEqual("One Million ", _cls.nestedDivision("1000000"));
            Assert.AreEqual("Two Billion Thirty Million Twenty-Four Thousand One Hundred And Twenty-Five", _cls.nestedDivision("2030024125"));
        }
        
        
        
    }
}