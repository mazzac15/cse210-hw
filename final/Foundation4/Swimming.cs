using System;

class Swimming : Activity
{
   private double swimmingLaps;

   public Swimming(DateOnly _date, double _duration, double _swimmingLaps) : base(_date, _duration)
   {
        swimmingLaps = _swimmingLaps;
   }

    public override void RecordActivity()
    {
        
    }

    public override double GetDistance()
    {
        return swimmingLaps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetDuration()}min)- Distance {GetDistance().ToString("F2")} miles, Speed {GetSpeed().ToString("F2")} mph, Pace: {GetPace().ToString("F2")} min per mile";
    }

}