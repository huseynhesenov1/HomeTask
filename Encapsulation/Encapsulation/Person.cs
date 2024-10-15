namespace Encapsulation;

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
            if (value.Year>2006)
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
    public Person(string name,int age,DateTime birthday)
    {
        Name = name;
        Age = age;
        Birthday = birthday;

    }
   
    
}
