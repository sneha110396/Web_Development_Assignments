using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Define List of Employees
    private List<Employee> employees = new List<Employee>();

    // Define AddEmployee Method
    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    // Define method to display all the employees in the list
    // Just for testing purposes
    public void DisplayEmployees()
    {
        foreach (var employee in employees)
        {
            Console.WriteLine($"Code: {employee.code}, Name: {employee.firstName} {employee.lastName}, Position: {employee.position}, Points: {employee.points}");
            Console.WriteLine(); // For spacing
        }
    }

    // Define method to update employee points
    public void UpdateEmployeePoints(string position_to_find, int code_to_find, int Points_to_add)
    {
        Employee employee = employees.Find(e => e.code == code_to_find && e.position.Equals(position_to_find, StringComparison.OrdinalIgnoreCase));

        if (employee != null)
        {
            // Update points for the found employee
            employee.points = employee.points + Points_to_add;
            Console.WriteLine($"Employee points updated successfully! New points: {employee.points}");
        }
        else
        {
            Console.WriteLine("Employee not found with the given code.");
        }
    }

    // Define method to get employee with highest points
    public void EmployeeWithHighestPoints()
    {
        Employee employee = employees.OrderByDescending(e => e.points).FirstOrDefault();
        string employeeName = employee.ToString();
        Console.WriteLine($"Employee with highest points is: {employeeName}, {employee.position}");
    }

    static void Main(string[] args)
    {
        Program program = new Program();
    }
}
