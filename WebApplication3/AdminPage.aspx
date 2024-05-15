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
            <h1>Admin Page</h1>
           <asp:Button ID="list_of_advisosr" runat="server" Text="list advisors" Width="315px" Height="70px" OnClick="list_of_advisosr_Click" />  <br>
            <asp:Button ID="list_of_students_with_advisors" runat="server" Text="list students with their advisors" Width="315px" Height="70px" OnClick="list_of_students_wiht_advisors_Click" />  <br>
            <asp:Button ID="list_of_pending_requests" runat="server" Text="list pending requests" Width="315px" Height="70px" OnClick="list_of_pending_requests_Click" />  <br>
            <asp:Button ID="add_new_semester" runat="server" Text="add new semester" Height="70px" Width="315px" OnClick="add_new_semester_Click" />  <br>
            <asp:Button ID="add_new_course" runat="server" Text="add new couse" Height="70px" Width="315px" OnClick="add_new_course_Click" />   <br>
            <asp:Button ID="link_instructor_to_course" runat="server" Text="link instructor to course with slot" Height="70px" OnClick="link_instructor_to_course_Click" Width="315px" /><br >
            <asp:Button ID="link_student_to_advisor" runat="server" Text="link student to advisor" Height="70px" Width="315px" OnClick="link_student_to_advisor_Click" /><br >
            <asp:Button ID="link_student_to_course_with_instructor" runat="server" Text="link student to course with instructor" Height="70px" Width="315px" OnClick="link_student_to_course_with_instructor_Click" /><br >
            <asp:Button ID="view_instructors_with_their_courses" runat="server" Text="veiw instructors with their courses" Height="70px" Width="315px" OnClick="view_instructors_with_their_courses_Click" />   <br>
            <asp:Button ID="fetch_semesters_with_their_offered_courses" runat="server" Text="fetch semesters with their offered courses" Height="69px" OnClick="fetch_semesters_with_their_offered_courses_Click" Width="315px" /> <br><br>
            <asp:Button ID="Button1" runat="server" Text="Next page" Height="69px" Width="315px" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
