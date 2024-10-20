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
public class Person
{
    private string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (value.Length > 2)
            {
                _name = value;
            }
            else
            {
                Console.WriteLine("Sizin adiniz 2 simvoldan az ola bilmez");
            }
        }
    }
    private int _age;
    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            if (value > 0)
            {
                _age = value;
            }
            else
            {
                Console.WriteLine("Sizin yashiniz sifirdan kicik ola bilmez");
            }
        }
    }
    private DateTime _birthday;
    public DateTime Birthday
    {
        get
        {
            return _birthday;
        }
        set
        {
            if (value.Year > 2006)
            {
                _birthday = value;
            }
            else
            {
                Console.WriteLine("Sizin birthdayiniz qeydiyyatdan kecmek ucun azdir !");
            }
        }
    }
    public Person()
    {

    }
    public Person(string name, int age, DateTime birthday)
    {
        Name = name;
        Age = age;
        Birthday = birthday;

    }


}