using System;
using System.IO;
using System.Collections.Generic;

class Video
{
    string title;
    string author;
    int length;
    List<Comment> comments;

    public Video(string _title, string _author, int _length)
    {
        title = _title;
        author = _author;
        length = _length;
        comments = new List<Comment>();
    }
    public void AddComments(string commenterName, string commentText)
    {
        Comment comment = new Comment(commenterName, commentText);
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }
    public void DisplayComments()
    {
        foreach (Comment comment in comments)
        {
            Console.WriteLine($"{comment.GetCommenterName()}: {comment.GetCommentText()}");
        }
    }
    public void DisplayVideo()
    {
        Console.WriteLine();
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length in seconds: {length}");
    }

}