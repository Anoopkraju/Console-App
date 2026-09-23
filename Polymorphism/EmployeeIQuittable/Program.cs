using System;

namespace EmployeeIQuittable
{
    // Provide the main class that starts the console app.
    public class Program
    {
        // Run this method when the application starts.
        public static void Main(string[] args)
        {
            // Create an Employee and supply values for its properties.
            Employee employee = new Employee
            {
                // Set the inherited first name.
                firstName = "Anoop",

                // Set the inherited last name.
                lastName = "Raju",

                // Set the employee identification number.
                Id = 1
            };

            // Call the Employee implementation of the Person method.
            employee.SayName();

            // Assign an Employee to an IQuittable variable to demonstrate polymorphism.
            IQuittable quittable = employee;

            // Call Employee.Quit through the IQuittable reference.
            quittable.Quit();

            // Wait for Enter so the result remains visible when launched from Visual Studio.
            Console.ReadLine();
        }
    }
}
