using System;
using System.Collections.Generic;
using System.Linq.Expressions;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public string Title { get { return title; } } //perubahan
    public int PlayCount { get { return playCount; } } //perubahan

    public SayaTubeVideo(string title)
    {
        if (title == null) throw new ArgumentNullException("Judul tidak boleh null"); //perubahan
        if (title.Length > 200) throw new ArgumentException("Judul tidak boleh lebih dari 200 karakter"); //perubahan

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0) throw new ArgumentException("Play count tidak boleh negatif");
        if (count > 25000000) throw new ArgumentException("Maksimum play count adalah 25.000.000");

        checked
        {
            try
            {
                playCount += count;
            }
            catch (OverflowException)
            {
                Console.WriteLine("ERROR: Play count melebihi batas integer."); 
            }
        }
    } //perubahan

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
        if (username == null) throw new ArgumentNullException("Username tidak boleh null"); //perubahan
        if (username.Length > 100) throw new ArgumentException("Username tidak boleh lebih dari 100 karakter"); //perubahan

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        if (video == null) throw new ArgumentNullException("Video tidak boleh null"); //perubahan
        if (video.PlayCount >= int.MaxValue) throw new ArgumentException("Play count tidak boleh lebih dari batas maksimum integer"); //perubahan

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
        int maxPrint = Math.Min(8, uploadedVideos.Count); //perubahan
        for (int i = 0; i < maxPrint; i++)
        {
            Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].Title}"); 
        }
    }
}

class Program
{
    static void Main()
    {
        try // perubahan
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
                "Review Film Dirty Dancing oleh Alya Rabani",
                "Review Film A Brighter Summer Days oleh Alya Rabani",
                "Review Film The Substance oleh Alya Rabani"
            };

            foreach (var title in filmTitles)
            {
                SayaTubeVideo video = new SayaTubeVideo(title);
                user.AddVideo(video);
            }

            user.PrintAllVideoPlaycount();

            // Uji batas play count
            SayaTubeVideo testVideo = new SayaTubeVideo("Review Film Uji Maksimum");
            try
            {
                testVideo.IncreasePlayCount(25000001); // Harus error
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: {e.Message}");
            }

            try
            {
                testVideo.IncreasePlayCount(-5); // Harus error
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: {e.Message}");
            }

            user.AddVideo(testVideo);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
        }
    }
}
