using TestingApi.Controllers;

namespace Unittesting
{
    public class UnitTest1
    {
        // [Fact] - 1 test case

        //multiple test cases
        [Theory]
        [InlineData(1,"Jeni")]   //pass
        [InlineData(2, "Kaveri")]  //fail
        [InlineData(3, "Kaveri")]  //fail
        [InlineData(1, "Mitra")]   //fail

        public void Test1(int id,string name)
        {

            //Arrange - set up the environment for testing

            SimpletestController sc = new SimpletestController();

            // Act - Create the test case
            string result = sc.check(id);

            //Assert - If the actual output = expected output

            Assert.Equal(result, name);



        }
    }
}