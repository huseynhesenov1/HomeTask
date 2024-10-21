namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                HourlyEmploye hourlyEmploye = new HourlyEmploye();
                //Console.WriteLine(hourlyEmploye.CalculateSalary());
                //Console.WriteLine(hourlyEmploye.MonthlySalary());
                Console.WriteLine("adini daxil ed");
                string name = Console.ReadLine();
                Console.WriteLine("soyadini daxil ed");
                string surname = Console.ReadLine();
                Console.WriteLine("yasini daxil ed");
                string age = Console.ReadLine();
                Console.WriteLine($"{name} {surname} yash {age} ayda :{hourlyEmploye.MonthlySalary()}  gunde:{hourlyEmploye.CalculateSalary()} id:{hourlyEmploye.id} ");
            }
        }
    }
}
