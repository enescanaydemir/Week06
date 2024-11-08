namespace EducationalInstitutionApplication;

class Program
{
    static void Main(string[] args)
    {
        Teacher teacher = new Teacher("Enes Öğretmen", 25, "Yazılım");
        teacher.AttendClass();

        Student student = new Student("Enes", 16, "10");
        student.AttendClass();
    }
}


