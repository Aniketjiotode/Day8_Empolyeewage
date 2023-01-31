using System;

namespace Empolyee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage App");
            Console.WriteLine("Enter Employee Name: ");
            string name = Console.ReadLine();
            Random random = new Random();
            int isPresent = random.Next(0, 2);
            int dayHour = 8;
            int wagePerHour = 20;
            int dailyWage = 0;

            if (isPresent == 0)
            {

                Console.WriteLine(name + " is Absent");
                Console.WriteLine($"Daily Wage = {dailyWage}");
            }
            else
            {
                Console.WriteLine(name + " is Present");
                dailyWage = dayHour * wagePerHour;
                Console.WriteLine($"Daily Wage = {dailyWage}");
            }
        }
    }
}