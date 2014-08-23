using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CRM_BAL
{
    public class BAL_InsuranceEntry
    {
        public int Flag { get; set; }

        public int CustomerID { get; set; }

        public string InsuranceNo { get; set; }

        public string ProductName { get; set; }

        public double InsuranceAmt { get; set; }

        public String BankName { get; set; }

        public DateTime InsuranceDate { get; set; }

        public int NoOfYearsMonths { get; set; }

        public int NoOfMonth { get; set; }

        public string YearsMonth { get; set; }

        public int IntervalMonth { get; set; }

        public string IntervalMonthY { get; set; }

        public double IntervalAmount { get; set; }

        public DateTime NewInsuranceDate { get; set; }

        public string FirstPartyInsurance { get; set; }

        public string IsClear { get; set; }

        public string S_Status { get; set; }

        public DateTime C_Date { get; set; }

    }
}
