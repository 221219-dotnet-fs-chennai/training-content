using BusinessLogic;
using NUnit.Framework;
using System;
using Data = DataFluentApi.Entities;


namespace Test
{
    [TestFixture]
    internal class TestMapper
    {
        [Test]
        public void TestMap()
        {
            Data.Restaurant restaurantData = new Data.Restaurant();

            var modelData = Mapper.Map(restaurantData);

            Assert.AreEqual(modelData.GetType(), typeof(Models.Restaurant));
        }
    }
}
