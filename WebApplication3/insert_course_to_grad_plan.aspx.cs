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
    public partial class insert_course_to_grad_plan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (semester_code.Text.Length == 0 || course_name.Text.Length == 0 || student_id.Text.Length == 0)
                Response.Write("There is a missing input");
            else
            {
                try
                {
                    string connStr = WebConfigurationManager.ConnectionStrings["web"].ToString();
                    //create a new connection
                    SqlConnection conn = new SqlConnection(connStr);



                    String sem_code = semester_code.Text;
                    String courseName = course_name.Text;
                    int studentId = Int16.Parse(student_id.Text);

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Procedures_AdvisorAddCourseGP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;



                    cmd.Parameters.AddWithValue("@Semester_code", sem_code);
                    cmd.Parameters.AddWithValue("@course_name", courseName);
                    cmd.Parameters.AddWithValue("@student_id", studentId);


                    Response.Write("Added succssefully");
                    cmd.ExecuteNonQuery();


                    conn.Close();
                }
                catch (System.FormatException ex)
                {
                    Response.Write("Student ID should be an integer");
                }
            }
        }
    }
}