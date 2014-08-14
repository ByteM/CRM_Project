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
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
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
    }
}
