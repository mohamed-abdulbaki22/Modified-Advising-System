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
    public partial class LinkInstructorToCourseSlot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void link_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            if (courseID.Text.Length == 0 || instructorID.Text.Length == 0 || slotID.Text.Length == 0)
                Label1.Text = "Please enter both inputs";
            else
            {
                if (int.TryParse(courseID.Text, out _) && int.TryParse(instructorID.Text, out _) && int.TryParse(slotID.Text, out _))
                {
                    int course_id = Int16.Parse(courseID.Text);
                    int instructor_id = Int16.Parse(instructorID.Text);
                    int slot_id = Int16.Parse(slotID.Text);

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Procedures_AdminLinkInstructor", conn);
                    cmd.CommandType = CommandType.StoredProcedure;



                    cmd.Parameters.AddWithValue("@cours_id", course_id);
                    cmd.Parameters.AddWithValue("@instructor_id", instructor_id);
                    cmd.Parameters.AddWithValue("@slot_id", slot_id);



                    cmd.ExecuteNonQuery();

                    Label1.Text = "added successfully" ;
                    conn.Close();
                }
                else
                    Label1.Text = "all inputs in this page should be numbers";
            }
        }
    }
}