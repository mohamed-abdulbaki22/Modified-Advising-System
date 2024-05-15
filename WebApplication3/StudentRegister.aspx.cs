using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class StudentRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signUp(object sender, EventArgs e)
        {
            string connectString = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            SqlConnection conn1 = new SqlConnection(connectString);
            if(string.IsNullOrWhiteSpace(first_name.Text)|| string.IsNullOrWhiteSpace(last_name.Text)
                || string.IsNullOrWhiteSpace(passwordR.Text)|| string.IsNullOrWhiteSpace(faculty.Text)
                || string.IsNullOrWhiteSpace(email.Text)|| string.IsNullOrWhiteSpace(major.Text)
                || string.IsNullOrWhiteSpace(sem.Text))
            {
                Response.Write("all fields are required");
                return;
            }
            string firstName = first_name.Text;
            string lastName = last_name.Text;
            string passwordy = passwordR.Text;
            string faculty1 = faculty.Text;
            string email1 = email.Text;
            string maj = major.Text;
            int semester = Int16.Parse(sem.Text);

            // SqlCommand to call the stored procedure
            SqlCommand registerProc = new SqlCommand("Procedures_StudentRegistration", conn1);
            registerProc.CommandType = CommandType.StoredProcedure;

            // Set parameters
            registerProc.Parameters.Add(new SqlParameter("@first_name", SqlDbType.VarChar, 40)).Value = firstName;
            registerProc.Parameters.Add(new SqlParameter("@last_name", SqlDbType.VarChar, 40)).Value = lastName;
            registerProc.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar, 40)).Value = passwordy;
            registerProc.Parameters.Add(new SqlParameter("@faculty", SqlDbType.VarChar, 40)).Value = faculty1;
            registerProc.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar, 40)).Value = email1;
            registerProc.Parameters.Add(new SqlParameter("@major", SqlDbType.VarChar, 40)).Value = maj;
            registerProc.Parameters.Add(new SqlParameter("@Semester", SqlDbType.Int)).Value = semester;

            SqlParameter id = registerProc.Parameters.Add("@Student_id", SqlDbType.Int);
            id.Direction = ParameterDirection.Output;

            // Open connection, execute stored procedure, and close connection
            conn1.Open();
            int i = registerProc.ExecuteNonQuery();
            conn1.Close();

            // Access the output parameter value
            if (i > 0)
            {
                int studentId = Convert.ToInt32(id.Value);
                Response.Write("Student ID: " + studentId);
                //logged.Visible = true;
            }
            else
            {
                Response.Write("error");
            }
        }

        protected void log(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}