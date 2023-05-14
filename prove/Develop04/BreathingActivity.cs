using System;


public class BreathingActivity : Activity
{
    private string _breatheTechnique;

    
   public BreathingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
   {
   }

    

    public void RunBreathingActivity()
    {
        GetStartMessage();

        GetDuration();
        int duration = int.Parse(_duration);
        int totalRuntime = (duration -2) * 2;
        GetReadyMessage();
        Console.WriteLine();
        Console.WriteLine();
        // for (int i = 0; i < totalRuntime; i++)
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            
            Console.WriteLine("Inhale deeply...");
            PauseCountdown();
            Console.WriteLine("Exhale slowly...");
            PauseCountdown();
        }
        
        GetEndMessage();
        Spinner();
        Console.Clear();
    }
}

