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
            int partimeHour = 4;
            int dayPerMonth = 20;
            int totalHour = 0;


            for (int i = 0; i < dayPerMonth; i++)
            {

                switch (isPresent)
                {
                    case 0:
                        totalHour += 0;
                        break;


                    case 1:
                        totalHour += dayHour;
                        break;


                    case 2:
                        totalHour += partimeHour;
                        break;

                }

            }

            int monthlyWage = totalHour * wagePerHour;
            Console.WriteLine($"{name} Monthly wage= {monthlyWage}");




        }
    }
}