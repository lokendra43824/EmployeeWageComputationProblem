﻿using EmployeeWage;
using System;
using System.Collections.Generic;

namespace Employee_Wage_calc_Problem
{
    class Program
    {
        //constants

        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;


        static void Main(string[] args)
        {

            //Constants

            const int ADDCompany = 1;
            //const int CALCWage = 2;

            EmpWageBuilder ew = new EmpWageBuilder();

            bool loop = true;

            while (loop)
            {
                Console.WriteLine("1. Add Company and Caluclate Wage\n2.Exit");
                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {

                    case ADDCompany:

                        Company company = ew.AddCompany("Apple", 120, 20, 100);
                        ew.CalculateWage(company);

                        company = ew.AddCompany("Google", 100, 25, 150);
                        ew.CalculateWage(company);
                        break;

                    default:
                        loop = false;
                        break;
                }

                Console.Out.WriteLine("\n**************************************\n");

            }

        }
    }
}