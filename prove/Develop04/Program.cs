using System;

class Program
{
    static void Main(string[] args)
    {
        
        int menuUserinput = 0;

        List<string> menu = new List<string>
            {
                "Menu Options:",
                "1. Start breathing activity",
                "2. Start reflecting activity",
                "3. Start listing activity",
                "4. Quit",
                "Select a choice from the menu:"   
            };
        
        //While user input is not 4
        while (menuUserinput != 4)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuUserinput = int.Parse(Console.ReadLine());

           
            
            switch (menuUserinput)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathingActivity.RunBreathingActivity();
                    break;
                case 2:
                    ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflectionActivity.RunReflectionActivity();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listingActivity.RunListingActivity();
                    break;
                case 4:
                    Console.WriteLine("Done");
                    break;
                default:
                    Console.WriteLine("Invalid user input, please try again.");
                    break;
            }
        
        
        }
    }
}