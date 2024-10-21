using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract;

internal class HourlyEmploye : Employee
{
    public override double CalculateSalary()
    {
        double slry = HourlyRate * HoursWorked;
        return slry;
    }
    public void DisplayDetails()
    {
            //Console.WriteLine($"{name} {surname} yash {age} ayda :{MonthlySalary()}  gunde:{CalculateSalary()} id:{id}  ");

    }
    public double HourlyRate { get; set; } = 5; //saatliq qazanc
    public double HoursWorked { get; set; } = 3; //ayliq calisdiqi saat

}