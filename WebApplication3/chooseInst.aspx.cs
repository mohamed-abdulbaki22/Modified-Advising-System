using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class chooseInst : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void choose(object sender, EventArgs e)
        {
            string connectString = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            SqlConnection conn = new SqlConnection(connectString);
            if (courseID.Text.Length == 0 || instructorID.Text.Length == 0 || currentSemester.Text.Length == 0)
                Response.Write("There is a missing input");
            else
            {
                try
                {
                    conn.Open();
                    int cid = Convert.ToInt32(courseID.Text);
                    int iid = Convert.ToInt32(instructorID.Text);
                    string semCode = currentSemester.Text;
                    // Call the stored procedure
                    SqlCommand select = new SqlCommand("Procedures_ChooseInstructor", conn);
                    select.CommandType = CommandType.StoredProcedure;
                    select.Parameters.Add(new SqlParameter("@StudentID", SqlDbType.Int)).Value = Session["user"];
                    select.Parameters.Add(new SqlParameter("@CourseID", cid));
                    select.Parameters.Add(new SqlParameter("@instrucorID", iid));
                    select.Parameters.Add(new SqlParameter("@current_semester_code", SqlDbType.VarChar, 40)).Value = semCode;
                    select.ExecuteNonQuery();
                    done.Text = "Done";
                }

                catch (System.FormatException ex)
                {
                    Response.Write("Course ID and Instructor ID should be integers");
                }
            }
        }
        protected void returnHome(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }
    }
}