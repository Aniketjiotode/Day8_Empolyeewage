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
            int isPresent = random.Next(0, 3);
            int dayHour = 8;
            int wagePerHour = 20;
            int dailyWage = 0;
            int partimeHour = 4;

            if (isPresent == 0)
            {

                Console.WriteLine(name + " is Absent");
                Console.WriteLine($"Daily Wage = {dailyWage}");
            }
            else if (isPresent == 1)
            {
                Console.WriteLine(name + " is Present");
                dailyWage = dayHour * wagePerHour;
                Console.WriteLine($"Daily Wage = {dailyWage}");
            }
            else if (isPresent == 2)
            {
                Console.WriteLine(name + " is Present for half day ");
                dailyWage = partimeHour * wagePerHour;
                Console.WriteLine($"Daily Wage = {dailyWage}");

            }
        }
    }
}