using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Video video = new Video("Sample Video", "This is a description of the video.");
        video.IncrementView();
        video.AddLike();

        Console.WriteLine($"Title: {video.Title}");
        Console.WriteLine($"Description: {video.Description}");
        Console.WriteLine($"Views: {video.ViewCount}");
        Console.WriteLine($"Likes: {video.LikeCount}");
        Console.WriteLine($"Dislikes: {video.DislikeCount}");

        Comment comment1 = new Comment("Amazing video!", "User1");
        video.AddComment(comment1);

        Comment reply1 = new Comment("Thank you!", "User2", 1);
        video.AddComment(reply1);

         Comment comment2 = new Comment("Good graphics!", "User1");
        video.AddComment(comment2);

        Comment reply2 = new Comment("Moise made the graphics!", "User2", 1);
        video.AddComment(reply2);

         Comment comment3 = new Comment("Always on top!", "User1");
        video.AddComment(comment3);

        Comment reply3 = new Comment("Best comment!", "User2", 1);
        video.AddComment(reply3);

        Console.WriteLine("\nComments:");
        video.DisplayComments();

        comment1.EditComment("Amazing video!");
        comment1.DeleteComment();
        Console.WriteLine("\nUpdated Comments:");
        video.DisplayComments();
    }
}
