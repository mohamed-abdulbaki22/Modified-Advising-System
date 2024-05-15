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
    public partial class request_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["web"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            int Advisor_id = Int16.Parse(Session["ID"].ToString());


            conn.Open();

            // Use SqlDataAdapter to fill a DataTable
            string returnValue = "SELECT * FROM dbo.FN_Advisors_Requests(@advisor_id)";
            SqlDataAdapter adapter = new SqlDataAdapter(returnValue, conn);
            adapter.SelectCommand.Parameters.Add(new SqlParameter("@advisor_id", SqlDbType.VarChar, 40)).Value = Advisor_id;

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            // Display the result in a GridView or other controls as needed
            GridView5.DataSource = dataTable;
            GridView5.DataBind();
        }

        protected void view_requests_Click(object sender, EventArgs e)
        {
           
        }
    }
}