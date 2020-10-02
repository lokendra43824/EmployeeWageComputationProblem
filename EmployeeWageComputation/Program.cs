using EmployeeWage;
using System;
using System.Collections.Generic;

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
namespace EmployeeWage
=======
namespace Employee_Wage_calc_Problem
>>>>>>> uc-13-store-the-daily-wage
=======
namespace Employee_Wage_calc_Problem
>>>>>>> uc-11-manage-employee-wage-using-api-approach
=======
namespace Employee_Wage_calc_Problem
>>>>>>> uc-12-Add-list-of-multiple-companies-to-manage-employee-wage
=======
namespace Employee_Wage_calc_Problem
>>>>>>> uc-14-company-wise-total-wage
{
    class Program
    {
        //constants
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int TOTAL_WORKING_HOURS = 100;
        const int TOTAL_WORKING_DAYS = 20;
        const int WAGE_PER_HOUR = 20;


        public static int CalculateWage()
        {
            //variable
=======
=======
>>>>>>> uc-11-manage-employee-wage-using-api-approach
=======
>>>>>>> uc-12-Add-list-of-multiple-companies-to-manage-employee-wage

        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;


        static void Main(string[] args)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            //Variables
            Double empRatePerHour = 0;
            Double workingHrs = 0;
            Double numOfWorkingDays = 0;

            Random random = new Random();
            int empType = random.Next(1, 3);

            switch (empType)
            {
                case IS_FULL_TIME:

                    empRatePerHour = 120;
                    workingHrs = 8;
                    numOfWorkingDays = 20;
>>>>>>> uc-13-store-the-daily-wage

                    Console.WriteLine("Full Time Employee Details in following companies");
                    break;

                case IS_PART_TIME:

<<<<<<< HEAD
            while (numberOfHours <= TOTAL_WORKING_HOURS && workingDays <= TOTAL_WORKING_DAYS)
            {
                Random rand = new Random();
                int type = rand.Next(0, 3);
                int hours = 0;
                switch (type)
=======

            //Constants

            const int ADDCompany = 1;
            //const int CALCWage = 2;

            EmpWageBuilder ew = new EmpWageBuilder();

            bool loop = true;

            while (loop)
            {
=======

            //Constants

            const int ADDCompany = 1;
            //const int CALCWage = 2;

            EmpWageBuilder ew = new EmpWageBuilder();

            bool loop = true;

            while (loop)
            {
>>>>>>> uc-12-Add-list-of-multiple-companies-to-manage-employee-wage
                Console.WriteLine("1. Add Company and Caluclate Wage\n2.Exit");
                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
<<<<<<< HEAD
>>>>>>> uc-11-manage-employee-wage-using-api-approach
=======
>>>>>>> uc-12-Add-list-of-multiple-companies-to-manage-employee-wage
=======

        static void Main(string[] args)
        {

            //Constants

            const int ADDCompany = 1;
            const int GetCompWage = 2;

            EmpWageBuilder ew = new EmpWageBuilder();

            bool loop = true;

            while (loop)
            {
                Console.WriteLine("1. Add Company and Caluclate Wage\n2.Get total monthly wage of a company \n3.Exit");
                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
>>>>>>> uc-14-company-wise-total-wage
                {

                    case ADDCompany:

<<<<<<< HEAD
<<<<<<< HEAD
                        Random random = new Random();
                        int empType = random.Next(1, 3);


=======
>>>>>>> uc-12-Add-list-of-multiple-companies-to-manage-employee-wage
=======
>>>>>>> uc-14-company-wise-total-wage
                        Company company = ew.AddCompany("Apple", 120, 20, 100);
                        ew.CalculateWage(company);

                        company = ew.AddCompany("Google", 100, 25, 150);
                        ew.CalculateWage(company);
<<<<<<< HEAD
=======
                        break;
                    case GetCompWage:

                        Console.Out.WriteLine("Enter the company to get total wage");
                        String name = Console.ReadLine();
                        double monthlyWage = ew.GetTotalWage(name);
                        if (monthlyWage > 0)
                        {
                            Console.Out.WriteLine(name + "'s Monthly total wage is: " + monthlyWage);
                        }
                        else
                        {
                            Console.Out.WriteLine("Invalid Company Name");
                        }
>>>>>>> uc-14-company-wise-total-wage
                        break;

                    default:
                        loop = false;
                        break;
                }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                numberOfHours += hours;

                Console.Out.WriteLine("Day " + workingDays + " hours " + hours);

                workingDays++;
=======
                    empRatePerHour = 80;
                    workingHrs = 5;
                    numOfWorkingDays = 20;
                    Console.WriteLine("Part Time Employee Details in following companies");
                    break;

                default:
                    break;
>>>>>>> uc-13-store-the-daily-wage
            }

            EmpWageBuilder apple = new EmpWageBuilder();
            apple.addCompanyWage("Apple", empRatePerHour, numOfWorkingDays, workingHrs);
            Console.WriteLine("Total wage in Apple: " + apple.getTotalWage("Apple"));

<<<<<<< HEAD
            return total_wage;
        }

        static void Main(string[] args)
        {
            int total_wage = CalculateWage();
            Console.Out.WriteLine("Total wage of the month :" + total_wage);
=======
            EmpWageBuilder google = new EmpWageBuilder();
            google.addCompanyWage("Google", empRatePerHour, numOfWorkingDays, workingHrs);
            Console.WriteLine("Total wage in google : " + google.getTotalWage("Google"));
>>>>>>> uc-13-store-the-daily-wage
=======
                Console.Out.WriteLine("\n**************************************\n");

            }


>>>>>>> uc-11-manage-employee-wage-using-api-approach

=======
                Console.Out.WriteLine("\n**************************************\n");

            }

>>>>>>> uc-12-Add-list-of-multiple-companies-to-manage-employee-wage
=======
                Console.Out.WriteLine("\n**************************************\n");

            }



>>>>>>> uc-14-company-wise-total-wage
        }
    }
}