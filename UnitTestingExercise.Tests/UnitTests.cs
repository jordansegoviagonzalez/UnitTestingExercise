using System;
using Xunit;

//Added this dependency so it can be it access
namespace UnitTestingExercise.Tests

{
    public class UnitTests
    {
        // Up on inspection, I see we will be using the data attribute Theory 👀
        [Theory]
        [InlineData(2, 3, 5, 10)]   //Add test data <-------
        [InlineData(1, 2, 3, 6)]    // New data
        [InlineData(0, 0, 0, 0)]    // New data
        [InlineData(5, 5, 5, 15)]   // New data
        [InlineData(-1, -1, -1, -3)]// New data
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:✅

            //Arrange
            // create a Calculator object
            //The purpose of this object is to provide access to the methods and properties defined within the Calculator Class.
            
            var calculatorInstance = new Calculator();
            //'var' is a keyword that lets the compiler automatically the type of the variable 'calculatorInstance'.
            // calculatorInstance is the name of the object in camelCasing
            //'new' is used to create a new instance of the specified class(Calculator is this case).
            //it allocates memory for the new object and calls the constructor of the class to initialize it
            //'Calculator()' is the constructor of the Calculator class,
            // The constructors is a special method automatically called when a new object is created.

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
           //This line calls the Add method of the Calculator class and stores the result in the 'actual' variable.     
            var actual = calculatorInstance.Add(num1, num2, num3); 
            //var is keyword that tells the compiler to automatically determine the type of the variable 'actual' based on the result of the expression.
            //actual is the name of the variable that will be inferred as the result type of the Add method (int or double).
            //calculatorInstance' is an object of the Calculator class that was created earlier using 'new Calcularo()'
            //it allows you to access the method and properties define in the Calculator class.

            //Assert
                //Assert.Equal(expected, actual)
            Assert.Equal(expected, actual);   
            //Assert is a class that provides testing methods
            //Equal is method that compare two values and throws an error if they are not equal.
            //expected is the value we expect the method or code to return.
            //actual is the method that compares two values and throws an error if they are not equal.
            
        }

        [Theory]
        [InlineData(5, 5, 0)]        //Add test data <-------
        [InlineData(10, 5, 5)]       // New data
        [InlineData(100, 50, 50)]    // New data
        [InlineData(0, 0, 0)]        // New data
        [InlineData(-5, -5, 0)]      // New data0
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:✅

            //Arrange
            var calculatorInstance = new Calculator();

            //Act
            var actual = calculatorInstance.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 5, 25)]        //Add test data <-------
        [InlineData(10, 2, 20)]       // New data
        [InlineData(3, 3, 9)]         // New data
        [InlineData(0, 100, 0)]       // New data
        [InlineData(-5, -5, 25)]      // New data
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:✅

            //Arrange
            var calculatorInstance = new Calculator();

            //Act
            var actual = calculatorInstance.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 5, 1)]        //Add test data <-------
        [InlineData(10, 2, 5)]       // New data
        [InlineData(100, 25, 4)]     // New data
        [InlineData(0, 1, 0)]        // New data
        [InlineData(9, 3, 3)]        // New data
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculateInstance = new Calculator();

            //Act
            var actual = calculateInstance.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
