using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Introduction to Database", "You will learn the basics of database.");
        Video video2 = new Video("English with Lucy", "Dive deeper into advanced C1 level.");
        Video video3 = new Video("introduction to programming with classes", "Understand the basics of programming with classes.");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        video1.AddComment(new Comment("Great! I have learn some basics with this video.", "User1"));
        video1.AddComment(new Comment("I would really love to learn more about dictionaries. Do you have a video on them?", "User2"));
        video1.AddComment(new Comment("Working on diagrams was an amazing experience. I highly recommend this video.", "User3"));

        video2.AddComment(new Comment("Good approach! The vocabulary explanations are very useful.", "Stan24"));
        video2.AddComment(new Comment("I loved the part about idioms.", "Vortex2"));
        video2.AddComment(new Comment("Could you make a video on phrasal verbs?", "Annie"));

        video3.AddComment(new Comment("This made understanding OOP concepts so much easier. Thanks", "Student123"));
        video3.AddComment(new Comment("Good explanation of classes. Easy to understand.", "Randy25"));
        video3.AddComment(new Comment("Loved the examples! Helped me grasp the basics of classes.", "Learner123"));

        video1.IncrementView();
        video1.IncrementView();
        video1.AddLike();

        video2.IncrementView();
        video2.AddLike();
        video2.AddLike();
        video2.AddDislike();

        video3.IncrementView();
        video3.IncrementView();
        video3.AddLike();

        foreach (var video in videos)
        {
            Console.WriteLine("\n--- Video Details ---");
            video.DisplayDetails();
        }
    }
}
