using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Love Next Door", "Lee Do-min", 2045);
        Comment comment1 = new Comment("Gift Ndoma", "Very Ineresting!");
        Comment comment2 = new Comment("Gift Ndoma", "Very Ineresting!!");
        Comment comment3 = new Comment("Gift Ndoma", "Very Ineresting!!!");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        videos.Add(video1);

        Video video2 = new Video("Love in the MoonLight", "Shin Go-ah", 30076);
        Comment comment4 = new Comment("Choice Ndoma", "Very Ineresting!");
        Comment comment5 = new Comment("Choice Ndoma", "Very Ineresting!!");
        Comment comment6 = new Comment("Choice Ndoma", "Very Ineresting!!!");
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        videos.Add(video2);

        Video video3 = new Video("Boys Over Flowers", "Lee Min-ho", 42009);
        Comment comment7 = new Comment("Divine Ndoma", "Very Ineresting!");
        Comment comment8 = new Comment("Divine Ndoma", "Very Ineresting!!");
        Comment comment9 = new Comment("Divine Ndoma", "Very Ineresting!!!");
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}