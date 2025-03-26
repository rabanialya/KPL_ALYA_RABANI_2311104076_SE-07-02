using System;
using System.Collections.Generic;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public string Title { get { return title; } }
    public int PlayCount { get { return playCount; } }

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}\n");
    }
}

class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string Username { get; private set; }

    public SayaTubeUser(string username)
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (var video in uploadedVideos)
        {
            total += video.PlayCount; 
        }
        return total;
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {Username}");
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].Title}"); // Gunakan getter
        }
    }
}

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Alya Rabani");

        List<string> filmTitles = new List<string>
        {
            "Review Film Inception oleh Alya Rabani",
            "Review Film Interstellar oleh Alya Rabani",
            "Review Film Anora oleh Alya Rabani",
            "Review Film The Dark Knight oleh Alya Rabani",
            "Review Film Parasite oleh Alya Rabani",
            "Review Film The Godfather oleh Alya Rabani",
            "Review Film Fight Club oleh Alya Rabani",
            "Review Film Dirty dancing oleh Alya Rabani",
            "Review Film A Brighter Summer Days oleh Alya Rabani",
            "Review Film The Substance oleh Alya Rabani"
        };

        foreach (var title in filmTitles)
        {
            SayaTubeVideo video = new SayaTubeVideo(title);
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();
    }
}