// using System;
// using System.Collections.Generic;
// using System.IO;

// class Journal
// {
//     List<Entry> entries;
    
//     public Journal()
//     {
//         entries = new List<Entry>();

//     }

//     public void CreateJournalEntry()
//     {
//         Console.WriteLine("Answer the following prompt:");
//         string prompt = PromptGenerator.GetRandomPrompt();
//         Console.WriteLine(prompt);
//         string response = Console.ReadLine();
//         Entry entry = new Entry(prompt, response, DateTime.Now);
//         entries.Add(entry);
        

//     }

//     public void DisplayJournalEntries()
//     {
//         foreach (Entry entry in entries)
//         {
//             entry.DisplayEntry();
//         }
//     }

//     public void SaveToFile()
//     {        
//         Console.WriteLine("Enter a filename to save the journal to:");
//         string filename = Console.ReadLine();

//         using(StreamWriter writer = new StreamWriter(filename))
//         {
//             foreach (Entry entry in entries)
//             {
//                 writer.WriteLine($"{entry.Date}: {entry.Prompt}\n{entry.response}\n");
//             }
//         }
//     }
        
    

//     public void LoadToFile()
//     {
//         Console.WriteLine("Enter a filename to load the journal from:");
//         string filename = Console.ReadLine();
        
//         List<Entry> loadedEntries = new List<Entry>();
        

//         using (StreamReader reader = new StreamReader(filename))

//     //     foreach (string line in lines)
//     //     {
//     //         Console.WriteLine(line);
//     //     }

//     //     return entries;
//     // }


using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    List<Entry> entries;
    PromptGenerator promptGenerator;

    public Journal()
    {
        entries = new List<Entry>();
        promptGenerator = new PromptGenerator();
    }

    //methods
    public void CreateJournalEntry()
    {
        Console.WriteLine("Answer the following prompt:");
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        Entry entry = new Entry(prompt, response);
        entries.Add(entry);   
    }

    public void DisplayJournalEntries()
        {
            foreach (Entry entry in entries)
            {
                entry.DisplayEntry();
            }
        }

    public void SaveToCSV()
    {
        Console.WriteLine("Enter a filename to save the journal to:");
        string filename = Console.ReadLine();

        using(StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.GetEntryCSV());
            }
        }
    }
    public void LoadFromCSV()
    {
        Console.WriteLine("Enter a filename to load the journal from:");
        string filename = Console.ReadLine();

        using(StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] entryItems = line.Split("|");
                string date = entryItems[0];
                string prompt = entryItems [1];
                string response = entryItems [2];
                Console.WriteLine($"{date}: {prompt}\n{response}");

            }

        }
    }
    
}