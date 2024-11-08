using System;

namespace EmployeeManagementSystemProject;

public class Developer : Employee
{
    public Developer(string name, int id, int salary, string programmingLaungage, string computerBrand) : base(name, id, salary)
    {
        ProgrammingLaungage = programmingLaungage;
        ComputerBrand = computerBrand;
    }

    public string ProgrammingLaungage { get; set; }
    public string ComputerBrand { get; set; }

    
    public void DeveloperInfo()
    {
        Console.WriteLine($"İsim: {Name}\nYazılımcının Kimlik Numarası: {Id}\nYazılımcının Maaşı: {Salary}\nYazılımcının Kullandığı Dil: {ProgrammingLaungage}\nYazılıncının Kullandığı Bilgisayar Markası: {ComputerBrand}");
    }
}
