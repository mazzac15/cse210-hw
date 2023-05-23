using System;
using System.Collections.Generic;
using System.IO;

public abstract class Goal
{
    private string _goalType;
    private string _goalName;
    private string _goalDescription;
    
    private int _goalPoints;
    
   

    public Goal(string goalType, string goalName, string goalDescription, int goalPoints)
    {
        _goalType = goalType;
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
      
    }

    public string GetGoalType()
    {
        return _goalType;
    }
    

    public string GetGoalDescription()
    {
       
        return _goalDescription;
    }

    public int GetGoalPoints()
    {
        return _goalPoints;
    }
    public string GetGoalName()
    {
        return _goalName;
    }
   
    

    public abstract string ToCSVRecord();
    public abstract void RecordEvent(AllGoals allGoals);
    public abstract void ListGoal(int i);
   
    public abstract string LoadGoals();
   


}