using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class EmployeeWage
    {
        const int wagePerHour = 20, isFullTime = 1, isPartTime = 2, noOfWorkingDays = 20, totalMonthHours = 100;
        int fullDayHour = 0, totalEmployeeWage = 0, totalEmployeeHours = 0, totalWorkingDays = 0;

        Random random = new Random();

        public void Attendance()
        {
            while( totalEmployeeHours <= totalMonthHours && totalWorkingDays < noOfWorkingDays) {

                totalWorkingDays++;
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case isFullTime: fullDayHour = 8;
                        Console.Write(" Employe  present for Full Time and   ");
                        break;

                    case isPartTime: fullDayHour = 4;
                        Console.Write(" Employe  present for Part Time and   ");
                        break;
                    default: fullDayHour = 0;
                        Console.Write(" Employe  is abscent and              ");
                        break;
                }
                
                totalEmployeeHours += fullDayHour;
                Console.WriteLine("Days Employee Worked is : " + totalWorkingDays + " and Total Employee Working Hours is : " + totalEmployeeHours);
                

            }
            totalEmployeeWage = totalEmployeeHours * wagePerHour;
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("  Total Employee Wage is  : " + totalEmployeeWage + "/-");
        }
    }
}
