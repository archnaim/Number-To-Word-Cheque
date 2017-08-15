using System.Collections.Generic;
using NUnit.Framework;
using ConsoleApplication.Utils;

namespace Testing
{
    [TestFixture]
    public class ConversionToStringTest
    {
        private readonly ConversionToString _conversionToString;
        List<string> _list = new List<string>();
        public ConversionToStringTest()
        {
            _conversionToString = new ConversionToStringImpl();
            _list.Add("One");
            _list.Add("Two");
            _list.Add("Three");
            _list.Add("Four");
            _list.Add("Five");
            _list.Add("Six");
            _list.Add("Seven");
            _list.Add("Eight");
            _list.Add("Nine");
            _list.Add("Ten");
            _list.Add("Eleven");
            _list.Add("Twelve");
            _list.Add("Thirteen");
            _list.Add("Fourteen");
            _list.Add("Fiveteen");
            _list.Add("Sixteen");
            _list.Add("Seventeen");
            _list.Add("Eighteen");
            _list.Add("Nineteen");
        }
        
        [Test]
        public void charTo1DigitTest()
        {
            for (int i = 1; i < 10; i++)
            {
                string actual = _conversionToString.charToString1Digit(i);
                Assert.AreEqual(_list[i-1],actual);
            }
        }
        
        [Test]
        public void charTo2DigitTest()
        {
            for (int i = 10; i < 20; i++)
            {
                string actual = _conversionToString.charToString2Digit(i.ToString());
                Assert.AreEqual(_list[i-1],actual);
            }
            Assert.AreEqual("Forty-Five",_conversionToString.charToString2Digit("45"));
        }
    }
}