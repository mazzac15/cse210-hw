using System;

class Program
{
    static void Main(string[] args)
    {
       Address address1 = new Address("101 Misty Ave", "Chicago", "IL");
       Lectures lecture = new Lectures("Lecture","Types of Financial Institutions", "Introduction to different types of financial institutions for beginners in banking.", "Monday, May 8th", "1:00 pm", address1, "Jane Doe", "100");

       
       Address address2 = new Address("222 State St.", "Chicago", "IL");
       Receptions reception = new Receptions("Receptions", "Team Member Networking Event", "Team members interested in networking with other team members and leadership from different lines of business, sponsored by Dollar Bank", "Saturday, July 10th", "7:00 pm", address2, "Smithd@DollarBank.com");

       
       Address address3 = new Address("450 Alex Blvd", "Chicago", "IL");
       OutdoorGatherings outdoorGatherings = new OutdoorGatherings("Outdoor Gatherings", "Team Member and Family BBQ", "Bring your families to the Dollar Bank annual family BBQ", "Saturday, July 20th", "11:30 am - 2:00 pm", address3, "The weather prediction is sunny with a high of 90°F.");


       Console.WriteLine();
       Console.WriteLine(lecture.GetStandardDetails());
       Console.WriteLine();
       Console.WriteLine(lecture.GetFullDetails());
       Console.WriteLine();
       Console.WriteLine(lecture.GetShortDescription());

       Console.WriteLine();
       Console.WriteLine(reception.GetStandardDetails());
       Console.WriteLine();
       Console.WriteLine(reception.GetFullDetails());
       Console.WriteLine();
       Console.WriteLine(reception.GetShortDescription());

       Console.WriteLine();
       Console.WriteLine(outdoorGatherings.GetStandardDetails());
       Console.WriteLine();
       Console.WriteLine(outdoorGatherings.GetFullDetails());
       Console.WriteLine();
       Console.WriteLine(outdoorGatherings.GetShortDescription());

    }
}