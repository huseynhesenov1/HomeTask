namespace Encapsulation;

internal class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "Eltac";
        person.Age = 5;
        person.Birthday = new DateTime(2005, 12, 25);
        Console.WriteLine($"Sizin adiniz {person.Name}-dir");
        Console.WriteLine($"Sizin yashiniz { person.Age}-dir");
        Console.WriteLine(person.Birthday);


    }
}
