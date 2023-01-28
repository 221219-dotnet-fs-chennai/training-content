using BusinessLogic;
using NUnit.Framework;
using System;

namespace Test
{
    [TestFixture]
    public class TestValidation
    {
        string time = "07:00:00";
        static TimeSpan t1 = DateTime.Now.TimeOfDay;
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
        public void Test_StringToTime()
        {
            var actual = Validation.StringToTime(time);
            var expectedTime = new TimeSpan(7, 0, 0);
            Assert.AreEqual(actual,expectedTime);
        }
    }
}