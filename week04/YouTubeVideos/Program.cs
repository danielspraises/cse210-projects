using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C#", "CodeAcademy", 600);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks."));
        video1.AddComment(new Comment("Chris", "This cleared things up."));
        videos.Add(video1);

        Video video2 = new Video("OOP Principles", "TechWorld", 750);
        video2.AddComment(new Comment("Dana", "Encapsulation finally makes sense."));
        video2.AddComment(new Comment("Eli", "Nice examples."));
        video2.AddComment(new Comment("Faith", "Loved the breakdown."));
        videos.Add(video2);

        Video video3 = new Video("Abstraction in C#", "DevSimplified", 540);
        video3.AddComment(new Comment("George", "Straight to the point."));
        video3.AddComment(new Comment("Hannah", "Clear and concise."));
        video3.AddComment(new Comment("Ian", "Perfect for beginners."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }
        }
    }
}
