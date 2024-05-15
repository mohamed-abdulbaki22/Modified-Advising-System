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
    public partial class approve_reject_extra__course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0 || TextBox2.Text.Length == 0)
                Response.Write("There is a missing input");
            else
            {
                try
                {
                    string connStr = WebConfigurationManager.ConnectionStrings["web"].ToString();
                    //create a new connection
                    SqlConnection conn = new SqlConnection(connStr);
                    int id = Int16.Parse(TextBox1.Text);
                    String sem_code = TextBox2.Text;



                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Procedures_AdvisorApproveRejectCourseRequest", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@current_semester_code", sem_code);
                    cmd.Parameters.AddWithValue("@requestID", id);

                    Response.Write("request sent successfully");
                    cmd.ExecuteNonQuery();


                    conn.Close();
                }
                catch (System.FormatException ex)
                {
                    Response.Write("Request ID should be an integer");
                }
            }
            }
    }
}