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
    public partial class Pre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectString = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            SqlCommand logicFunc = new SqlCommand("SELECT * FROM view_Course_prerequisites", conn);           // is using select * allowed here 
            SqlDataAdapter adapter = new SqlDataAdapter(logicFunc);

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);

            preGrid.DataSource = dataSet.Tables[0];
            preGrid.DataBind();
            conn.Close();
        }
        protected void returnHome(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }
    }
}