namespace EmployeeIQuittable
{
    // Define a shared base class for people with names.
    public abstract class Person
    {
        // Store the person's first name.
        public string firstName { get; set; } = "";

        // Store the person's last name.
        public string lastName { get; set; } = "";

        // Require each derived class to provide its own SayName method.
        public abstract void SayName();
    }
}
