public class Intern : Employee
{
    // Constructor for Intern
    public Intern(int code, string firstName, string lastName, int points)
        : base(code, firstName, lastName, "Intern", points) 
    {
    }

    // Override AddPoints
    public override void AddPoints()
    {
        points = points + 2;
    }
}
