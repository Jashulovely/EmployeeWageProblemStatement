using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class EmployeeWage
    {
        const int wagePerHour = 20, isFullTime = 1, isPartTime = 2, totalWorkingDays = 20;
        int fullDayHour = 0, monthlyWage = 0;

        Random random = new Random();

        public void Attendance()
        {
            for (int day = 1; day <= totalWorkingDays; day++) {
                
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case isFullTime: fullDayHour = 8;
                        Console.WriteLine(" Day {0} :-  Employee is present for Full Time.", day);
                        break;

                    case isPartTime: fullDayHour = 4;
                        Console.WriteLine(" Day {0} :-  Employee is present for Part Time.", day);
                        break;
                    default: fullDayHour = 0;
                        Console.WriteLine(" Day {0} :-  Employee is Abscent.", day);
                        break;
                }
                int empWage = fullDayHour * wagePerHour;
                Console.WriteLine("      Daily wage of Employee is : " + empWage +"/-");
                monthlyWage += empWage;

            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("  Monthly Wages of the Employee is : " + monthlyWage +"/-");
        }
    }
}
