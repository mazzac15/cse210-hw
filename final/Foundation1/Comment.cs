using System;
using System.IO;
using System.Collections.Generic;

class Comment
{
    string commenterName;
    string commentText;
    

    public Comment(string _commenterName, string _commentText)
    {
        commenterName = _commenterName;
        commentText = _commentText;
    }

    public string GetCommenterName()
    {
        return commenterName;
    }
    public string GetCommentText()
    {
        return commentText;
    }
}