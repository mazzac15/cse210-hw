using System;

class Cycling : Activity
{
    private double speed;

    public Cycling(DateOnly _date, double _duration, double _speed) : base(_date, _duration)
    {
        speed = _speed;
    }

    public override void RecordActivity()
    {
        
    }

    public override double GetSpeed()
    {
        return speed;
    }



    public override double GetPace()
    {
        return 60 / speed;
    }

    public override double GetDistance()
    {
        return GetDuration() / GetPace();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetDuration()}min)- Distance {GetDistance().ToString("F2")} miles, Speed {speed.ToString("F2")} mph, Pace: {GetPace().ToString("F2")} min per mile";
    }
}