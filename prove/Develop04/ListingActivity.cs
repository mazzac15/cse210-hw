using System;

public class ListingActivity : Activity
{
    List<string> listingPrompts = new List<string>
    {
        "---Who are people that you appreciate?---",
        "---What are personal strengths of yours?---",
        "---Who are people that you have helped this week?---",
        "---When have you felt the Holy Ghost this month?---",
        "---Who are some of your personal heroes?---"
    };

    public ListingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {
    }

    public string GetListingPrompt()
    {
        Random random = new Random();
        int index = random.Next(listingPrompts.Count);
        return listingPrompts[index];
    }

    public void RunListingActivity()
    {
        GetStartMessage();

        GetDuration();
        int duration = int.Parse(_duration);

        GetReadyMessage();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        string listing = GetListingPrompt();
        Console.WriteLine(listing);
        Console.WriteLine();
        Console.Write("You may begin in: ");
        PauseCountdown();
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {count} items!");
        Console.WriteLine();
        GetEndMessage();
        Spinner();
        Console.Clear();

    }

    
    //display totalListItems

}