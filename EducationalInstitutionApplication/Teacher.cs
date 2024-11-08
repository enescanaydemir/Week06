using System;

namespace EducationalInstitutionApplication;

public class Teacher : Person
{
    public Teacher(string name, int age, string subjectTaught) : base(name, age)
    {
        SubjectTaught = subjectTaught;
    }

    public string SubjectTaught { get; set; }

    public override void AttendClass()
    {
        Console.WriteLine($"{Name}, {SubjectTaught} Dersine katıldı ve eğitmenlık yapıyor!");
    }
}
