using CustomIndexer.Models;

namespace CustomIndexer;

internal class Program
{
    static void Main(string[] args)
    {
        StringList objCity = new StringList();
        City city1 = new City(){ Name = "Jalilabad"};
        City city2 = new City(){ Name = "Lerik"};
        City city3 = new City(){ Name = "Baku"};
        City city4 = new City(){ Name = "Ganga"};
        objCity.AddCities(city1,city2,city3,city4);
        City city5 = new City() { Name = "Lankaran" };
        City[] cities = objCity.AddCities(city5);




        // indexer usuli ile axtarmaq 
        string searchCity = Console.ReadLine();
        int index = objCity[searchCity];
        Console.WriteLine(index);
    }
}
