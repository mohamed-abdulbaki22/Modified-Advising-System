using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class advisor_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void viewstudents_Click(object sender, EventArgs e)
        {
            Response.Redirect("advisor_students.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("request_page.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("pending_request_page.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("insert_grad_plan.aspx");
        }


        protected void Unnamed1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("insert_course_to_grad_plan.aspx");
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Response.Redirect("update_expected_grad_date.aspx");
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            Response.Redirect("delete_course_from_grad_date.aspx");
        }

        protected void Unnamed4_Click(object sender, EventArgs e)
        {
            Response.Redirect("view all students.aspx");
        }


        protected void Unnamed5_Click1(object sender, EventArgs e)
        {
            Response.Redirect("approve_reject_extra _credi_ hours.aspx");
        }

        protected void Unnamed6_Click(object sender, EventArgs e)
        {
            Response.Redirect("approve_reject_extra _course.aspx");
        }
    }
}