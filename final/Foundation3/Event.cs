using System;

class Event
{
    private string eventTitle;
    private string eventDescription;
    private string eventDate;
    private string eventTime;
    private Address eventAddress;
    private string eventType;

    public Event(string _eventType, string _eventTitle, string _eventDescription, string _eventDate, string _eventTime, Address _eventAddress)
    {
        eventTitle = _eventTitle;
        eventDescription = _eventDescription;
        eventDate = _eventDate;
        eventTime = _eventTime;
        eventAddress = _eventAddress;
        eventType = _eventType;
        

    }

    public string GetStandardDetails()
    {
        return $"{eventTitle}\n{eventDescription}\n{eventDate}\n{eventTime}\n{eventAddress.GetFullEventAddress()}";
    }

    public string GetShortDescription()
    {
        return $"{eventType}\n{eventTitle}\n{eventDate}";
    }
}