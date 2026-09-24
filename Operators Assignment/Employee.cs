// Defines an employee whose equality is based on its Id.
public class Employee : IEquatable<Employee>
{
    // Stores the employee's unique identifier.
    public int Id { get; set; }

    // Stores the employee's first name.
    public string FirstName { get; set; } = string.Empty;

    // Stores the employee's last name.
    public string LastName { get; set; } = string.Empty;

    // Compares two employees by Id, including cases where either is null.
    public static bool operator ==(Employee? left, Employee? right)
    {
        // Two null references represent the same value.
        if (ReferenceEquals(left, right)) return true;

        // One null reference cannot equal a non-null employee.
        if (left is null || right is null) return false;

        // Employees with the same Id are equal regardless of their names.
        return left.Id == right.Id;
    }

    // Provides the paired inequality operator as the opposite of equality.
    public static bool operator !=(Employee? left, Employee? right) => !(left == right);

    // Makes object equality follow the same Id comparison as ==.
    public override bool Equals(object? obj) => obj is Employee other && this == other;

    // Provides typed equality using the same Id comparison.
    public bool Equals(Employee? other) => this == other;

    // Ensures equal employees have equal hash codes when used in collections.
    public override int GetHashCode() => Id.GetHashCode();
}
