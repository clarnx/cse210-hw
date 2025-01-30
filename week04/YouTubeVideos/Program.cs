using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Exploring Mars", "NASA", 1200);
        Video video2 = new Video("Tech in 2025", "Tech Talks", 900);
        Video video3 = new Video("Best Coding Practices", "DevGuru", 1500);

        video1.AddComment(new Comment("Alice", "This is amazing!"));
        video1.AddComment(new Comment("Bob", "I love space exploration!"));
        video1.AddComment(new Comment("Charlie", "Very informative."));

        video2.AddComment(new Comment("David", "C# is evolving so fast!"));
        video2.AddComment(new Comment("Eva", "Programming basics."));
        video2.AddComment(new Comment("Frank", "Looking forward to 2025!"));

        video3.AddComment(new Comment("Grace", "Very useful tips."));
        video3.AddComment(new Comment("Hank", "Clear and concise explanation!"));
        video3.AddComment(new Comment("Ivy", "I learned a lot from this."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}