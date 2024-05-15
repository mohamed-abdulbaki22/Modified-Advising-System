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
    public partial class insert_grad_plan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            if (semester_code.Text.Length==0 || TextBox1.Text.Length == 0 || TextBox2.Text.Length == 0 || TextBox3.Text.Length == 0 || TextBox4.Text.Length == 0)
                Response.Write("There is a missing input");
            else
            {
                try
                {
                    string connStr = WebConfigurationManager.ConnectionStrings["Web"].ToString();
                    //create a new connection
                    SqlConnection conn = new SqlConnection(connStr);
                    String sem_code = semester_code.Text;
                    DateTime expected_GradDate = DateTime.Parse(TextBox1.Text);
                    int sem_credit_hours = Int16.Parse(TextBox2.Text);
                    int advisor_id = Int16.Parse(TextBox3.Text);
                    int student_id = Int16.Parse(TextBox4.Text);

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Procedures_AdvisorCreateGP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;


                    SqlParameter paramexpected_GradDate = new SqlParameter("@expected_graduation_date", expected_GradDate.Date);


                    // Set values for parameters
                    paramexpected_GradDate.Value = expected_GradDate;


                    // Add parameters to the SqlCommand






                    cmd.Parameters.AddWithValue("@Semester_code", sem_code);
                    cmd.Parameters.Add(paramexpected_GradDate);
                    cmd.Parameters.AddWithValue("@sem_credit_hours", sem_credit_hours);
                    cmd.Parameters.AddWithValue("@advisor_id", advisor_id);
                    cmd.Parameters.AddWithValue("@student_id", student_id);


                    Response.Write("Added succssefully");
                    cmd.ExecuteNonQuery();






                    conn.Close();
                }
                catch (System.FormatException ex)
                {
                    Response.Write("Graduation date should be a date and all other inputs should be integers");
                }
            }
        }
    }
}