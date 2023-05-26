using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Video1", "Author1", 200);
        video1.AddComments("Commenter1", "Great video, it was too the point");
        video1.AddComments("Commenter2", "The video was too short and didn't provided enough information.");
        video1.AddComments("Commenter3", "I liked the video, it was fun.");

        Video video2 = new Video("Video2", "Author2", 350);
        video2.AddComments("Commenter4", "The video seemed like it was missing information.");
        video2.AddComments("Commenter5", "I think they skipped over a step in the video.");
        video2.AddComments("Commenter6", "The video was okay, but a little confusing.");

        Video video3 = new Video("Video3", "Author1", 150);
        video3.AddComments("Commenter7", "I really liked this one.");
        video3.AddComments("Commenter8", "They really seem like they know what they are doing.");
        video3.AddComments("Commenter9", "I learned something new, and it was short and informative.");
     

        List<Video> videos = new List<Video> {video1, video2, video3};
        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            video.DisplayComments();
        
        }
    }
}