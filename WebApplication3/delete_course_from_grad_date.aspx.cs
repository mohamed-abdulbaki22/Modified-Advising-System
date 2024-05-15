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
    public partial class delete_course_from_grad_date : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (sem_code.Text.Length == 0 || courseID.Text.Length == 0 || studentID.Text.Length == 0)
                Response.Write("There is a missing input");
            else
            {
                try
                {
                    string connStr = WebConfigurationManager.ConnectionStrings["web"].ToString();
                    //create a new connection
                    SqlConnection conn = new SqlConnection(connStr);


                    String semCode = sem_code.Text;
                    int course_id = Int16.Parse(courseID.Text);
                    int student_id = Int16.Parse(studentID.Text);

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Procedures_AdvisorDeleteFromGP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;








                    cmd.Parameters.AddWithValue("@sem_code", semCode);
                    cmd.Parameters.AddWithValue("@courseID", course_id);
                    cmd.Parameters.AddWithValue("@studentID", student_id);


                    Response.Write("deleted succssefully");
                    cmd.ExecuteNonQuery();


                    conn.Close();
                }
                catch (System.FormatException ex)
                {
                    Response.Write("Course ID and student id should be integers");
                }
            }
            }
    }
}