using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1;

namespace WebApplication3
{
    public partial class advisor_signUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectString = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            SqlConnection conn1 = new SqlConnection(connectString);

            
            if (string.IsNullOrWhiteSpace(advisor_name.Text) || string.IsNullOrWhiteSpace(password.Text)
                || string.IsNullOrWhiteSpace(email.Text) || string.IsNullOrWhiteSpace(office.Text))
            {
                Response.Write("all fields are required");
                return;
            }
            string advisorName = advisor_name.Text;
            string pass = password.Text;
            string Email = email.Text;
            string Office = office.Text;

            // SqlCommand to call the stored procedure
            SqlCommand registerProc = new SqlCommand("Procedures_AdvisorRegistration", conn1);
            registerProc.CommandType = CommandType.StoredProcedure;


            // Set parameters
            registerProc.Parameters.Add(new SqlParameter("@advisor_name", SqlDbType.VarChar, 40)).Value = advisorName;
            registerProc.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar, 40)).Value = pass;
            registerProc.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar, 40)).Value = Email;
            registerProc.Parameters.Add(new SqlParameter("@office", SqlDbType.VarChar, 40)).Value = Office;

    
 

            SqlParameter id = registerProc.Parameters.Add("@Advisor_id", SqlDbType.Int);
            id.Direction = ParameterDirection.Output;

            // Open connection, execute stored procedure, and close connection
            conn1.Open();
            int i = registerProc.ExecuteNonQuery();
            conn1.Close();

            // Access the output parameter value
            if (i > 0)
            {
                int AdvisorId = Convert.ToInt32(id.Value);
                Response.Write("Advisor ID: " + AdvisorId);
                //logged.Visible = true;
            }
            else
            {
                Response.Write("error");
            }
        }
    }
}