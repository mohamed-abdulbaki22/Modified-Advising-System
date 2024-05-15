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
    public partial class pending_request_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["web"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            int Advisor_id = Int16.Parse(Session["ID"].ToString());


            conn.Open();

            SqlCommand cmd = new SqlCommand("Procedures_AdvisorViewPendingRequests", conn);
            cmd.CommandType = CommandType.StoredProcedure;





            ;
            cmd.Parameters.AddWithValue("@Advisor_ID", Advisor_id);




            cmd.ExecuteNonQuery();




            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);

            GridView5.DataSource = dataSet.Tables[0];
            GridView5.DataBind();

            conn.Close();
        }
    }
}