using System;

namespace EducationalInstitutionApplication;

public class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }

    public virtual void AttendClass()
    {
        Console.Write($"{Name} derse katıldı!");
    }
}


/*

Bir Person (Kişi) sınıfı oluşturun. Bu sınıf aşağıdaki özelliklere sahip olmalıdır:

Name (isim): Kişinin adı
Age (yaş): Kişinin yaşı
Bu sınıftan Teacher (Öğretmen) ve Student (Öğrenci) sınıflarını türetin. Teacher sınıfına SubjectTaught (Öğrettiği Konu), Student sınıfına ise GradeLevel (Sınıf Seviyesi) özelliğini ekleyin. Her iki sınıfa da AttendClass (Derse Katıl) metodunu ekleyin, ancak bu metod her sınıfta farklı çalışsın.

*/