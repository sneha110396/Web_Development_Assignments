using System;

public abstract class Employee
{
    //Define properties
    public int code { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string position { get; set; }
    public int points { get; set; }

    //Define constructor
    public Employee(int Code, string FirstName, string LastName, string Position, int Points)
    {
        code = Code;
        firstName = FirstName;
        lastName = LastName;
        position = Position;
        points = Points;
    }

    //Override ToString Method
    public override string ToString()
    {
        string fullName = firstName + " " + lastName;
        return fullName;
    }

    //Define getEmployeePosition 
    public string getEmployeePosition()
    {
        return position;
    }

    //Define AddPoints
    public abstract void AddPoints();
}
