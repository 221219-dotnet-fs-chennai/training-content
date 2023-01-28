using NUnit.Framework;
using Logic;
using Moq;

namespace LogicTest
{
    // in this [] is known as to be annotation/attribute - TestFixture is an annotation/attribute which tells thatvthe class is used for testing using NUnit.
    // That's how you differentiate between regular classes (Compute) and test classes (ComputeTests)
    [TestFixture]
    public class ComputeTests
    {
        Compute compute;
        // this [Setup] annotation means this method will run before any other methods
        [SetUp]
        public void SetUp()
        {
            compute = new Compute();
            
        }


        // test mean that it is a unit test method
        [Test]
        [TestCase(70,30,100)]
        [TestCase(-10,5,-5)]
        [TestCase(5.6,4.4,10)]
        public void If_Sum_Adds_Two_Numbers(double a, double b, double expectedResult)
        {
            // Arrange Phase - Any thing which is required to perform test
            //int a = 70, b = 30;
            //int expectedResult = 100;
           
            // Act Phase - calling the functionality/method implementation to be tested
            double actualResult=compute.Sum(a,b);
            // Assert Phase - comparing if the results are as expected
            Assert.AreEqual(expectedResult,actualResult);
        }
        // this method will run after the test method and its test case has been executed
        [TearDown]
        public void CleanUp()
        {
            compute = null;
        }

        [Test]
        [TestCase(13)]
        //[Ignore("It is work in progress but not testable at the moment")] // Ignore means this unit test methid will skip from all tests execution
        public void Test_IsPrime(int x)
        {
            Mock<Compute> mock = new Mock<Compute>();
            mock.Setup(n=>n.IsPrime(x)).Returns(true);

            Assert.AreEqual(true, mock.Object.IsPrime(x));
            
        }

    }
}