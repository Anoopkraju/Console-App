// Create an Employee, but store its reference in a variable of interface type.
IQuittable quittableEmployee = new Employee
{
    // Give the employee a first name.
    FirstName = "Jane",
    // Give the employee a last name.
    LastName = "Doe"
};

// Call the Employee implementation through the IQuittable interface (polymorphism).
quittableEmployee.Quit();

// Define the contract for any object that can quit.
public interface IQuittable
{
    // Require implementing classes to provide a Quit method with no return value.
    void Quit();
}

// Represent an employee and promise to implement the IQuittable contract.
public class Employee : IQuittable
{
    // Store the employee's first name; callers can read or change it.
    public string FirstName { get; set; } = string.Empty;

    // Store the employee's last name; callers can read or change it.
    public string LastName { get; set; } = string.Empty;

    // Fulfill the interface contract by displaying a message when the employee quits.
    public void Quit()
    {
        // Print the full employee name in the quit message.
        Console.WriteLine($"{FirstName} {LastName} has quit.");
    }
}

