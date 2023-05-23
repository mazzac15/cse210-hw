using System;
using System.Collections.Generic;
using System.IO;

public class EternalGoal : Goal
{
    private string _goalType = "Eternal Goal:";
    private bool _status;

    public EternalGoal(string goalType, string goalName, string goalDescription, int goalPoints) : base(goalType, goalName, goalDescription, goalPoints)
    {
        _status = false;
    }
    public EternalGoal(string goalType, string goalName, string goalDescription, int goalPoints, bool status) : base(goalType, goalName, goalDescription, goalPoints)
    {
        _status = status;
    }
   
    public override void ListGoal(int i)
    {
        Console.WriteLine($"{i}. [ ] {GetGoalName()} ({GetGoalDescription()})");
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