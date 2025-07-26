using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("I Visited 50 States in 50 Days", "Ryan Trahan", 1900);
        video1.AddComment(new Comment("Amber", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very entertaining!"));
        video1.AddComment(new Comment("Charlie", "Fire Content!"));
        videos.Add(video1);

        Video video2 = new Video("We Crossed Japan with No Map!", "Ludwig", 1500);
        video2.AddComment(new Comment("Danny", "Loved the Chemistry and journey."));
        video2.AddComment(new Comment("Eli", "Japan is so amazing!"));
        video2.AddComment(new Comment("Henry", "How long did this take?"));
        video2.AddComment(new Comment("Jake", "Cool Bikes!"));
        videos.Add(video2);

        Video video3 = new Video("I Became The World’s Richest Man For 7 Minutes", "Max Fosh", 1280);
        video3.AddComment(new Comment("Freddy", "When is my turn?"));
        video3.AddComment(new Comment("George", "Make more videos like this!"));
        video3.AddComment(new Comment("Sally", "So intresting and super funny!!"));
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}