using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Slots : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void showSlots(object sender, EventArgs e)
        {
            string connectString = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            SqlConnection conn = new SqlConnection(connectString);
            if (courseID.Text.Length == 0 || instructorID.Text.Length == 0 )
                Response.Write("There is a missing input");
            else
            {
                try
                {

                    conn.Open();

                    // Call the stored procedure
                    string returnValue = "SELECT * FROM dbo.FN_StudentViewSlot(@CourseID,@InstructorID)";
                    SqlDataAdapter adapter = new SqlDataAdapter(returnValue, conn);
                    int cid = Convert.ToInt32(courseID.Text);
                    int iid = Convert.ToInt32(instructorID.Text);
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@CourseID", cid));
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@InstructorID", iid));

                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    // Display the result in a GridView
                    slotsGrid.DataSource = data;
                    slotsGrid.DataBind();
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