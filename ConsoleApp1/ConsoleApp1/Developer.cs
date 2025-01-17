public class Developer : Employee
{
    // Constructor for Developer
    public Developer(int code, string firstName, string lastName, int points)
        : base(code, firstName, lastName, "Developer", points) 
    {
    }

    // Override AddPoints
    public override void AddPoints()
    {
        points = points + 5;
    }
}
