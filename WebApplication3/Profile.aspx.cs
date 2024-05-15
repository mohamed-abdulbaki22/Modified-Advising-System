using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectString = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            SqlConnection conn = new SqlConnection(connectString);

            Response.Write(Session["user"]);

        }

        protected void add(object sender, EventArgs e)
        {
            string connectString = WebConfigurationManager.ConnectionStrings["Web"].ToString();
            SqlConnection conn = new SqlConnection(connectString);

            Response.Redirect("addPhoneNumbers.aspx");
        }

        protected void viewOptional(object sender, EventArgs e)
        {
            Response.Redirect("optionalCourses.aspx");
        }

        protected void availablePage(object sender, EventArgs e)
        {
            Response.Redirect("Available.aspx");
        }

        protected void sendRequest(object sender, EventArgs e)
        {
            Response.Redirect("Requests.aspx");
        }

        protected void viewMS(object sender, EventArgs e)
        {
            Response.Redirect("MS.aspx");
        }

        protected void required(object sender, EventArgs e)
        {
            Response.Redirect("Required.aspx");
        }
        protected void viewGP(object sender, EventArgs e)
        {
            Response.Redirect("GP.aspx");
        }
        protected void viewNextInstallment(object sender, EventArgs e)
        {
            Response.Redirect("nextInstallment.aspx");
        }
        protected void viewCourse(object sender, EventArgs e)
        {
            Response.Redirect("viewCourse.aspx");
        }
        protected void regFirst(object sender, EventArgs e)
        {
            Response.Redirect("firstMakeUp.aspx");
        }
        protected void regSecond(object sender, EventArgs e)
        {
            Response.Redirect("secondMakeUp.aspx");
        }
        protected void viewCSI(object sender, EventArgs e)
        {
            Response.Redirect("CSI.aspx");
        }
        protected void viewSlot(object sender, EventArgs e)
        {
            Response.Redirect("Slots.aspx");
        }
        protected void choose(object sender, EventArgs e)
        {
            Response.Redirect("chooseInst.aspx");
        }
        protected void viewPre(object sender, EventArgs e)
        {
            Response.Redirect("Pre.aspx");
        }

    }
}