using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity   
{
    List<string> reflectionPrompts = new List<string>
    {
        "---Think of a time when you stood up for someone else.---",
        "---Think of a time when you did something really difficult.---",
        "---Think of a time when you helped someone in need.---",
        "---Think of a time when you did something truly selfless.---"
    };

    List<string> reflectionQuestions = new List<string>
    {
        "> Why was this experience meaningful to you?",
        "> Have you ever done anything like this before?",
        "> How did you get started?",
        "> How did you feel when it was complete?",
        "> What made this time different than other times when you were not as successful?",
        "> What is your favorite thing about this experience?",
        "> What could you learn from this experience that applies to other situations?",
        "> What did you learn about yourself through this experience?",
        "> How can you keep this experience in mind in the future?"
    };
    

    public ReflectionActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(reflectionPrompts.Count);
        return reflectionPrompts[index];  
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(reflectionQuestions.Count);
        string question = reflectionQuestions[index];
        reflectionQuestions.RemoveAt(index);
        return question;
    }

    public void RunReflectionActivity()
    {
        GetStartMessage();

        GetDuration();
        int duration = int.Parse(_duration);
        
        GetReadyMessage();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        string prompt = GetRandomPrompt();
        Console.Write(prompt);
        Spinner();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.Write("Now ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
        PauseCountdown();
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.Write(question);
            Spinner();
            Spinner();
            Spinner();
            Console.WriteLine();
            Console.WriteLine();
        }

        GetEndMessage();
        Spinner();
        Console.Clear();
    }
}

