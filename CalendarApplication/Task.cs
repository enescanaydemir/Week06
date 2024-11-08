using System;

namespace CalendarApplication;

public class Task : Event
{
    public Task(string name, string date, string location) : base(name, date, location)
    {

    }

    bool markAsComplete = false;
    public void MarkAsComplete() 
    {
        if (markAsComplete)
        {
            Console.WriteLine("Task Tamamlandı Tebrikler!");
        }
        else
        {
            Console.WriteLine("Task Tamamlanamadı!!");
        }
    }

    public void TaskInfo()
    {
        Console.WriteLine($"Task ismi: {Name}\nTask Günü: {Date}\nTask Location: {Location}");
    }
}
