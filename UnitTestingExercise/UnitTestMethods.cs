using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
        // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers

        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend

        // Create a Multiply method that passes 2 integers

        // Create a Divide method that passes 2 integers



        // Create 2 methods that will utilize the [Fact] tests you wrote

        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        
        public int Subtract(int minuend, int subtrhend)
        {
            return minuend - subtrhend;
        }

        
        public int Multiply(int num1, int num2)
        {
            return (num1 * num2);   
        }

        
        public int Divide(int num1, int num2)
        {
            return (num1 / num2); 
        }

        
        public string DoStuff()
        {
            Console.WriteLine("Doing Stuff"); //Do i need both??
            return "Doing Stuff";
        }

        
        public string Greetings()
        {
            Console.WriteLine("Hello there friend!");
            return "Hello there friend!";
        }


    }
}
