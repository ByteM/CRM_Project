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
using System.Globalization;
using System.ComponentModel;
using CRM_User_Interface.Add_Product;
using System.Windows.Controls.DataVisualization.Charting;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Win32;
using CRM_BAL;
using CRM_DAL;


namespace CRM_User_Interface
{
    /// <summary>
    /// Interaction logic for frmCustomerBirthdayAlert.xaml
    /// </summary>
    public partial class frmCustomerBirthdayAlert : Window
    {
       public  string cid_CAB="", cname_CAB="", cphone_CAB="", cdob_CAB="";
        public frmCustomerBirthdayAlert()
        {
            InitializeComponent();
        }

        private void btncustomerBirthdayExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            //frmCustomerBirthdayAlert cba = new frmCustomerBirthdayAlert();
            //cba.Close();
        }

        private void btnCBA_Send_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
