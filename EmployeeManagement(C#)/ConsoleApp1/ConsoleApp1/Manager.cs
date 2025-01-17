public class Manager : Employee
{
    // Constructor for Manager
    public Manager(int code, string firstName, string lastName, int points)
        : base(code, firstName, lastName, "Manager", points) 
    {
    }

    // Override AddPoints
    public override void AddPoints()
    {
        points = points + 10;
    }
}
