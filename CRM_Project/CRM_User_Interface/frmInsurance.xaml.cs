using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CRM_BAL;
using CRM_DAL;

namespace CRM_User_Interface
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class frmInsurance : Window
    {

        public SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["ConstCRM"].ToString());
        SqlCommand cmd;
        SqlDataReader dr;
        string caption = "Green Future Glob";
        static int PK_ID;

        BAL_InsuranceEntry binsuranceEntry = new BAL_InsuranceEntry();
        DAL_InsuranceEntry dinsuranceEntry = new DAL_InsuranceEntry();

        public frmInsurance()
        {
            InitializeComponent();
            LoadYearsMonth();
            LoadInterval();
        }

        #region Button Event
        private void btnInExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string FPInsurance;
                string SET_YEAR;

                binsuranceEntry.Flag = 1;
                binsuranceEntry.CustomerID = Convert.ToInt32(txtCustomerID.Text);
                binsuranceEntry.InsuranceNo = lblInsuranceNo.Content.ToString();
                binsuranceEntry.ProductName = lblProductName.Content.ToString();
                binsuranceEntry.IntervalAmount = Convert.ToDouble(txtInsuranceAmt.Text);
                binsuranceEntry.BankName = cmbBankIntegration.Text;
                binsuranceEntry.InsuranceDate = Convert.ToDateTime(dtpDate.SelectedDate);
                binsuranceEntry.NoOfYearsMonths = Convert.ToInt32(txtValidity.Text);
                binsuranceEntry.NoOfMonth = Convert.ToInt32(txtMonths.Text);
                binsuranceEntry.YearsMonth = cmbValidity.Text;
                binsuranceEntry.IntervalMonth = Convert.ToInt32(txtInterval.Text);
                binsuranceEntry.IntervalMonthY = cmbInterval.Text;
                binsuranceEntry.IntervalAmount = Convert.ToDouble(txtIntervalTotalAmt.Text);

                string STRTODAYDATE = Convert.ToString(dtpDate.SelectedDate);
                string time = Convert.ToString(dtpDate.SelectedDate);
                string[] STRVAL = STRTODAYDATE.Split('-');
                string STR_DATE1 = STRVAL[0];
                string STR_MONTH = STRVAL[1];
                string STR_YEAR = STRVAL[2];
                if(cmbValidity.SelectedItem.Equals("Year"))
                {
                    string vlYear,vlNo,addNY;
                    vlYear = Convert.ToString(STR_YEAR);
                    vlNo = Convert.ToString(txtValidity.Text);
                    addNY = vlYear + vlNo;
                    SET_YEAR = Convert.ToString(addNY);
                }
                SET_YEAR = STRVAL[3];
                string DATE = STR_DATE1 + "-" + STR_MONTH + "-" + SET_YEAR;
                dtpInstallmentDate.Text = DATE;

                DateTime dt = Convert.ToDateTime(dtpInstallmentDate.SelectedDate);
                ////txttime.Text = time;

                //baddprd.C_Date =Convert .ToDateTime( DATE);

                binsuranceEntry.NewInsuranceDate = Convert.ToDateTime(dt);
                if(chbInsurance.IsChecked == true)
                {
                    FPInsurance = "Yes";
                }
                else
                {
                    FPInsurance = "No";
                }
                binsuranceEntry.FirstPartyInsurance = FPInsurance;
                binsuranceEntry.IsClear = "Active";
                binsuranceEntry.S_Status = "Active";
                binsuranceEntry.C_Date = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());

                //string STRTODAYDATE = System.DateTime.Now.ToShortDateString();
                //string time = System.DateTime.Now.ToShortTimeString();
                //string[] STRVAL = STRTODAYDATE.Split('-');
                //string STR_DATE1 = STRVAL[0];
                //string STR_MONTH = STRVAL[1];
                //string STR_YEAR = STRVAL[2];
                //string DATE = STR_DATE1 + "-" + STR_MONTH + "-" + STR_YEAR;
                ////txtdate.Text = DATE;
                ////txttime.Text = time;

                //baddprd.C_Date =Convert .ToDateTime( DATE);

                MessageBox.Show("Data Save Successfully", caption, MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion Event

        #region Insurance Function
        public void InsuranceID(string iid)
        {
            txtInsuranceID.Text = iid;
        }

        public void LoadYearsMonth()
        {
            cmbValidity.Text = "Select";
            cmbValidity.Items.Add("Year");
            cmbValidity.Items.Add("Month");
        }

        public void LoadInterval()
        {
            cmbInterval.Text = "Select";
            cmbInterval.Items.Add("Year");
            cmbInterval.Items.Add("Month");
        }

        public void SelectYearMonth()
        {
            if(cmbValidity.SelectedItem == "Year")
            {
                if(txtValidity.Text == "1")
                {
                    txtMonths.Text = "12";
                }
                else if(txtValidity.Text == "2")
                {
                    txtMonths.Text = "24";
                }
                else if(txtValidity.Text == "3")
                {
                    txtMonths.Text = "36";
                }
                if (txtValidity.Text == "4")
                {
                    txtMonths.Text = "48";
                }
                else if (txtValidity.Text == "5")
                {
                    txtMonths.Text = "60";
                }
                else if (txtValidity.Text == "6")
                {
                    txtMonths.Text = "72";
                }
                if (txtValidity.Text == "7")
                {
                    txtMonths.Text = "84";
                }
                else if (txtValidity.Text == "8")
                {
                    txtMonths.Text = "96";
                }
                else if (txtValidity.Text == "9")
                {
                    txtMonths.Text = "108";
                }
                if (txtValidity.Text == "10")
                {
                    txtMonths.Text = "120";
                }
                else if (txtValidity.Text == "11")
                {
                    txtMonths.Text = "132";
                }
                else if (txtValidity.Text == "12")
                {
                    txtMonths.Text = "144";
                }
                else if (txtValidity.Text == "13")
                {
                    txtMonths.Text = "156";
                }
                else if (txtValidity.Text == "14")
                {
                    txtMonths.Text = "168";
                }
                else if (txtValidity.Text == "15")
                {
                    txtMonths.Text = "180";
                }
                if (txtValidity.Text == "16")
                {
                    txtMonths.Text = "192";
                }
                else if (txtValidity.Text == "17")
                {
                    txtMonths.Text = "204";
                }
                else if (txtValidity.Text == "18")
                {
                    txtMonths.Text = "216";
                }
                else if (txtValidity.Text == "19")
                {
                    txtMonths.Text = "228";
                }
                else if (txtValidity.Text == "20")
                {
                    txtMonths.Text = "240";
                }
            }
            if (cmbValidity.SelectedItem == "Month")
            {
                if (txtValidity.Text == "1")
                {
                    txtMonths.Text = "1";
                }
                else if (txtValidity.Text == "2")
                {
                    txtMonths.Text = "2";
                }
                else if (txtValidity.Text == "3")
                {
                    txtMonths.Text = "3";
                }
                if (txtValidity.Text == "4")
                {
                    txtMonths.Text = "4";
                }
                else if (txtValidity.Text == "5")
                {
                    txtMonths.Text = "5";
                }
                else if (txtValidity.Text == "6")
                {
                    txtMonths.Text = "6";
                }
                if (txtValidity.Text == "7")
                {
                    txtMonths.Text = "7";
                }
                else if (txtValidity.Text == "8")
                {
                    txtMonths.Text = "8";
                }
                else if (txtValidity.Text == "9")
                {
                    txtMonths.Text = "9";
                }
                if (txtValidity.Text == "10")
                {
                    txtMonths.Text = "10";
                }
                else if (txtValidity.Text == "11")
                {
                    txtMonths.Text = "11";
                }
            }
        }

        public bool Insurance_Validation()
        {
            bool result = false;
            if(txtInsuranceAmt.Text == "")
            {
                result = true;
                MessageBox.Show("Please Enter Insurance Amount", "Green Future Glob", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
            else if(cmbBankIntegration.SelectedItem == null)
            {
                result = true;
                MessageBox.Show("Please Select Bank Name", "Green Future Glob", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
            else if(dtpDate.Text == "")
            {
                result = true;
                MessageBox.Show("Please Select Date", "Green Future Glob", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
            else if((txtValidity.Text == "") || (cmbValidity.SelectedItem == null))
            {
                result = true;
                MessageBox.Show("Please Select Validity", "Green Future Glob", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
            else if((txtInterval.Text == "") || (cmbInterval.SelectedItem == null))
            {
                result = true;
                MessageBox.Show("Please Enetr Interval", "Green Future Glob", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
            return result;
        }

        public void Insurance_FillData()
        {
            try
            {
                con.Open();
                string sqlquery = "SELECT I.[ID],I.[Customer_ID],I.[Domain_ID],I.[Product_ID],I.[Brand_ID],I.[P_Category],I.[Model_No_ID],I.[Color_ID] " + 
                                  ",PM.[Product_Name] + ' , ' + B.[Brand_Name] + ' , ' + PC.[Product_Category] + ' , ' + MN.[Model_No] + ' , ' + C.[Color] AS [Products]" +
                                  ",M.[Name],M.[Mobile_No],M.[Email_ID] " +
                                  "FROM [tlb_InvoiceDetails] I " +
                                  "INNER JOIN [tb_Domain] DM ON DM.[ID]=I.[Domain_ID] " +
                                  "INNER JOIN [tlb_Products] PM ON PM.[ID]=I.[Product_ID] " +
                                  "INNER JOIN [tlb_Brand] B ON B.[ID]=I.[Brand_ID] " +
                                  "INNER JOIN [tlb_P_Category] PC ON PC.[ID]=I.[P_Category]" +
                                  "INNER JOIN [tlb_Model] MN ON MN.[ID]=I.[Model_No_ID] " +
                                  "INNER JOIN [tlb_Color] C ON C.[ID]=I.[Color_ID] " +
                                  "INNER JOIN [tlb_Customer] M ON M.[ID]=I.[Customer_ID] " +
                                  "where I.[ID]='" + txtInsuranceID.Text + "' ";
                SqlCommand cmd = new SqlCommand(sqlquery, con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtCustomerID.Text = dt.Rows[0]["Customer_ID"].ToString();
                    lblCustomerName.Content = dt.Rows[0]["Name"].ToString();
                    lblMobileNo.Content = dt.Rows[0]["Mobile_No"].ToString();
                    lblEmailID.Content = dt.Rows[0]["Email_ID"].ToString();
                    lblProductName.Content = dt.Rows[0]["Products"].ToString();
                    
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        
        public void Cal_InstallmentMonth()
        {
            double insAmt,intMonth,intervalAmt,month, monthAmt;
            try
            {
                insAmt = Convert.ToDouble(txtInsuranceAmt.Text);
                intMonth = Convert.ToDouble(txtInterval.Text);
                month = Convert.ToDouble(txtMonths.Text);
                monthAmt = insAmt / month;
                intervalAmt = monthAmt * intMonth;
                txtIntervalTotalAmt.Text = (Microsoft.VisualBasic.Strings.Format(intervalAmt, "##,###.00"));
            }
            catch(Exception)
            {
                throw;
            }
        }

        //string STRTODAYDATE = System.DateTime.Now.ToShortDateString();
        //string time = System.DateTime.Now.ToShortTimeString();
        //string[] STRVAL = STRTODAYDATE.Split('-');
        //string STR_DATE1 = STRVAL[0];
        //string STR_MONTH = STRVAL[1];
        //string STR_YEAR = STRVAL[2];
        //string DATE = STR_DATE1 + "-" + STR_MONTH + "-" + STR_YEAR;
        ////txtdate.Text = DATE;
        ////txttime.Text = time;

        //baddprd.C_Date =Convert .ToDateTime( DATE);
        #endregion Insurance Function
        private void cmbInterval_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cal_InstallmentMonth();
        }

        private void cmbValidity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectYearMonth();
        }

        private void txtInterval_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        public void CalcDayMonthYear()
        {
            DateTime dayStart;
            DateTime dateEnd;

            dayStart = Convert.ToDateTime(dtpDate.Text);
            dateEnd = Convert.ToDateTime(dtpInstallmentDate.Text);
            TimeSpan ts = dateEnd - dayStart;

            double Years = Convert.ToDouble(ts.TotalDays) / 365;
            double Months = Years * 12;
            double Days = Convert.ToDouble(ts.TotalDays); 

        }
    }
}
