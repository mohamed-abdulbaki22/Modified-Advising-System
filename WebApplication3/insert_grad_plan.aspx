<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insert_grad_plan.aspx.cs" Inherits="WebApplication1.insert_grad_plan" %>

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
            Semester_code  <br />
            <asp:TextBox ID="semester_code" runat="server"></asp:TextBox><br />
expected_graduation_date 
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
sem_credit_hours 
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
advisor_id 
            <br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
student_id 
            <br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
            <asp:Button ID="add" runat="server" Text="Add" OnClick="add_Click" Width="75px" />
        </div>
    </form>
</body>
</html>
