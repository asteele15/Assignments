// Fig. 12.4: Employee.cs
// Employee abstract base class.
public abstract class Employee
{
    // auto-implemented read-only property FirstName
    public string FirstName { get; private set; }

    // auto-implemented read-only property LastName
    public string LastName { get; private set; }

    // auto-implemented read-only property SocialSecurityNumber
    public string SocialSecurityNumber { get; private set; }

    // three-parameter constructor
    public Employee(string first, string last, string ssn)
    {
        FirstName = first;
        LastName = last;
        SocialSecurityNumber = ssn;
    } // end three-parameter Employee constructor

    // return string representation of Employee object, using properties
    public override string ToString()
    {
        return string.Format("{0} {1}\nsocial security number: {2}",
           FirstName, LastName, SocialSecurityNumber);
    } // end method ToString

    // abstract method overridden by derived classes
    public abstract decimal Earnings(); // no implementation here
} // end abstract class Employee
