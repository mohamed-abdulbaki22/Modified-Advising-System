using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace WebApplication3
{
    public partial class secondMakeUp : System.Web.UI.Page
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

                        SqlCommand loginFunc = new SqlCommand("FN_StudentCheckSMEligibility", conn);
                        loginFunc.CommandType = CommandType.StoredProcedure;
                        loginFunc.Parameters.Add(new SqlParameter("@StudentID", SqlDbType.Int)).Value = Session["user"];
                        loginFunc.Parameters.Add(new SqlParameter("@CourseID", cid));

                        // Add an output parameter to get the result of the function
                        SqlParameter funcOutput = new SqlParameter("@returnValue", SqlDbType.Bit);
                        funcOutput.Direction = ParameterDirection.ReturnValue;
                        loginFunc.Parameters.Add(funcOutput);
                        conn.Open();
                        loginFunc.ExecuteNonQuery();
                        conn.Close();

                        // Check the boolean value directly
                        if ((bool)funcOutput.Value)
                        {
                            SqlCommand regester = new SqlCommand("Procedures_StudentRegisterSecondMakeup", conn);
                            regester.CommandType = CommandType.StoredProcedure;
                            regester.Parameters.Add(new SqlParameter("@StudentID", SqlDbType.Int)).Value = Session["user"];
                            regester.Parameters.Add(new SqlParameter("@CourseID", cid));
                            regester.Parameters.Add(new SqlParameter("@studentCurr_sem", SqlDbType.VarChar, 40)).Value = semCode;
                            conn.Open ();   
                            regester.ExecuteNonQuery();
                            conn.Close();
                            res.Text = "Regesteration Successeded";
                            
                        }
                        else
                        {
                            res.Text = "Regesteration failed!!!";

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
    
