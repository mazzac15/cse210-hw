using System;
using System.Collections.Generic;
using System.IO;


public class AllGoals
{

    private List<Goal> allGoals = new List<Goal>();
    private int _totalPoints;
    public AllGoals()
    {
        totalPoints = 0;
    }
    private int totalPoints;
    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public void addGoal(Goal goal)
    {
        allGoals.Add(goal);
    }
    public void AddPoints(int goalPoints)
    {
         _totalPoints += goalPoints;
        //  _totalPoints = totalPoints;
    }
    public void AddBonus(int bonusPoints)
    {
        totalPoints += bonusPoints;
    }
    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }
    public List<Goal> GetGoalsList()
    {
        return allGoals;
    }
   
    public void ListGoals()
    {
        if (allGoals.Count() > 0)
        {
            Console.WriteLine("Your Goals are:");
            Console.WriteLine();
            int index = 1;
            foreach (Goal goal in allGoals)
            {
                goal.ListGoal(index);
                index = index + 1;
            }
        }
        else
        {
            Console.WriteLine("You currently have no goals.");
        }
 
    }
    

    public void ToCSVRecord()
    {
        Console.WriteLine("What is the name for this goal file? ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";
       
        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            outputFile.WriteLine(_totalPoints);
            foreach (Goal goal in allGoals)
            {
                outputFile.WriteLine(goal.ToCSVRecord());
            }   

            Console.WriteLine("Goals saved successfully.");
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the name of your goal file? ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";
        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);

            // read the first line of text file for total stored points
            int totalPoints = int.Parse(readText[0]);
            SetTotalPoints(totalPoints);
            // skip the first line of text file to read to goals
            readText = readText.Skip(1).ToArray();
            // loop though text file for goals
            foreach (string line in readText)
            {
                string[] entries = line.Split("|");

                string type = entries[0];
                string name = entries[1];
                string description = entries[2];
                int points = int.Parse(entries[3]);
                bool status = Convert.ToBoolean(entries[4]);

                if (entries[0] == "Simple Goal:")
                {
                    SimpleGoal sGoal = new SimpleGoal(type, name, description, points, status);
                    addGoal(sGoal);
                }
                if (entries[0] == "Eternal Goal:")
                {
                    EternalGoal eGoal = new EternalGoal(type, name, description, points, status);
                    addGoal(eGoal);
                }
                if (entries[0] == "Checklist Goal:")
                {
                    int numberTimes = int.Parse(entries[5]);
                    int bonusPoints = int.Parse(entries[6]);
                    int counter = int.Parse(entries[7]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(type, name, description, points, status, numberTimes, bonusPoints, counter);
                    addGoal(checklistGoal);
                }
            }
        }
    }
    public void RecordEvent()
    {
        ListGoals();

        Console.Write("\nWhich goal did you accomplish?  ");
        int select = int.Parse(Console.ReadLine())-1;

        int goalPoints = GetGoalsList()[select].GetGoalPoints();
        AddPoints(goalPoints);

        GetGoalsList()[select].RecordEvent(this);

        Console.WriteLine($"\n*** You have {GetTotalPoints()} points! ***\n");
    }

    public void ClearGoals()
    {
        allGoals.Clear();
    }
}

    
   
    

   