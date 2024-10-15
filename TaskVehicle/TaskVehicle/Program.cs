namespace TaskVehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", "F30", 2, 50);
            Vehicle vehicle = new Vehicle(2005);

            Console.WriteLine($"Current fuel after driving: {car.Drive()} liters");
        }
    }

    public class Vehicle
    {
        public string name;
        public string color;
        public int year;
        public Vehicle(int year)
        {
            this.year = year;
        }
    }


    public class Car
    {
        public string brand;
        public string model;
        public int fuelCapacity;
        public int fuelfor1km;
        public int currentFuel;

        public Car(string brand, string model, int fuelfor1km, int fuelCapacity)
        {
            this.brand = brand;
            this.model = model;
            this.fuelfor1km = fuelfor1km;
            this.fuelCapacity = fuelCapacity;
            this.currentFuel = fuelCapacity; 
        }

        public int Drive(int distance=2)
        {
            

            return fuelCapacity - distance * fuelfor1km;

        }
    }
}
