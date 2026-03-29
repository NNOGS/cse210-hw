using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // Create list of videos
        List<Video> videos = new List<Video>();

        //------------Video 1 ----------
        Video video1 = new Video("Learn C#", "Obinna Tech", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "I learned a lot!"));

        //-----------Second Video----------
        Video video2 = new Video("OOP Basics", "CodeMaster", 800);
        video2.AddComment(new Comment("David", "Clear explanation."));
        video2.AddComment(new Comment("Eve", "Nice examples."));
        video2.AddComment(new Comment("Frank", "Loved it!"));

        //----------3rd Video--------------
        Video video3 = new Video("C# Collections", "DevWorld", 700);
        video3.AddComment(new Comment("Grace", "Awesome content."));
        video3.AddComment(new Comment("Henry", "Very informative."));
        video3.AddComment(new Comment("Ivy", "Thanks for this!"));

        //Add Videos to list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Videos Display
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine("- " + comment._name + ": " + comment._text);
            }
            Console.WriteLine(); // for spacing.
        }

    }
}