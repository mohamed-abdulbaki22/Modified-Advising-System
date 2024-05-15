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
    public partial class DetailsOfAllActiveStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            conn.Open();

            SqlCommand logicFunc = new SqlCommand("SELECT * FROM view_Students", conn);           // is using select * allowed here ?


            SqlDataAdapter adapter = new SqlDataAdapter(logicFunc);

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);

            GridView4.DataSource = dataSet.Tables[0];
            GridView4.DataBind();

        }
        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage2.aspx");
        }
    }
}