﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CRM_BAL
{
    public class BAL_DefaultSMS
    {
        public int Flag { get; set; }

        public string SelectCategory { get; set; }

        public string SMSDate { get; set; }

        public string SMSMessage { get; set; }

        public string S_Sataus { get; set; }

        public string C_Date { get; set; }
    }
}
