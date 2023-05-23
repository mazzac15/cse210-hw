using System;
using System.Collections.Generic;
using System.IO;

public class ChecklistGoal: Goal
{
   
    private string _goalType = "Checklist Goal:";
    private int _numberTimes;
   
    private int _bonusPoints;
    private bool _status;
    private int _count;

   

    public ChecklistGoal(string goalType, string goalName, string goalDescription, int goalPoints, int numberTimes, int bonusPoints) : base(goalType, goalName, goalDescription, goalPoints)
    {
        
     
    
    }

    public ChecklistGoal(string goalType, string goalName, string goalDescription, int goalPoints, bool status, int numberTimes, int bonusPoints, int count) : base(goalType, goalName, goalDescription, goalPoints)
    {
        _status = false;
        _numberTimes = numberTimes;
        _bonusPoints = bonusPoints;
        _count = 0;
    }
    public int GetTimes()
    {
        return _numberTimes;
    }
    public void SetTimes()
    {
        _count = _count + 1;
    }
    public int GetCount()
    {
        return _count;
    }
   
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public Boolean Finished()
    {
        return _status;
    }


    public override void ListGoal(int i)
    {
        if (Finished() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetGoalName()} ({GetGoalDescription()}) -- Currently Completed: {GetCount()}/{GetTimes()}");
        }
        else if (Finished())
        {
            Console.WriteLine($"{i}. [x] {GetGoalName()} ({GetGoalDescription()}) -- Currently Completed: {GetCount()}/{GetTimes()}");
        }
    }

     public override string ToCSVRecord()
    {
        return $"{_goalType}|{GetGoalName()}|{GetGoalDescription()}|{GetGoalPoints()}|{_status}|{GetTimes()}|{GetBonusPoints()}|{GetCount()}";
    }
    public override string LoadGoals()
    {
        return $"{_goalType}|{GetGoalName()}|{GetGoalDescription()}|{GetGoalPoints()}|{_status}|{GetTimes()}|{GetBonusPoints()}|{GetCount()}";
    }
    
    
    public override void RecordEvent(AllGoals allGoals)
    {
        SetTimes();
        int goalPoints = GetGoalPoints();

        if (_count == _numberTimes)
        {
            _status = true;
            goalPoints += _bonusPoints;
            Console.WriteLine($"Congratulations! You have earned {goalPoints} points!");
            allGoals.AddPoints(goalPoints);
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {goalPoints} points!");
        }
        
    }

}