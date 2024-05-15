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
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            if (username.Text.Length == 0 || password.Text.Length == 0)
                Label1.Text = "Please enter both inputs";
            else
            {
                if (int.TryParse(username.Text, out _))
                {
                    int id = Int16.Parse(username.Text);
                    String pass = password.Text;

                    if (id == 16760)
                        if (pass == "Admin16760")
                        {
                            Label1.Text = "access granted";
                            Response.Redirect("AdminPage.aspx");
                        }
                        else
                            Label1.Text = "wrong password";
                    else
                        Label1.Text = "wrong ID";
                }
                else
                    Label1.Text = "ID must only contain numbers";
            }

            /*          SqlCommand loginproc = new SqlCommand("userlogin",conn);
                        loginproc.CommandType = CommandType.StoredProcedure;
                        loginproc.Parameters.Add(new SqlParameter("@id",id));
                        loginproc.Parameters.Add(new SqlParameter("@password", pass));

                        SqlParameter success = loginproc.Parameters.Add("@success",SqlDbType.Int);
                        SqlParameter type = loginproc.Parameters.Add("@type", SqlDbType.Int);

                        success.Direction = ParameterDirection.Output;
                        type.Direction = ParameterDirection.Output;
            */

            /*          conn.Open();
                        loginproc.ExecuteNonQuery();
                        conn.Close();
            */



            
        }
    }
}