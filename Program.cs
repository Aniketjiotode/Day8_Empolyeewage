using System;

namespace Empolyee_Wage
{
    public class Program
    {
                     
        static void Main(string[] args)
        {
           
            Empolyee EmpolyeeSalary = new Empolyee();
            Console.WriteLine($"{EmpolyeeSalary.name} Monthly wage = {EmpolyeeSalary.wage()}");

        }
    }
}