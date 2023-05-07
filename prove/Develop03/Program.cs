using System;

class Program
{
    static void Main(string[] args)
    {
        List<(Reference, string)> scriptureList = new List<(Reference, string)>
        {
            (new Reference("Proverbs", "3", "5", "6"), "Trust in the lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him, and he shall direct thy paths."),
            (new Reference("Matthew", "5", "16"), "Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven."),
            (new Reference("John", "10", "16"), "And other sheep I have, which are not of this fold them also I must bring, and they shall hear my voice; and there shall be one fold, and one shepherd."),
            (new Reference("Revelation", "14", "6", "7"), "And I saw another angel fly in the midst of heaven, having the everlasting gospel to preach unto them that dwell on the earth, and to every nation, and kindred, and tongue, and people, Saying with a loud voice, Fear God, and give glory to him; for the hour of his judgment is come: and worship him that made heaven, and earth, and the sea, and the fountains of waters.")
        };

        (Reference, string) randomScripture = scriptureList[new Random().Next(scriptureList.Count)];
        Reference reference = randomScripture.Item1;
        Scripture scripture = new Scripture(reference, randomScripture.Item2);
        string userInput = "";

        while (userInput != "quit" && scripture.HasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or 'quit' to finish:");
            userInput = Console.ReadLine();
            scripture.RemoveWords();
        }

        Console.WriteLine(scripture.GetScripture());
        Console.WriteLine("Hopefully you memorized the scripture!");
    }
}