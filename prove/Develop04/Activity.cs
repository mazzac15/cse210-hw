using System;

public class Activity
{

    private string _activityName;

    private string _activityDescription;

    public string _duration;

    private string _readyMessage;

    private string _endMessage;

    private string _startMessage;

    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        
    }


    public void PauseCountdown()
    {
        for (int i = 5; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void Spinner(int duration = 5000)
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(100);
            Console.Write("\b \b");

            i++;

            if (i >= spinner.Count)
            {
               i = 0; 
            }
        }
    }
    
    public string GetStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.\n\n{_activityDescription}\n\n{_duration} ");
        return _startMessage;
    }

    public void GetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = Console.ReadLine();

    }
    public string GetReadyMessage()
    {
        Console.Clear();
        Console.Write("Get ready...");
        Spinner();
        return _readyMessage;
    }

    public string GetEndMessage()
    {
        Console.WriteLine("Well done!");
        Spinner();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}.");
        Spinner();
        return _endMessage;
    }

    public string GetActivityName()
    {
        return _activityName;
    }

    public string GetActivityDescription()
    {
        return _activityDescription;
    }
}

