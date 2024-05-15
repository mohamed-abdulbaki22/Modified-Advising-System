using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace WebApplication1
{
    public partial class LinkStudentToAdvisor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void link_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);


            if (studentID.Text.Length == 0 || advisorID.Text.Length == 0)
                Label1.Text = "Please enter all inputs";
            else
            {
                if (int.TryParse(studentID.Text, out _) && int.TryParse(advisorID.Text, out _))
                {
                    int stID = Int16.Parse(studentID.Text);
                    int adID = Int16.Parse(advisorID.Text);


                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Procedures_AdminLinkStudentToAdvisor", conn);
                    cmd.CommandType = CommandType.StoredProcedure;



                    cmd.Parameters.AddWithValue("@studentID", stID);
                    cmd.Parameters.AddWithValue("@advisorID", adID);


                    cmd.ExecuteNonQuery();

                    Label1.Text = "added successfully";
                    conn.Close();
                }
                else
                    Label1.Text = "all inputs in this page should be numbers";
            }
        }
    }
}