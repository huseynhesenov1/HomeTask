namespace ConsoleApp6;

internal class Program
{
    static void Main(string[] args)
    {
        Animal animal = null;
        Console.WriteLine("Select the animal type: Dog, Bear, Bird");
        string AnimalType= Console.ReadLine();
        if (AnimalType == "dog")
        {
            Dog dog = new Dog();
            Console.Write("Enter the dog's name: ");
            dog.name = Console.ReadLine();
            Console.Write("Enter the dog's age: ");
            dog.age = int.Parse(Console.ReadLine());
            Console.Write("Does the dog have a tail? (true/false): ");
            dog.IsTail = bool.Parse(Console.ReadLine());
            dog.Bark();
            animal = dog;

        }
        else if (AnimalType == "bear")
        {
            Bear bear = new Bear();
            Console.Write("Enter the Bear's name: ");
            bear.name = Console.ReadLine();
            Console.Write("Enter the Bear's age: ");
            bear.age = int.Parse(Console.ReadLine());
            Console.Write("Is the Bear wild? (true/false): ");
            bear.IsWild = bool.Parse(Console.ReadLine());
            animal = bear;
               
        }
        else if(AnimalType == "bird")
        {
            Bird bird = new Bird();
            Console.Write("Enter the Bird's name: ");
            bird.name = Console.ReadLine();
            Console.Write("Enter the Bird's age: ");
            bird.age = int.Parse(Console.ReadLine());
            Console.Write("Can a bird fly? (true/false): ");
            bird.CanSwim = bool.Parse(Console.ReadLine());
            bird.Fly();
            animal= bird;
        }
        else
        {
            Console.WriteLine("This animal breed is not available. Please to choose between Dog, Bear or Bird.");
            return;

        }
        Console.WriteLine($"\nAnimal name: {animal.name}");
        Console.WriteLine($"Animal age: {animal.age}");
        animal.Eat();
    }

}
