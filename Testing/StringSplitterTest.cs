using System;
using System.Collections.Generic;
using NUnit.Framework;
using ConsoleApplication.Utils;

namespace Testing
{
    [TestFixture]
    public class StringSplitterTest
    {
        private readonly StringSplitter splt = new StringSplitterImpl();
        public StringSplitterTest()
        {
            
        }

        [Test]
        public void splitByDotTest()
        {
            List<string> list1 = new List<string> {"101", "11"};
            Assert.That(list1,Is.EqualTo(splt.splitByDot("101.11")));
            
            List<string> list2 = new List<string> {"101"};
            Assert.That(list2,Is.EqualTo(splt.splitByDot("101")));
            
            List<string> list3 = new List<string> {"1", "10"};
            Assert.That(list3,Is.EqualTo(splt.splitByDot("1.10")));
        }
        
        
    }
}