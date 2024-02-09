using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(2, 10, 5, 17)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calculator = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                int actual = calculator.Add(num1, num2, num3);
            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20,5,15)]//Add test data <-------
        [InlineData(30,10,20)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator calculator1 = new Calculator();
            //Act
            int actual = calculator1.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected , actual);
        }

        [Theory]
        [InlineData(2,5,10)]//Add test data <-------
        [InlineData(20,3,60)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:
            
            //Arrange
            Calculator calculator2 = new Calculator();
            //Act
            int actual = calculator2.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected , actual);
        }

        [Theory]
        [InlineData(20,5,4)]//Add test data <-------
        [InlineData(30,3,10)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calculator3 = new Calculator();
            //Act
            int actual = calculator3.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
