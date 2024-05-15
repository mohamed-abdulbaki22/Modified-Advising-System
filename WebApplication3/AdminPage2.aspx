<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="WebApplication1.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body {
            min-height: 100vh;
            background: #e0e0ee;
            display: flex;
            font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
            justify-content: center;
            align-items: center;
        }

        form {
            width: 500px;
            max-width: 90%;
            background: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            text-align: center; /* Center the content inside the form */
        }

        button {
            width: 100%; /* Take the full width of the container */
            padding: 15px;
            background-color: #4CAF50;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            margin-bottom: 10px;
            font-size: 16px;
            display: block; /* Each button on a new line */
        }

        button:hover {
            background-color: #45a049;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="delete_a_course_with_its_slots" runat="server" Text="delete a course with its slots" Height="70px" Width="315px" OnClick="delete_a_course_with_its_slots_Click" /> <br>
            <asp:Button ID="delete_not_offerd_course_with_its_slots" runat="server" Text="delete not offerd course with its slots" Height="70px" Width="315px" OnClick="delete_not_offerd_course_with_its_slots_Click" /> <br>
            <asp:Button ID="add_makeup_exam_for_a_certain_course" runat="server" Text="add makeup exam for a certain course" Height="70px" Width="315px" OnClick="add_makeup_exam_for_a_certain_course_Click" /> <br>
            <asp:Button ID="view_details_for_payments_with_corresponding_students" runat="server" Text="View Details For Payments With Corresponding Students" Height="70px" Width="315px" OnClick="view_details_for_payments_with_corresponding_students_Click" /><br>
            <asp:Button ID="Issue_installments" runat="server" Text="Issue installments" Height="70px" Width="315px" OnClick="Issue_installments_Click" /> <br>
            <asp:Button ID="update_a_student_status" runat="server" Text="Update student status" Height="70px" Width="315px" OnClick="update_a_student_status_Click" /> <br>
            <asp:Button ID="Fetch_all_details_of_active_students" runat="server" Text="Details of all active students" Height="70px" Width="315px" OnClick="Fetch_all_details_of_active_students_Click" /> <br>
            <asp:Button ID="View_all_graduation_plans_along_with_their_initiated_advisors" runat="server" Text="View all graduation plans" Height="70px" Width="315px" OnClick="View_all_graduation_plans_along_with_their_initiated_advisors_Click" /> <br>
            <asp:Button ID="View_all_students_transcript_details" runat="server" Text="View all students transcript details" Height="70px" Width="315px" OnClick="View_all_students_transcript_details_Click" /><br>
            <asp:Button ID="Fetch_all_semesters_along_with_their_offered_courses" runat="server" Text="semesters along with their offered courses" Height="70px" Width="315px" OnClick="Fetch_all_semesters_along_with_their_offered_courses_Click" /> <br><br>
            <asp:Button ID="Button1" runat="server" Text="previous page" Height="70px" Width="315px" OnClick="Button1_Click1" />
        </div>
    </form>
</body>
</html>
