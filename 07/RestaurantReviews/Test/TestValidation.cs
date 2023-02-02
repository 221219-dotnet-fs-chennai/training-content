using BusinessLogic;
using NUnit.Framework;
using System;

namespace Test
{
    [TestFixture]
    public class TestValidation
    {
        string time = "07:00:00";
        static TimeSpan t1 = new TimeSpan(7,0,0);
        static TimeSpan t2 = DateTime.Now.TimeOfDay;
        [SetUp]
        public void Setup()
        {
             
        }

        [Test]
        [TestCase(null,null)]
        
        public void Test_HandleTimeSpanNulls(TimeSpan? actual, TimeSpan expected)
        {
            Assert.AreEqual(expected, Validation.HandleTimeSpanNulls(actual));
        }

        [Test]
        [TestCase("07:00:00")]
        [TestCase("7:0:0")]
        public void Test_StringToTime(string actualTime)
        {
            var actual = Validation.StringToTime(actualTime);
            Assert.AreEqual(actual,t1);
            Assert.AreNotEqual(actual,t2);
        }
    }
}