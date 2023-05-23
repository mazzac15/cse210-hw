using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        AllGoals allGoals = new AllGoals();
        Console.Clear();
        Console.WriteLine("---Welcome to the Eternal Quest Program---");

        Console.WriteLine($"**You currently have {allGoals.GetTotalPoints()} points!**");
        // MainMenu mainMenu = new MainMenu();
        // GoalMenu goalMenu = new GoalMenu();

        int mainMenuSelection = 0;
        while (mainMenuSelection != 6)
        {   
            Console.WriteLine();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Enter your selection: ");
            mainMenuSelection = int.Parse(Console.ReadLine());

            // mainMenuSelection = mainMenu.UserSelection();
            switch(mainMenuSelection)
            {
                case 1:
                    
                    int goalMenuSelection = 0;
                    while(goalMenuSelection != 4)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Goal Menu");
                        Console.WriteLine("1. Add Simple Goal");
                        Console.WriteLine("2. Add Eternal Goal");
                        Console.WriteLine("3. Add Checklist Goal");
                        Console.WriteLine("4. Back to Main Menu");

                        Console.Write("Enter your selection: ");
                        goalMenuSelection = int.Parse(Console.ReadLine());
                        // goalMenuSelection = goalMenu.GoalMenuSelection();
            
                        switch (goalMenuSelection)
                        {
                            case 1:
                                Console.Write("What is the name of your goal? ");
                                string goalName = Console.ReadLine();
                                Console.Write("What is a short description of your goal? ");
                                string goalDescription = Console.ReadLine();
                                Console.Write("What is the amount of points associated with this goal?  ");
                                int goalPoints = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                SimpleGoal simpleGoal = new SimpleGoal("Simple Goal:", goalName, goalDescription, goalPoints);
                                allGoals.addGoal(simpleGoal);
                                break;
                            case 2:
                                Console.Write("What is the name of your goal? ");
                                goalName = Console.ReadLine();
                                Console.Write("What is a short description of your goal? ");
                                goalDescription = Console.ReadLine();
                                Console.Write("What is the amount of points associated with this goal?  ");
                                goalPoints = int.Parse(Console.ReadLine());
                                EternalGoal eternalGoal = new EternalGoal("Eternal Goal:", goalName, goalDescription, goalPoints);
                                allGoals.addGoal(eternalGoal);
                                break;
                            case 3:
                                Console.Write("What is the name of your goal? ");
                                goalName = Console.ReadLine();
                                Console.Write("What is a short description of your goal? ");
                                goalDescription = Console.ReadLine();
                                Console.Write("What is the amount of points associated with this goal?  ");
                                goalPoints = int.Parse(Console.ReadLine());
                                Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
                                int numberTimes = int.Parse(Console.ReadLine());
                                Console.Write("What is the bonus for accomplishing it that many times?  ");
                                int bonusPoints = int.Parse(Console.ReadLine());
                                ChecklistGoal checklistGoal = new ChecklistGoal("Checklist Goal:", goalName, goalDescription, goalPoints, numberTimes, bonusPoints);
                                allGoals.addGoal(checklistGoal);
                                break; 

                        }

                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine($"*** You currently have {allGoals.GetTotalPoints()} points! ***\n");
                    allGoals.ListGoals();
                    break;
                case 3:
                    // Save Goals
                    allGoals.ToCSVRecord();
                    break;
                case 4:
                    // Load Goals
                    Console.Clear();
                    Console.Write($"\n*** You currently have {allGoals.GetTotalPoints()} points! ***\n");
                    allGoals.ClearGoals();
                    allGoals.LoadGoals();
                    break;
                case 5:
                    // Record Event
                    Console.Clear(); 
                    Console.Write($"\n*** You currently have {allGoals.GetTotalPoints()} points! ***\n");
                    allGoals.RecordEvent();
                    break;
                case 6:
                    // Quite
                    Console.WriteLine("\nThank you for using the Eternal Quest Program!\n");
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }

        }
    }
}
