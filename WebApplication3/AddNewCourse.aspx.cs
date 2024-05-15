using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection.Emit;

namespace WebApplication1
{
    public partial class AddNewCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void enter_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            if (Major.Text.Length == 0 || semester.Text.Length == 0 || creditHours.Text.Length == 0 || Name.Text.Length == 0)
                Label1.Text = "Please enter all inputs" ;
            else
            {
                if (int.TryParse(semester.Text, out _)&& int.TryParse(creditHours.Text, out _))
                {
                    String major = Major.Text;
                    int sem = Int16.Parse(semester.Text);
                    int creHours = Int16.Parse(creditHours.Text);
                    String name = Name.Text;
                    int bit;
                    if (isOffered.Checked)
                        bit = 1;
                    else
                        bit = 0;


                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Procedures_AdminAddingCourse", conn);
                    cmd.CommandType = CommandType.StoredProcedure;




                    cmd.Parameters.AddWithValue("@major", major);
                    cmd.Parameters.AddWithValue("@semester", sem);
                    cmd.Parameters.AddWithValue("@credit_hours", creHours);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@is_offered", bit);

                    cmd.ExecuteNonQuery();
                    Label1.Text = "added successfully" ;
                    conn.Close();
                }
                else
                {
                    Label1.Text = "creditHours and semester input fields should only contain numbers";
                }
            }
        }
    }
}