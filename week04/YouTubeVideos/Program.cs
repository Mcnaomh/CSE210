using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video(
            "Building a Gaming PC",
            "TechMaster",
            780);

        video1.AddComment(new Comment("Alex", "Great video!"));
        video1.AddComment(new Comment("Sarah", "Very helpful."));
        video1.AddComment(new Comment("Mike", "Thanks for sharing."));
        videos.Add(video1);


        Video video2 = new Video(
            "Learn C# Basics",
            "Code Academy",
            1200);

        video2.AddComment(new Comment("John", "This helped me a lot."));
        video2.AddComment(new Comment("Lisa", "Excellent tutorial."));
        video2.AddComment(new Comment("Daniel", "Easy to understand."));
        videos.Add(video2);


        Video video3 = new Video(
            "Top Linux Commands",
            "Linux Pro",
            900);

        video3.AddComment(new Comment("Chris", "Very informative."));
        video3.AddComment(new Comment("Olivia", "I learned something new."));
        video3.AddComment(new Comment("Ryan", "Please make more videos."));
        videos.Add(video3);


        Video video4 = new Video(
            "Introduction to Cloud Computing",
            "Cloud Guru",
            1500);

        video4.AddComment(new Comment("Nathan", "Great explanation."));
        video4.AddComment(new Comment("Ava", "Well done."));
        video4.AddComment(new Comment("Ethan", "Looking forward to part 2."));
        videos.Add(video4);


        foreach (Video video in videos)
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}