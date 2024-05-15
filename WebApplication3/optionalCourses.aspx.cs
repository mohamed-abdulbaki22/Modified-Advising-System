using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class optionalCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void viewOptionalCourses(object sender, EventArgs e)
        {
            string connectString = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            SqlConnection conn = new SqlConnection(connectString);
            string semesterCode = sem_code.Text;
            if (string.IsNullOrWhiteSpace(sem_code.Text))
            {
                Response.Write("all fields are required");
                return;
            }
            conn.Open();

            // Call the stored procedure
            SqlCommand required = new SqlCommand("Procedures_ViewOptionalCourse", conn);
            required.CommandType = CommandType.StoredProcedure;
            string s = sem_code.Text;

            // Assuming you have the student ID stored in a session variable named "user"
            required.Parameters.Add(new SqlParameter("@StudentID", SqlDbType.Int)).Value = Session["user"];
            required.Parameters.Add(new SqlParameter("@current_semester_code", SqlDbType.VarChar,40)).Value = s;
            SqlDataAdapter adapter = new SqlDataAdapter(required);
            DataTable data = new DataTable();
            adapter.Fill(data);

            // Display the result in a GridView
            optional.DataSource = data;
            optional.DataBind();
        }
        protected void returnHome(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }
    }
}