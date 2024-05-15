using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class addPhoneNumbers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

        }

        protected void addPhoneNumber(object sender, EventArgs e)
        {
            string connectString = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            SqlConnection conn = new SqlConnection(connectString);
            if (string.IsNullOrWhiteSpace(phoneNumber.Text))
            {
                Response.Write("all fields are required");
                return;
            }
            string number = phoneNumber.Text;
            SqlCommand add = new SqlCommand("Procedures_StudentaddMobile", conn);
            add.CommandType = CommandType.StoredProcedure;
            add.Parameters.Add(new SqlParameter("@StudentID", SqlDbType.Int)).Value = Session["user"];
            add.Parameters.Add(new SqlParameter("@mobile_number", SqlDbType.VarChar, 40)).Value = number;
            conn.Open();
            try
            {
                add.ExecuteNonQuery();
                Response.Write("Student number: " + number);
            }
            catch(Exception ex)
            {
                Response.Write("This number already exists in the System");
            }
            conn.Close();

            // Access the output parameter value
            
        }
        protected void returnHome(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }
    }
}