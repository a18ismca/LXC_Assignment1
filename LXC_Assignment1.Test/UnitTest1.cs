namespace LXC_Assignment1.Test
{
    public class UnitTest1
    {
        [Fact]
        public void AdditionTest()
        {   
            // Arrange
            double expectedResult = 13;

            // Act
            double actualResult = Program.Addition(12.22, 0.78);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        // Sometimes several zeros are required at the decimals of the compared values, for example in the test below.
        [Fact]
        public void SubtractionTest()
        {
            // Arrange
            double expectedResult = -0.10000000000;

            // Act
            double actualResult = Program.Subtraction(1, 1.10000000000);

            // Assert
            Assert.NotEqual(expectedResult, actualResult);
        }

        [Fact]
        public void MultiTest()
        {
            // Arrange 
            double expectedResult = 0;

            // Act
            double actualResult = Program.Multiplication(0, 123.456);

            //Assert

            Assert.Equal(expectedResult, actualResult);

        }


        // Failed. The expected result should be infinity when dividing with 0.
        [Fact]
        public void DivTest()
        {
            // Arrange 
            double expectedResult = 8;

            // Act
            double actualResult = Program.Division(123.456, 0);

            //Assert
            Assert.Equal(expectedResult, actualResult);

        }


       [Fact]
        public void ArrayAdditionTest()
        {
            List<int> arr = new List<int>();
            arr.Add(20);
            arr.Add(30);
            arr.Add(-5);
            arr.Add(-100);
            arr.Add(0);
            arr.Add(6);


            // Arrange 
            int expectedResult = -49;

            // Act
            int actualResult = Program.Addition(arr);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ArraySubtractionTest()
        {
            List<int> arr = new List<int>();

            arr.Add(20);
            arr.Add(30);
            arr.Add(-5);
            arr.Add(-100);
            arr.Add(0);
            arr.Add(6);

            // Arrange 
            int expectedResult = 89;

            // Act
            int actualResult = Program.Subtraction(arr);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

    }
}