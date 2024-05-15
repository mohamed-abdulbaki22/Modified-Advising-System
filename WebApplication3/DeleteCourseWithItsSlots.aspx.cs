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
    public partial class DeleteCourseWithItsSlots : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Web"].ToString();
                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);

                if (courseId.Text == "")
                {
                    Response.Write("You should enter an id");
                }
                else if (!Int16.TryParse(courseId.Text, out short courseIdValue))
                {
                    Response.Write("You should enter an integer");
                }
                else
                {
                    int courseid = Int16.Parse(courseId.Text);
                    SqlCommand deletpro = new SqlCommand("Procedures_AdminDeleteCourse", conn);
                    deletpro.CommandType = CommandType.StoredProcedure;
                    deletpro.Parameters.Add(new SqlParameter("@courseID", courseid));
                    conn.Open();
                    deletpro.ExecuteNonQuery();
                    Response.Write("deleted");
                    conn.Close();
                }
            }
            catch(System.Data.SqlClient.SqlException ex)
            {
                Response.Write("Success");
            }
 
        }

        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage2.aspx");
        }
    }
}