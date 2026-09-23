using System;

namespace EmployeeIQuittable
{
    // Inherit Person and implement the IQuittable interface.
    public class Employee : Person, IQuittable
    {
        // Store an identification number for this employee.
        public int Id { get; set; }

        // Fulfill the abstract SayName requirement from Person.
        public override void SayName()
        {
            // Write the employee's full name to the console.
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        // Fulfill the Quit requirement from IQuittable.
        public void Quit()
        {
            // Write a message when the employee quits.
            Console.WriteLine(firstName + " " + lastName + " has quit.");
        }
    }
}
