using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();

        Video video1= new Video("Unboxing the Future", "TechSavvy Reviews", 120);
        Video video2= new Video("Day in My Life", "DailyVibes with Emma", 282 );
        Video video3= new Video("Ultimate Car Showroom Tour", "AutoWorld Insights", 248);
        Video video4= new Video("Epic Home Makeover", "Smart Living", 650 );

        video1.AddComment("Sarah_TechGeek", "That smartwatch looks insane!");
        video1.AddComment("GadgetLover101", "I love the foldable phone");
        video1.AddComment("AlexTheReviewer", "Great video!");
        video1.AddComment("NextGenTechie", "The AR glasses look cool" );

        video2.AddComment("Simpler99", "OMG, I need to try that product");
        video2.AddComment("LifeLover", "That machine looks amazing" );
        video2.AddComment("Emma86", "This video makes me want to open my own store");

        video3.AddComment("GearHeadX", "That electric SUV looks great!");
        video3.AddComment("SpeedKing88", "I can't believe they brought back the manual transmission in 2025! Finally!");
        video3.AddComment("EcoDriver45", "I love seeing more hybrid options");
        video3.AddComment("LuxuryCarLover", "That leather interior looks premium");

        video4.AddComment("SmartHomeNerd", "I love that smart fridge!");
        video4.AddComment("AlexaFan23", "Does that smart thermostat integrate with Google Home?");
        video4.AddComment("MinimalistMike", "Great video!");

        List<Video> _videos = new List<Video>();
        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);
        _videos.Add(video4);

        int count=1;
        foreach(Video video in _videos)
        {
            System.Console.WriteLine($"Video #{count}");
            video.Display();
            count++;
        }
        
    }
}