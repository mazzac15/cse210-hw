using System;

class Receptions : Event
{
    private string email;

    public Receptions(string _eventType, string _eventTitle, string _eventDescription, string _eventDate, string _eventTime, Address _eventAddress, string _email) : base(_eventType, _eventTitle, _eventDescription, _eventDate, _eventTime, _eventAddress)
    {
        email = _email;
    }

    public string GetFullDetails()
    {
        return $"Reception\n{GetStandardDetails()}\nType: Reception\nEmail: {email}";
    }

}