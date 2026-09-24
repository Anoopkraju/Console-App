// Creates the first employee and assigns its Id and name.
Employee firstEmployee = new Employee
{
    Id = 101,
    FirstName = "Anoop",
    LastName = "Raju"
};

// Creates a second employee with the same Id and a different name.
Employee secondEmployee = new Employee
{
    Id = 101,
    FirstName = "Alex",
    LastName = "Smith"
};

// Invokes the overloaded == operator and displays its result.
Console.WriteLine($"Same employee (==): {firstEmployee == secondEmployee}");

// Invokes the paired != operator and displays its result.
Console.WriteLine($"Different employees (!=): {firstEmployee != secondEmployee}");

// Changes the second Id so the next comparison demonstrates a different employee.
secondEmployee.Id = 202;

// Displays the results again after the Id change.
Console.WriteLine($"After changing Id, same employee (==): {firstEmployee == secondEmployee}");
Console.WriteLine($"After changing Id, different employees (!=): {firstEmployee != secondEmployee}");
