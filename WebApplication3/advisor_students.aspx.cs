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
    public partial class advisor_students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (major.Text.Length == 0)
                Response.Write("There is a missing input");
            else
            {
                string connStr = WebConfigurationManager.ConnectionStrings["web"].ToString();
                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);
                int Advisor_id = Int16.Parse(Session["ID"].ToString()); ;
                String imajor = (major.Text);

                conn.Open();

                SqlCommand cmd = new SqlCommand("Procedures_AdvisorViewAssignedStudents", conn);
                cmd.CommandType = CommandType.StoredProcedure;





                ;
                cmd.Parameters.AddWithValue("AdvisorID", Advisor_id);
                cmd.Parameters.AddWithValue("@major", imajor);



                cmd.ExecuteNonQuery();

                Response.Write("added successfully");


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet);

                GridView5.DataSource = dataSet.Tables[0];
                GridView5.DataBind();

                conn.Close();
            }
        }
    }
}