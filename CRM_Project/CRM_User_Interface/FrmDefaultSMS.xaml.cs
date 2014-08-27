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
    /// Interaction logic for FrmDefaultSMS.xaml
    /// </summary>
    public partial class FrmDefaultSMS : Window
    {

        public SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["ConstCRM"].ToString());
        SqlCommand cmd;
        SqlDataReader dr;

        BAL_DefaultSMS bdefaultSMS = new BAL_DefaultSMS();
        DAL_DefaultSMS ddefaultSMS = new DAL_DefaultSMS();

        #region Load Event
        public FrmDefaultSMS()
        {
            InitializeComponent();

            Load_Category();
        }
        #endregion Load Event

        #region Button Event
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Default_Validation();
                return;

                try
                {
                    bdefaultSMS.Flag = 1;
                    bdefaultSMS.SelectCategory = cmbCategory.Text;
                    bdefaultSMS.SMSDate = dtpDate.Text;
                    bdefaultSMS.SMSMessage = txtMessage.Text;
                    bdefaultSMS.S_Sataus = "Active";

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
                    bdefaultSMS.C_Date = System.DateTime.Now.ToShortDateString();
                    //ddefaultSMS.DefaultSMS_Insert_Update_Delete(bdefaultSMS);
                    MessageBox.Show("Data Save Successfully");
                    Clear_ALL();
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

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Clear_ALL();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion Button Event

        public void Load_Category()
        {
            cmbCategory.Text = "Select";
            cmbCategory.Items.Add("Birthday");
            cmbCategory.Items.Add("Balance");
            cmbCategory.Items.Add("Waranty");
            cmbCategory.Items.Add("Insurance");
            cmbCategory.Items.Add("Dealer Follow-up");
            cmbCategory.Items.Add("Customer Follow-up");
        }

        public void Clear_ALL()
        {
            cmbCategory.SelectedItem = "";
            dtpDate.Text = "";
            txtMessage.Text = "";
        }

        public bool Default_Validation()
        {
            bool result = false;
            if(cmbCategory.SelectedItem == "")
            {
                result = true;
                MessageBox.Show("Please Select Category", "Green Future Glob", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if(dtpDate.Text == "")
            {
                result = true;
                MessageBox.Show("Please Select Date", "Green Future Glob", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if(txtMessage.Text == "")
            {
                result = true;
                MessageBox.Show("Please Enter Default Message", "Green Future Glob", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            return result;
        }
    }
}
