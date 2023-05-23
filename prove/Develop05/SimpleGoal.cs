using System;
using System.Collections.Generic;
using System.IO;

public class SimpleGoal : Goal
{
    private string _goalType = "Simple Goal:";
    private bool _status;

    public SimpleGoal(string goalType, string goalName, string goaldescription, int goalPoints): base(goalType, goalName, goaldescription, goalPoints)
    {
        _status = false;
    }

    public SimpleGoal(string goalType, string goalName, string goaldescription, int goalPoints, bool status): base(goalType, goalName, goaldescription, goalPoints)
    {
        _status = status;
    }

    public bool Finished()
    {
        return _status;
    }
    
    public override void ListGoal(int i)
    {
        if (Finished() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetGoalName()} ({GetGoalDescription()})");
        }
        else if (Finished())
        {
            Console.WriteLine($"{i}. [x] {GetGoalName()} ({GetGoalDescription()})");
        }
    }
    
    
    public override string ToCSVRecord()
    {
        return ($"{_goalType}|{GetGoalName()}|{GetGoalDescription()}|{GetGoalPoints()}|{_status}");
    }
    public override string LoadGoals()
    {
        return ($"{_goalType}|{GetGoalName()}|{GetGoalDescription()}|{GetGoalPoints()}|{_status}"); 
    }
   

    public override void RecordEvent(AllGoals allGoals)
    {
        _status = true;
        Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");
       
    }
}