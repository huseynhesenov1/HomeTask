using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract;

internal abstract class Employee
{
    private static int _id;
    public int id
    {
        get
        {
            return _id;
        }
    }
    public string name { get; set; }
    public string surname { get; set; }
    public int age { get; set; }
    protected Employee()
    {
        ++_id;
    }
    public abstract double CalculateSalary();
    public double MonthlySalary()
    {
        return CalculateSalary() * 30;
    }


}
