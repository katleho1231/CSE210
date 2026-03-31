using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("Learn C# Basics", "Katleho Selwana", 300);
        v1.AddComment(new Comment("John", "Great tutorial!"));
        v1.AddComment(new Comment("Sarah", "Very helpful."));
        v1.AddComment(new Comment("Mike", "Easy to understand."));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("Object-Oriented Programming in C#", "CodeMaster", 450);
        v2.AddComment(new Comment("Anna", "Loved this explanation!"));
        v2.AddComment(new Comment("James", "Classes make sense now."));
        v2.AddComment(new Comment("Lebo", "Thanks for this video!"));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("Build a Console App", "DevPro", 600);
        v3.AddComment(new Comment("Chris", "Nice walkthrough."));
        v3.AddComment(new Comment("Emily", "Step by step is perfect."));
        v3.AddComment(new Comment("Thabo", "Helped me a lot."));
        videos.Add(v3);

        // Display all videos
        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}
