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
        
        protected void delete_a_course_with_its_slots_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteCourseWithItsSlots.aspx");
        }

        protected void delete_not_offerd_course_with_its_slots_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteNotOfferdCourseWithItsSlots.aspx");
        }

        protected void add_makeup_exam_for_a_certain_course_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddMakeupExamForCertainCourse.aspx");
        }

        protected void view_details_for_payments_with_corresponding_students_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewDetailsForPaymentsWithCorrespondingStudents.aspx");
        }

        protected void Issue_installments_Click(object sender, EventArgs e)
        {
            Response.Redirect("IssueInstallments.aspx");
        }

        protected void update_a_student_status_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateStudentStatus.aspx");
        }

        protected void Fetch_all_details_of_active_students_Click(object sender, EventArgs e)
        {
            Response.Redirect("DetailsOfAllActiveStudents.aspx");
        }

        protected void View_all_graduation_plans_along_with_their_initiated_advisors_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAllGraduationPlans.aspx");
        }

        protected void View_all_students_transcript_details_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAllStudentsTranscriptDetails.aspx");
        }

        protected void Fetch_all_semesters_along_with_their_offered_courses_Click(object sender, EventArgs e)
        {
            Response.Redirect("SemestersAlongWithTheirOfferedCourses.aspx");
        }
    }
}