using System;
using System.Collections.Generic;
using System.IO;

public abstract class Activity
{
    private DateOnly date;
    private double duration;
    private List<Activity> activies;

    public Activity(DateOnly _date, double _duration)
    {
        date = _date;
        duration = _duration;
    }
    public DateOnly GetDate()
    {
        return date;
    }
    public double GetDuration()
    {
        return duration;
    }
    public virtual void RecordActivity()
    {
       
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }

    public abstract string GetSummary();
    
}