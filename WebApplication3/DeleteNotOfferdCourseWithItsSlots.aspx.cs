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
    public partial class DeleteNotOfferdCourseWithItsSlots : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enter_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            if (semcode.Text == "")
            {
                Response.Write("You should enter your current semester");
            }
            else
            {
                String semid = semcode.Text;
                SqlCommand deletpro = new SqlCommand("Procedures_AdminDeleteSlots", conn);
                deletpro.CommandType = CommandType.StoredProcedure;
                deletpro.Parameters.Add(new SqlParameter("@current_semester", semid));
                conn.Open();
                deletpro.ExecuteNonQuery();
                Response.Write("deleted");
                conn.Close();
            }

        }

        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage2.aspx");
        }
    }
}