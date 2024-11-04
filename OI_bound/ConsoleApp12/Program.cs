
using System.Diagnostics;

namespace ConsoleApp12;

internal class Program
{
    static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();

        List<string> urls = new List<string>()
        {
        "https://www.blackbox.ai/",
        "https://profile.w3schools.com/log-in?redirect_url=https%3A%2F%2Fwww.w3schools.com%2F",
        "https://www.w3schools.com/cs/index.php",
        "https://learn.microsoft.com/en-us/dotnet/csharp/",
        "https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-8.0",
        "https://dotnet.microsoft.com/en-us/download",
        };




        //Console.WriteLine("Asinxron method ile");
        //Retrieved(urls);
        //Console.WriteLine(sw.ElapsedMilliseconds);





        Console.WriteLine("Sinxron method ile");
        RetrievedAsync(urls);
        Console.WriteLine(sw.ElapsedMilliseconds);
    }

    public static void Retrieved(List<string> urls)
    {
        HttpClient client = new HttpClient();
        foreach (string url in urls)
        {
            client.GetStringAsync(url).Result.ToString();
        }
    }

    public static async Task RetrievedAsync(List<string> urls)
    {
        HttpClient httpClient = new HttpClient();
        List<Task<string>> tasks = new List<Task<string>>();
        foreach (string url in urls)
        {
            tasks.Add(httpClient.GetStringAsync(url));
        }
        await Task.WhenAll(tasks);
    }
}