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
    public partial class viewGP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string connectString = WebConfigurationManager.ConnectionStrings["Web"].ToString();
                SqlConnection conn = new SqlConnection(connectString);
                conn.Open();

                // Call the stored procedure
                string returnValue = "SELECT * FROM dbo.FN_StudentViewGP(@student_ID)";
                SqlDataAdapter adapter = new SqlDataAdapter(returnValue, conn);

                adapter.SelectCommand.Parameters.Add(new SqlParameter("@student_ID", SqlDbType.Int)).Value = Session["user"];


                DataTable data = new DataTable();
                adapter.Fill(data);

                // Display the result in a GridView
                gplan.DataSource = data;
                gplan.DataBind();
            }
        }
        protected void returnHome(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }
    }
}