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
    public partial class Available : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void viewAvailable(object sender, EventArgs e)
        {
            string connectString = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            SqlConnection conn = new SqlConnection(connectString);
            
            string semesterCode = sem_code.Text;
            if (string.IsNullOrWhiteSpace(sem_code.Text))
            {
                Response.Write("all fields are required");
                return;
            }
            // Use SqlDataAdapter to fill a DataTable
            string returnValue = "SELECT * FROM dbo.FN_SemsterAvailableCourses(@Current_semester_code)";
            SqlDataAdapter adapter = new SqlDataAdapter(returnValue, conn);
            adapter.SelectCommand.Parameters.Add(new SqlParameter("@Current_semester_code", SqlDbType.VarChar, 40)).Value = semesterCode;
    
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            // Display the result in a GridView or other controls as needed
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }
        protected void returnHome(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }
    }
}
