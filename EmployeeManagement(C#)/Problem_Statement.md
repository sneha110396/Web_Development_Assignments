Objective: 

To understand and implement basic OOP concepts such as inheritance, abstraction, and method overriding in C#. Additionally, to practice handling user inputs and updating object states. 

Problem Statement: 

You are required to complete an Employee Management System. This system keeps track of different types of employees: Managers, Developers, and Interns. Each employee has a unique code, name, and position. They can earn points based on their type, which you need to implement. 

Instructions: 

Define the Classes: 

The Employee class is an abstract class with common properties and methods for all employees. 

The Manager, Developer, and Intern classes inherit from the Employee class. 

Class Properties and Methods: 

The Employee class has the following properties: code, firstName, lastName, position, and points. 

Implement a constructor in the Employee class to initialize these properties. 

Override the ToString method to return the full name of the employee. 

Implement a method getEmployeePosition to display the position of the employee. 

Implement an abstract method AddPoints in the Employee class to be overridden in derived classes. 

Derived Classes: 

The Manager class should have a method AddPoints that adds 10 points to the manager's points. 

The Developer class should have a method AddPoints that adds 5 points to the developer's points. 

The Intern class should have a method AddPoints that adds 2 points to the intern's points. 

Program Class: 

In the Program class, create a list to store employees. 

Implement a method to take input for each type of employee and store it in the list. 

Implement a method to take input for an employee type, code, and points to add, and update the points for that employee. 

Implement a method to find and display the employee with the highest points. 
