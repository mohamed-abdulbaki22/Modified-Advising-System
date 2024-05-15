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
    public partial class AddMakeupExamForCertainCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enter_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            if (type.Text == "" | date.Text == "" | courseid.Text == "")
            {
                Response.Write("You should enter all values");
            }
            else if (!Int16.TryParse(courseid.Text, out short courseIdValue) | !DateTime.TryParse(date.Text, out DateTime dT))
            {
                Response.Write("You should enter right value");
            }
            else
            {
                String Type = type.Text;
                DateTime Date = DateTime.Parse(date.Text);
                int Course = Int16.Parse(courseid.Text);

                SqlCommand AddMakeUP = new SqlCommand("Procedures_AdminAddExam", conn);
                AddMakeUP.CommandType = CommandType.StoredProcedure;
                AddMakeUP.Parameters.Add(new SqlParameter("@Type", Type));
                AddMakeUP.Parameters.Add(new SqlParameter("@date", Date));
                AddMakeUP.Parameters.Add(new SqlParameter("@courseID", Course));
                conn.Open();
                AddMakeUP.ExecuteNonQuery();
                Response.Write("added successfully");
                conn.Close();
            }
        }
        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage2.aspx");
        }
    }
}