namespace CalendarApplication;

class Program
{
    static void Main(string[] args)
    {

        Task task1 = new Task("Ödev", "17/03/2025", "Beşiktaş");
        Birthday birthday1 = new Birthday("Enes Can Aydemir", "17.05.2024", "Beşiktaş");

        task1.TaskInfo();
        task1.MarkAsComplete();

        Console.WriteLine();

        birthday1.BirthdayInfo();
        birthday1.BirthdayIsBirthday();

        
    }
}
