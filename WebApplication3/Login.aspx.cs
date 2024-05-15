using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add(new ListItem("Select an option", string.Empty));
                DropDownList1.Items.Add(new ListItem("Student", "1"));
                DropDownList1.Items.Add(new ListItem("Advisor", "2"));
            }

        }

        protected void login(object sender, EventArgs e)
        {
            string connectString = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            SqlConnection conn = new SqlConnection(connectString);
            try {
                if (DropDownList1.SelectedValue == "1") {
                    int id = Int16.Parse(username.Text);
                    string pass = password.Text;

                    SqlCommand loginFunc = new SqlCommand("FN_StudentLogin", conn);
                    loginFunc.CommandType = CommandType.StoredProcedure;
                    loginFunc.Parameters.Add(new SqlParameter("@Student_id", id));
                    loginFunc.Parameters.Add(new SqlParameter("@password", pass));

                    // Add an output parameter to get the result of the function
                    SqlParameter funcOutput = new SqlParameter("@returnValue", SqlDbType.Bit);
                    funcOutput.Direction = ParameterDirection.ReturnValue;
                    loginFunc.Parameters.Add(funcOutput);
                    conn.Open();
                    loginFunc.ExecuteNonQuery();
                    conn.Close();

                    // Check the boolean value directly
                    if ((bool)funcOutput.Value)
                    {
                        Session["user"] = id;
                        Session["password"] = pass;
                        Response.Write("Hello");
                        Response.Redirect("Profile.aspx");
                    }
                    else
                    {
                        Response.Write("Login failed. Please check your credentials.");

                    } 
                }
                else if (DropDownList1.SelectedValue == "2")
                {
                    int id = Int16.Parse(username.Text);
                    string pass = password.Text;

                    SqlCommand loginFunc = new SqlCommand("FN_AdvisorLogin", conn);
                    loginFunc.CommandType = CommandType.StoredProcedure;
                    loginFunc.Parameters.Add(new SqlParameter("@advisor_Id", id));
                    loginFunc.Parameters.Add(new SqlParameter("@password", pass));

                    // Add an output parameter to get the result of the function
                    SqlParameter funcOutput = new SqlParameter("@returnValue", SqlDbType.Bit);
                    funcOutput.Direction = ParameterDirection.ReturnValue;
                    loginFunc.Parameters.Add(funcOutput);
                    conn.Open();
                    loginFunc.ExecuteNonQuery();
                    conn.Close();

                    // Check the boolean value directly
                    if ((bool)funcOutput.Value)
                    {
                        Session["ID"] = id;
                        Session["password"] = pass;
                        Response.Write("Hello");
                        Response.Redirect("advisor_page.aspx");
                    }
                    else
                    {
                        Response.Write("Login failed. Please check your credentials.");

                    }

                }
                else
                {
                    Response.Write("Choose An Option!");
                }
                
            } catch(System.FormatException ex) {
                Response.Write("User Id should be in number format");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void admin_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginAdmin.aspx");
        }
    }
}