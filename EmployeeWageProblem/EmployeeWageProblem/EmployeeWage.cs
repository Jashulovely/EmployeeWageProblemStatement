﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class EmployeeWage
    {
        public void Attendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0,2);
            if(empCheck == 0)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is abscent");
            }
        }
    }
}
