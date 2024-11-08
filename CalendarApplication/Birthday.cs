using System;

namespace CalendarApplication;

public class Birthday : Event
{
    public Birthday(string name, string date, string location) : base(name, date, location)
    {
    }


    public void BirthdayIsBirthday()
    {
        Console.WriteLine("Yukarıda bilgileri olan doğum günü etkinliğimize hepiniz davetlisiniz!");
    }

    public void BirthdayInfo()
    {
        Console.WriteLine($"Isim: {Name}\nGün: {Date}\nYer: {Location}");
    }
}
