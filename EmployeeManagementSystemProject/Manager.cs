using System;

namespace EmployeeManagementSystemProject;

public class Manager : Employee
{
    public Manager(string name, int id, int salary, int numberOfTeams) : base(name, id, salary)
    {
        NumberOfTeams = numberOfTeams;
    }

    public int NumberOfTeams { get; set; }
}
