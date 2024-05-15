using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class nextInstallment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string connectString = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            SqlConnection conn = new SqlConnection(connectString);

            SqlCommand loginFunc = new SqlCommand("FN_StudentUpcoming_installment", conn);
            loginFunc.CommandType = CommandType.StoredProcedure;
            loginFunc.Parameters.Add(new SqlParameter("@student_ID", SqlDbType.Int)).Value = Session["user"];


            // Add an output parameter to get the result of the function
            SqlParameter funcOutput = new SqlParameter("@installdeadline", SqlDbType.Date);
            funcOutput.Direction = ParameterDirection.ReturnValue;
            loginFunc.Parameters.Add(funcOutput);
            conn.Open();
            loginFunc.ExecuteNonQuery();
            conn.Close();
            Label1.Text = funcOutput.Value.ToString();

        }
     
        protected void returnHome(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }
    }
}