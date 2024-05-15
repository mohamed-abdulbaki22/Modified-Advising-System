using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace WebApplication1
{
    public partial class UpdateStudentStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Enter_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            if (id.Text == "")
            {
                Response.Write("You should enter student id");
            }
            else if (!Int16.TryParse(id.Text, out short IdValue))
            {
                Response.Write("You should enter an integer");
            }
            else
            {
                int sid = Int16.Parse(id.Text);
                SqlCommand spro = new SqlCommand("Procedure_AdminUpdateStudentStatus", conn);
                spro.CommandType = CommandType.StoredProcedure;
                spro.Parameters.Add(new SqlParameter("@student_id", sid));
                conn.Open();
                spro.ExecuteNonQuery();
                Response.Write("updated successfully");
                conn.Close();
            }
        }
        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage2.aspx");
        }
    }
}