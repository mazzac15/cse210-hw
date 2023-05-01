using System;
using System.IO;
using System.Collections.Generic;
class Entry
//attributes
{
    string date, prompt, response;
//constructor
    public Entry(string _prompt, string _response)
    {
        date = DateTime.Now.ToString("MM-dd-yyyy");
        prompt = _prompt;
        response = _response;
    }
//methods to format these attributes and print a line with them on them. 
//Put them in the way we want them to show.
    public void DisplayEntry()
    {
        
        Console.WriteLine($"{date}: {prompt}\n{response}");
    
    }

    public string GetEntryCSV()
    {
        return string.Format("{0}|{1}|{2}", date, prompt, response);
    }


}

