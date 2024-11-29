using System;
using System.Collections.Generic;
public class Comment
{
    public string CommentText { get; set; }
    public string Username { get; set; }
    public DateTime Timestamp { get; private set; }
    public int? ParentCommentID { get; private set; }

    public Comment(string commentText, string username, int? parentCommentID = null)
    {
        CommentText = commentText;
        Username = username;
        Timestamp = DateTime.Now;
        ParentCommentID = parentCommentID;
    }

    public void DisplayCommentDetails()
    {
        Console.WriteLine($"[{Timestamp}] {Username}: {CommentText}");
        if (ParentCommentID.HasValue)
        {
            Console.WriteLine($"(Reply to Comment ID: {ParentCommentID})");
        }
    }

    public void EditComment(string newText)
    {
        CommentText = newText;
        Console.WriteLine("Comment updated.");
    }

    public void DeleteComment()
    {
        CommentText = "[Deleted]";
        Console.WriteLine("Comment deleted.");
    }
}