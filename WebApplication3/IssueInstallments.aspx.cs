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
    public partial class IssueInstallments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enter_Click(object sender, EventArgs e)
        {
            try
            {

                string connStr = WebConfigurationManager.ConnectionStrings["Web"].ToString();
                //create a new connection
                SqlConnection conn = new SqlConnection(connStr);

                if (pId.Text == "")
                {
                    Response.Write("You should enter payment id");
                }
                else if (!Int16.TryParse(pId.Text, out short paymentIdValue))
                {
                    Response.Write("You should enter an integer");
                }
                else
                {
                    int id = Int16.Parse(pId.Text);
                    SqlCommand Ppro = new SqlCommand("Procedures_AdminIssueInstallment", conn);
                    Ppro.CommandType = CommandType.StoredProcedure;
                    Ppro.Parameters.Add(new SqlParameter("@payment_id", id));
                    conn.Open();
                    Ppro.ExecuteNonQuery();
                    Response.Write("success");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Response.Write("This Payment already exists");
            }
        }
        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage2.aspx");
        }
    }
}