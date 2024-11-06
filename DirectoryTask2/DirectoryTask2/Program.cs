
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;

namespace DirectoryTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task2
            //string path = "C:\\Users\\ACER\\source\\repos\\DirectoryTask2\\DirectoryTask2";

            //Directory.CreateDirectory(path+ "\\Models");
            //Directory.CreateDirectory(path+ "\\Data");


            //if (!File.Exists(path + "\\Data" + "\\jsonData.json"))
            //{
            //    File.Create(path + "\\Data" + "\\jsonData.json");
            //}


            //List<string> urls = new List<string>()
            //{
            //    "https://jsonplaceholder.typicode.com/posts",

            //};
            //  RetrievedSerilaize(urls);


            #endregion


            #region Task1

          /*  Stopwatch sw = new Stopwatch();
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




            //Console.WriteLine("Sinxron method ile");
            //Retrieved(urls);
            //Console.WriteLine(sw.ElapsedMilliseconds);





            Console.WriteLine("Asinxron method ile");
            RetrievedAsync(urls);
            Console.WriteLine(sw.ElapsedMilliseconds);
          */

            #endregion
        }
        public static void RetrievedSerilaize(List<string> urls)
        {
            string path = "C:\\Users\\ACER\\source\\repos\\DirectoryTask2\\DirectoryTask2";

            HttpClient client = new HttpClient();
            foreach (string url in urls)
            {
                string jsonData = client.GetStringAsync(url).Result;

                string serialized = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(jsonData), Formatting.Indented);
                
                using (StreamWriter sw = new StreamWriter(path + "\\Data" + "\\jsonData.json"))
                {
                    sw.WriteLine(serialized);
                }
            }
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
}
