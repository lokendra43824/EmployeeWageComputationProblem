using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class Company
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        String company;
        Double empRatePerHour;
        Double numOfWorkingDays;
        Double workingHrs;
        Double salary;
        public Company(String company, Double empRatePerHour, Double numOfWorkingDays, Double workingHrs)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.workingHrs = workingHrs;
        }
        public void setSalary(Double salary)
        {
            this.salary = salary;
        }

        public double getSalary()
        {
            return this.salary;
        }
    }
}
=======
=======
>>>>>>> uc-12-Add-list-of-multiple-companies-to-manage-employee-wage
        //getters and setters for the instance variables

=======
        //getters and setters for the instance variables

        //List to store Daoly wage
        public List<Double> DailyWage = new List<double>();

>>>>>>> uc-14-company-wise-total-wage
        public String CompName { get; set; }
        public double WagePerHour { get; set; }
        public int TotalWorkingDays { get; set; }
        public int TotalWorkingHours { get; set; }

        public double MonthlyTotalWage { get; set; }


        //company constructor
        public Company(String compName, double wagePerHour, int totalWorkingDays, int totalWorkingHours)
        {
            this.CompName = compName;
            this.WagePerHour = wagePerHour;
            this.TotalWorkingDays = totalWorkingDays;
            this.TotalWorkingHours = totalWorkingHours;
            this.MonthlyTotalWage = 0;

            Console.WriteLine("\nCompany " + this.CompName + " Created\n");

        }
    }
<<<<<<< HEAD
}
<<<<<<< HEAD
>>>>>>> uc-11-manage-employee-wage-using-api-approach
=======
>>>>>>> uc-12-Add-list-of-multiple-companies-to-manage-employee-wage
=======
}
>>>>>>> uc-14-company-wise-total-wage
