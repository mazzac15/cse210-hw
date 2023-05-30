using System;
using System.Collections.Generic;
using System.IO;

class Running : Activity
{
    private double distance;

    public Running(DateOnly _date, double _duration, double _distance) : base(_date, _duration)
    {
        distance = _distance;
    }
    
    public override void RecordActivity()
    {

    }

    public override double GetDistance()
    {
        return distance;
    }

   public override double GetSpeed()
    {
        return (distance / GetDuration()) * 60;
    }

    public override double GetPace()
    {
        return GetDuration() / distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetDuration()}min)- Distance {distance.ToString("F2")} miles, Speed {GetSpeed().ToString("F2")} mph, Pace: {GetPace().ToString("F2")} min per mile";
    }

}