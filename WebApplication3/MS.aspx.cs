using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace WebApplication3
{
    public partial class MS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connectString = WebConfigurationManager.ConnectionStrings["Web"].ToString();
                SqlConnection conn = new SqlConnection(connectString);
                conn.Open();
        
                // Call the stored procedure
                SqlCommand missing = new SqlCommand("Procedures_ViewMS", conn);
                missing.CommandType = CommandType.StoredProcedure;

                // Assuming you have the student ID stored in a session variable named "user"
                missing.Parameters.Add(new SqlParameter("@StudentID", SqlDbType.Int)).Value = Session["user"];

                SqlDataAdapter adapter = new SqlDataAdapter(missing);
                DataTable data = new DataTable();
                adapter.Fill(data);

                // Display the result in a GridView
                missing_courses.DataSource = data;
                missing_courses.DataBind();
            }
        }
        protected void returnHome(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }
    }
}
