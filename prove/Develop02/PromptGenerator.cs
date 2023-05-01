using System;
using System.IO;
using System.Collections.Generic;
class PromptGenerator
{
    List<string> prompts;

    public PromptGenerator()
    {
       prompts = new List<string>
       {
            "What changes are you making in your life to be more like Christ?",
            "Who inspired you today and why?",
            "What was the best thing that happened today?",
            "What do you hope to accomplish this month?",
            "What are you most proud of today?"
       };
    }
   
   public string GetRandomPrompt()
   {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
   }
}

