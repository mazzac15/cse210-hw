using System;

class OutdoorGatherings : Event
{
    private string weatherForecast;

    public OutdoorGatherings(string _eventType, string _eventTitle, string _eventDescription, string _eventDate, string _eventTime, Address _eventAddress, string _weatherForecast) : base(_eventType, _eventTitle, _eventDescription, _eventDate, _eventTime, _eventAddress)
    {
        weatherForecast = _weatherForecast;
    }


    public string GetFullDetails()
    {
        return $"Outdoor Gathering\n{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }
}