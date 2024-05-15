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
    public partial class advisor_delete_course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

            string connStr = WebConfigurationManager.ConnectionStrings["StudentSystem"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);


            int student_id = Int16.Parse(TextBox1.Text);
            String sem_code = TextBox2.Text;
            int course_id = Int16.Parse(TextBox3.Text);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Procedures_AdvisorDeleteFromGP", conn);
            cmd.CommandType = CommandType.StoredProcedure;



        }
    }
}