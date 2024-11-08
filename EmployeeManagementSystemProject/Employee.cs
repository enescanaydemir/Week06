using System;

namespace EmployeeManagementSystemProject;

public class Employee
{
    public Employee(string name, int id, int salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    public string Name { get; set; }
    public int Id { get; set; }
    public int Salary { get; set; }


    
}
