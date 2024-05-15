using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;

namespace WebApplication3
{
    public partial class firstMakeUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void regester(object sender, EventArgs e)
        {
            string connectString = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            SqlConnection conn = new SqlConnection(connectString);
            if (courseID.Text.Length == 0 || semesterCode.Text.Length == 0)
                Response.Write("There is a missing input");
            else
            {
                try
                {
                    if (!string.IsNullOrEmpty(courseID.Text))
                    {
                        int cid = Convert.ToInt32(courseID.Text);
                        string semCode = semesterCode.Text;

                        SqlCommand regester = new SqlCommand("Procedures_StudentRegisterFirstMakeup", conn);
                        regester.CommandType = CommandType.StoredProcedure;

                        regester.Parameters.Add(new SqlParameter("@StudentID", SqlDbType.Int)).Value = Session["user"];
                        regester.Parameters.Add(new SqlParameter("@courseID", cid));
                        regester.Parameters.Add(new SqlParameter("@studentCurr_sem", SqlDbType.VarChar, 40)).Value = semCode;

                        // Add an output parameter to get the result of the function
                        SqlParameter funcOutput = new SqlParameter("@out", SqlDbType.Bit);
                        funcOutput.Direction = ParameterDirection.Output;
                        regester.Parameters.Add(funcOutput);

                        conn.Open();
                        regester.ExecuteNonQuery();
                        conn.Close();

                        // Check the boolean value directly
                        if ((bool)funcOutput.Value)
                        {
                            res.Text = "Registration Succeeded";
                        }
                        else
                        {
                            res.Text = "Registration failed!!!";
                        }
                    }
                }
                catch (System.FormatException ex)
                {
                    Response.Write("Course ID should be an integer");
                }
            }
        }
        protected void returnHome(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }
    }
}
