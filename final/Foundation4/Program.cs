using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateOnly(2023, 5, 30), 30, 3.0));
        activities.Add(new Cycling(new DateOnly(2023, 5, 30), 30, 15));
        activities.Add(new Swimming(new DateOnly(2023, 5, 30), 20, 40));

        foreach (Activity activity in activities)
        {
            string summary = activity.GetSummary();
            Console.WriteLine(summary);
        }        

    }
}