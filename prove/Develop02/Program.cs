using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int menuUserinput = 0;
        
        List<string> menu = new List<string>
            {
                "Please select one of the following choices:",
                "1. Write",
                "2. Display",
                "3. Save",
                "4. Load",
                "5. Quit",
                "What would you like to do? "   
            };

        //While user input is not 5
        while (menuUserinput != 5)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuUserinput = int.Parse(Console.ReadLine());
        

            switch (menuUserinput)
            {
                case 1:
                    journal.CreateJournalEntry();
                    break;
                case 2:
                    journal.DisplayJournalEntries();
                    break;
                case 3:
                    journal.SaveToCSV();
                    break;
                case 4:
                    journal.LoadFromCSV();
                    break;
                case 5:
                    Console.WriteLine("Done");
                    break;
                default:
                    Console.WriteLine("Invalid user input, please try again.");
                    break;
            }

        
        }
    }
}