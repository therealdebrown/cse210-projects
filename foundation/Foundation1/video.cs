using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int ViewCount { get; private set; }
    public int LikeCount { get; private set; }
    public int DislikeCount { get; private set; }

    private List<Comment> Comments;

    public Video(string title, string description)
    {
        Title = title;
        Description = description;
        ViewCount = 0;
        LikeCount = 0;
        DislikeCount = 0;
        Comments = new List<Comment>();
    }

    public void IncrementView()
    {
        ViewCount++;
    }

    public void AddLike()
    {
        LikeCount++;
    }

    public void RemoveLike()
    {
        if (LikeCount > 0)
            LikeCount--;
    }

    public void AddDislike()
    {
        DislikeCount++;
    }

    public void RemoveDislike()
    {
        if (DislikeCount > 0)
            DislikeCount--;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public void DisplayComments()
    {
        foreach (var comment in Comments)
        {
            comment.DisplayCommentDetails();
        }
    }
}