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
    public partial class CSI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectString = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            SqlCommand logicFunc = new SqlCommand("SELECT * FROM Courses_Slots_Instructor", conn);           // is using select * allowed here 
            SqlDataAdapter adapter = new SqlDataAdapter(logicFunc);

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);

            GridView3.DataSource = dataSet.Tables[0];
            GridView3.DataBind();
            conn.Close();
        }
        protected void returnHome(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }
    }
}