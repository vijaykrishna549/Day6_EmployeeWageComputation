﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MonthlyWageCalculation
{
    class UC5_20Days
    {

        class UC5_CalculateWagesFor20DaysInMonth
        {
            //Constants
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;
            public const int EMP_RATE_PER_HOUR = 20;
            public const int NUM_OF_WORKING_DAYS = 2;
            public static void CalculateWagesFor20DaysInMonth()
            {

                //variables
                int empHrs = 0;
                int empWage = 0;
                int totalEmpWage = 0;
                for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
                {

                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case IS_PART_TIME:
                            empHrs = 4;
                            break;
                        case IS_FULL_TIME:
                            empHrs = 8;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    empWage = empHrs * EMP_RATE_PER_HOUR;
                    totalEmpWage += empWage;
                    Console.WriteLine("Emp Wage: " + empWage);
                }
                Console.WriteLine("Total Emp Wage: " + totalEmpWage);
            }
        }



    }
}
