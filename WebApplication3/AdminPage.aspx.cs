using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void list_of_advisosr_Click(object sender, EventArgs e)
        {

            Response.Redirect("ListOfAdvisors.aspx");

        }

        protected void list_of_students_wiht_advisors_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentWithAdvisor.aspx");
        }

        protected void list_of_pending_requests_Click(object sender, EventArgs e)
        {
            Response.Redirect("PendingRequests.aspx");
        }

        protected void add_new_semester_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddNewSemester.aspx");
        }

        protected void add_new_course_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddNewCourse.aspx");
        }


        protected void link_instructor_to_course_Click(object sender, EventArgs e)
        {
            Response.Redirect("LinkInstructorToCourseSlot.aspx");
        }

        protected void link_student_to_advisor_Click(object sender, EventArgs e)
        {
            Response.Redirect("LinkStudentToAdvisor.aspx");
        }

        protected void link_student_to_course_with_instructor_Click(object sender, EventArgs e)
        {
            Response.Redirect("LinkStudentToCourseAndInstructor.aspx");
        }

        protected void view_instructors_with_their_courses_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstructorsWithTheirCourses.aspx");
        }

        protected void fetch_semesters_with_their_offered_courses_Click(object sender, EventArgs e)
        {
            Response.Redirect("FetchSemestersWithTheirCourses.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage2.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage.aspx");
        }
    }
}