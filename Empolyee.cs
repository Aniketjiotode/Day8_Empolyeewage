using System;
using System.Security.Cryptography.X509Certificates;

namespace Empolyee_Wage
{
     public class Empolyee
    {
            int isPresent;
            int dayHour = 8;
            int wagePerHour = 20;
            int partimeHour = 4;
            int dayPerMonth = 20;
            public  int monthlyWage;
            public string name;

        public Empolyee()
        {


            Console.WriteLine("Welcome To Employee Wage App");
            Console.WriteLine("Enter Employee Name: ");
             name = Console.ReadLine();
        }

            public int wage()
            {

                Random random = new Random();
                int totalHour = 0;
                int i = 0;
                while (totalHour <= 100 && i <= dayPerMonth)
                {
                    isPresent = random.Next(0, 3);
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

                    i++;
                }

               return  monthlyWage = totalHour * wagePerHour;
                
            }

        
    }
}