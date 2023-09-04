using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class EmployeeWage
    {
        const int wagePerHour = 20, isFullTime = 1, isPartTime = 2;
        int fullDayHour = 0;

        public void Attendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0,3);

            switch (empCheck)
            {
                case isFullTime: fullDayHour = 8;
                    Console.WriteLine("Employee is present for Full Time.");
                    break;

                case isPartTime: fullDayHour = 4;
                    Console.WriteLine("Employee is present for Part Time.");
                    break;
                default: fullDayHour = 0;
                    Console.WriteLine("Employee is Abscent.");
                    break;
            }
            int  empWage = fullDayHour * wagePerHour;
            Console.WriteLine("Daily wage of Employee is : " + empWage);
        }
    }
}
