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
    public partial class StudentWithAdvisor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            conn.Open();

            SqlCommand logicFunc = new SqlCommand("AdminListStudentsWithAdvisors", conn);
            logicFunc.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(logicFunc);

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);

            GridView2.DataSource = dataSet.Tables[0];
            GridView2.DataBind();

            conn.Close();
        }
    }
}