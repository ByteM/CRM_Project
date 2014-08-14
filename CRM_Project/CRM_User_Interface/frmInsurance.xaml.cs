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

namespace CRM_User_Interface
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class frmInsurance : Window
    {
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

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion Event

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
            else if(dtpInsuranceDate.Text == "")
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
