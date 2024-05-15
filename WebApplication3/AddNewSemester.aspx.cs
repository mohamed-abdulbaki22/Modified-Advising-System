using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AddNewSemester : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void enter_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            if (startDate.Text.Length == 0 || endDate.Text.Length == 0 || semesterCode.Text.Length == 0)
                Label1.Text = "Please enter all inputs";
            else
            {
                DateTime start_Date = DateTime.Parse(startDate.Text);
                DateTime end_Date = DateTime.Parse(endDate.Text);
                String sem_Code = semesterCode.Text;

                conn.Open();

                SqlCommand cmd = new SqlCommand("AdminAddingSemester", conn);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter paramStartDate = new SqlParameter("@start_date", start_Date.Date);
                SqlParameter paramEndDate = new SqlParameter("@end_date", end_Date.Date);

                // Set values for parameters
                paramStartDate.Value = start_Date;
                paramEndDate.Value = end_Date;

                // Add parameters to the SqlCommand
                cmd.Parameters.Add(paramStartDate);
                cmd.Parameters.Add(paramEndDate);

                cmd.Parameters.AddWithValue("@semester_code", sem_Code);

                cmd.ExecuteNonQuery();

                Label1.Text = "added successfully";

                conn.Close();
            }
        }
    }
}