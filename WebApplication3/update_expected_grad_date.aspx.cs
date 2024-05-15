using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class update_expected_grad_date : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (exp_grad_date.Text.Length == 0 || studentID.Text.Length == 0)
                Response.Write("There is a missing input");
            else
            {
                try
                {
                    string connStr = WebConfigurationManager.ConnectionStrings["Web"].ToString();
                    //create a new connection
                    SqlConnection conn = new SqlConnection(connStr);



                    DateTime expected_GradDate = DateTime.Parse(exp_grad_date.Text);
                    int stID = Int16.Parse(studentID.Text);


                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Procedures_AdvisorUpdateGP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;


                    SqlParameter paramexpected_GradDate = new SqlParameter("@expected_grad_date", expected_GradDate.Date);


                    // Set values for parameters
                    paramexpected_GradDate.Value = expected_GradDate;


                    // Add parameters to the SqlCommand






                    cmd.Parameters.AddWithValue("@studentID", stID);
                    cmd.Parameters.Add(paramexpected_GradDate);



                    Response.Write("updated succssefully");
                    cmd.ExecuteNonQuery();






                    conn.Close();
                }
                catch (System.FormatException ex)
                {
                    Response.Write("Graduation date should be a date and student id should be an integer");
                }
            }
        }
    }
}