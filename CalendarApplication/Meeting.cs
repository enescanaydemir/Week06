using System;

namespace CalendarApplication;

public class Meeting : Event
{
    public Meeting(string name, string date, string location) : base(name, date, location)
    {
    }
}
