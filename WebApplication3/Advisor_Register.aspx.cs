using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Advisor_Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            if (Name.Text.Length == 0 || Password.Text.Length == 0)
                Response.Write("There is a missing input");
            else
            {
                try
                {
                    string connStr = WebConfigurationManager.ConnectionStrings["web"].ToString();
                    //create a new connection
                    SqlConnection conn = new SqlConnection(connStr);

                    int advisor_id = Int16.Parse(Name.Text);
                    String Pass = (Password.Text);

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("FN_AdvisorLogin", conn);
                    cmd.CommandType = CommandType.StoredProcedure;



                    cmd.Parameters.AddWithValue("@advisor_id", advisor_id);
                    cmd.Parameters.AddWithValue("@password", Pass);

                    SqlParameter funcOutput = new SqlParameter("@returnValue", SqlDbType.Bit);
                    funcOutput.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(funcOutput);


                    cmd.ExecuteNonQuery();
                    //if()
                    Session["ID"] = advisor_id;
                    Response.Redirect("advisor_page.aspx");
                    conn.Close();
                }
                catch (System.FormatException ex)
                {
                    Response.Write("Advisor ID should be an integer");
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("advisor_signUp.aspx");
        }
    }
}


