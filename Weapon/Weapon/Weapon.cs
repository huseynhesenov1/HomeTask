namespace Weapon;

public class Weapon
{
    public int capacityMag { get; set; }
    public int bulletinMag {
        get;
        set;
    }
    public string fireMode { get; set; }    
    
    

    public Weapon(int capacityMag, int bulletinMag, string fireMode)
    {
        this.capacityMag = capacityMag;
        this.bulletinMag = bulletinMag;
        this.fireMode = fireMode;
    }

    public void Shoot()
    {
        if (bulletinMag > 0)
        {

            bulletinMag-=1;
            Console.WriteLine($"Fired, {bulletinMag} bullets left ");
        }
        else
        {
            Console.WriteLine("The magazine is empty.");
        }

    }
    public void Fire()
    {
        if (fireMode=="single")
        {
            Shoot();
            Console.WriteLine("Since it's in single mode, it fires one shot at a time. Switch the mode to fire automatic.");
        }
        else
        {
            if (bulletinMag > 0)
            {
                DateTime strart = DateTime.Now;
                while (bulletinMag > 0)
                {
                    Shoot();
                }
                DateTime end = DateTime.Now;
                TimeSpan duration = end - strart;
                Console.WriteLine($"All the bullets in the magazine have been fired : {duration}");
            }
            else
            {
                Console.WriteLine("The magazine is empty.");
            }
        }
    }
    public void GetRemainBulletCount()
    {
        int needBullet = capacityMag - bulletinMag;
        Console.WriteLine($"{needBullet} bullets are needed to fully load the magazine");

    }
    public void Reload()
    {
        bulletinMag = capacityMag;
        Console.WriteLine($"The magazine has been reloaded, the number of bullets in the magazine:{bulletinMag} ");
    }
    public void ChangeFireMode()
    {
        if (fireMode == "single")
        {
            fireMode = "automatic";
        }
        else
        {
            fireMode = "single";
        }
        Console.WriteLine($"The firing mode has been changed, fire mode:{fireMode}");
    }

}

