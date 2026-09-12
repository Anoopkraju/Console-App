

// Creates a class named MathOperations.
class MathOperations
{
    // Creates a void method that accepts two integer parameters.
    public void PerformOperation(int firstNumber, int secondNumber)
    {
        // Multiplies the first integer by 2 and stores the answer.
        int result = firstNumber * 2;

        // Displays the result of the math operation.
        Console.WriteLine("Result of the first number multiplied by 2: " + result);

        // Displays the second integer on the screen.
        Console.WriteLine("The second number is: " + secondNumber);
    }
}

// Creates the Program class.
class Program
{
    // Main() is where the program begins.
    static void Main(string[] args)
    {
        // Creates an object of the MathOperations class.
        MathOperations mathObject = new MathOperations();

        // Calls the method by passing two numbers.
        mathObject.PerformOperation(10, 20);

        // Calls the method again using named parameters.
        mathObject.PerformOperation(firstNumber: 15, secondNumber: 30);

        // Keeps the console open until the user presses a key.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}