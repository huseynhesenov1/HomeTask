//using System.Text.Json.Serialization;
//using Newtonsoft.Json;
using Newtonsoft.Json;
using System.IO;

namespace DirectoryTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\ACER\\source\\repos\\DirectoryTask2\\DirectoryTask2";
            
            Directory.CreateDirectory(path+ "\\Models");
            Directory.CreateDirectory(path+ "\\Data");

           
            if (!File.Exists(path + "\\Data" + "\\jsonData.json"))
            {
                File.Create(path + "\\Data" + "\\jsonData.json");
            }

            
            List<string> urls = new List<string>()
            {
                "https://jsonplaceholder.typicode.com/posts",

            };


            Console.WriteLine("sinxron method ile");
            Retrieved(urls);
            
        }
        public static void Retrieved(List<string> urls)
        {
            string path = "C:\\Users\\ACER\\source\\repos\\DirectoryTask2\\DirectoryTask2";

            HttpClient client = new HttpClient();
            foreach (string url in urls)
            {
                //Console.WriteLine(client.GetStringAsync(url).Result.ToString());
                //string serialized = JsonConvert.SerializeObject(client.GetStringAsync(url).Result);
                //Console.WriteLine(serialized);
                using (StreamWriter sw = new StreamWriter(path + "\\Data" + "\\jsonData.json"))
                {
                    sw.WriteLine(client.GetStringAsync(url).Result);
                    sw.Close();
                }
            }
        }
    }
}
