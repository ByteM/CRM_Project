using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CRM_BAL;

namespace CRM_DAL
{
    public class DAL_DefaultSMS
    {
        public SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["ConstCRM"].ToString());
        SqlCommand cmd;

        public int DefaultSMS_Insert_Update_Delete(BAL_DefaultMessage bb)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("SP_DefaultSMS", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", 1);
                cmd.Parameters.AddWithValue("@SelectCategory", bb.SelectCategory);
                cmd.Parameters.AddWithValue("@SMSDate", bb.SMSDate);
                cmd.Parameters.AddWithValue("@SMSMessage", bb.SMSMessage);
                cmd.Parameters.AddWithValue("@S_Status", bb.S_Sataus);
                cmd.Parameters.AddWithValue("@C_Date", bb.C_Date);
                int i = cmd.ExecuteNonQuery();
                return i;
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
    }
}
