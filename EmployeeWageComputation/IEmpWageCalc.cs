using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    interface IEmpWageCal
    {
        Company AddCompany(String company, Double empRatePerHour, int numOfWorkingDays, int workingHrs);

<<<<<<< HEAD
        // Double getTotalWage(string company);

    }
<<<<<<< HEAD
}
=======
}
>>>>>>> uc-12-Add-list-of-multiple-companies-to-manage-employee-wage
=======
        Double GetTotalWage(String companyName);

    }
}
>>>>>>> uc-14-company-wise-total-wage
