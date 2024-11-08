using System;

namespace EducationalInstitutionApplication;

public class Student : Person
{
    public Student(string name, int age, string gradeLevel) : base(name, age)
    {
        GradeLevel = gradeLevel;
    }

    public string GradeLevel { get; set; }

    public override void AttendClass()
    {
        Console.Write($"{Name}, {GradeLevel}. seviyedeki derse katıldı ve dersi dinliyor!");
    }
}
