using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIndexer.Models;

public class StringList
{
    City[] cities;
    public StringList()
    {
        cities = new City[0];
    }
    public void AddCity(City city)
    {
        Array.Resize(ref cities, cities.Length + 1);
        cities[cities.Length - 1] = city;
        Console.WriteLine("City Added to Cities array");
    }
    public City[] AddCities(params City[] inputCity)
    {
        Array.Resize(ref cities, cities.Length + inputCity.Length);
        for (int i = 0; i < inputCity.Length; i++)
        {
            cities[cities.Length - inputCity.Length + i] = inputCity[i];

        }
        return cities;
    }
    public int this[string cityName]
    {
        get
        {
            for (int i = 0; i < cities.Length; i++)
            {
                if (cities[i].Name == cityName)
                {
                    return i; 
                }
            }
            return -1; 
        }
    }
}
