using System;


class Lectures : Event
{
    private string speaker;
    private string capacity;

    public Lectures(string _eventType, string _eventTitle, string _eventDescription, string _eventDate, string _eventTime, Address _eventAddress, string _speaker, string _capacity) : base( _eventType, _eventTitle, _eventDescription, _eventDate, _eventTime, _eventAddress)
    {
        speaker = _speaker;
        capacity = _capacity;
        
    }
 

    public string GetFullDetails()
    {
        return $"Lecture\n{GetStandardDetails()}\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
  

}
