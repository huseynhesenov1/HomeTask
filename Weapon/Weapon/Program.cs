namespace Weapon;

internal class Program
{
    static void Main(string[] args)
    {
        int capacityMag;
        while (true)
        {
        Console.WriteLine("Enter the capacity of the magazine");
        capacityMag =int.Parse(Console.ReadLine());
            if (capacityMag>0)
            {
                break;
            }
            else
            {
                Console.WriteLine("The capacity of the magazine cannot be negative");
            }
        }

        int bulletinMag;
        while (true)
        {
        Console.WriteLine("Enter the number of bullets in the magazine:");
        bulletinMag = int.Parse(Console.ReadLine());
            if (bulletinMag<=capacityMag && bulletinMag>0)
            {
                break;
            }
            else if(bulletinMag > capacityMag)
            {
                Console.WriteLine("The number of bullets cannot exceed the capacity of the magazine, re-enter.");
            }
            else
            {
                Console.WriteLine("The number of bullets cannot be negative");
            }

        }


        string fireMode;
        while (true)
        {
        Console.WriteLine("Enter fire mode: (single/automatic)");
        fireMode = Console.ReadLine();
            if (fireMode=="single" || fireMode=="automatic")
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter the correct information: (single/automatic) ");
            }

        }




        Console.WriteLine("Choose an item between 0-6");

        string res = "0 - İnformasiya almaq üçün\r\n1 - Shoot metodu üçün\r\n2 - Fire metodu üçün\r\n3 - GetRemainBulletCount metodu üçün\r\n4 - Reload metodu üçün\r\n5 - ChangeFireMode metodu üçün\r\n6 - Proqramdan dayandırmaq üçün\r\nqısayoldur.";
        Console.WriteLine(res);
        Weapon weapon = new Weapon( capacityMag, bulletinMag, fireMode);
        bool running = true;
        while (running)
        {
            string num = Console.ReadLine();
            switch (num) { 

                case "0":

                    Console.WriteLine($"Magazine's maximum bullet capacity {weapon.capacityMag}");
                    Console.WriteLine($"The number of bullets in the magazine: {weapon.bulletinMag} ");
                    Console.WriteLine($"Atish modu {weapon.fireMode}");

                    break;
                case "1":
                    weapon.Shoot();
                    break;
                case "2":
                    weapon.Fire();
                    break;
                case "3":
                    weapon.GetRemainBulletCount();
                    break;
                case "4":
                    weapon.Reload();
                    break;
                case "5":
                    weapon.ChangeFireMode();
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("The program has been stopped");
                    break;
                default:
                    Console.WriteLine("Choose an item between 0-6");
                    break;


            }
        }

    }
}

