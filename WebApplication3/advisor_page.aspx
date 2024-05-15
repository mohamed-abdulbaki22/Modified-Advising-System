<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="advisor_page.aspx.cs" Inherits="WebApplication1.advisor_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        * {
            margin: 0 0 0 9px;
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
    <form id="form1" runat="server">
        <div style="height: 342px">
            <asp:Button ID="viewstudents" runat="server" Text="View Students" OnClick="viewstudents_Click" Width="300px" Height="25px" /><br>
            <asp:Button ID="Button1" runat="server" Text="View requests" OnClick="Button1_Click" Width="300px" Height="36px" /><br />
            <asp:Button ID="Button2" runat="server" Text="View pending requests" OnClick="Button1_Click1" Width="300px" Height="34px" /><br />
            <asp:Button ID="Button3" runat="server" Text=" Insert graduation plan" OnClick="Button3_Click" Width="300px" Height="29px" /> <br>
            <asp:Button runat="server" Text=" Insert courses to graduation plan" Height="28px" OnClick="Unnamed1_Click1" Width="300px" /><br>
            <asp:Button runat="server" Text="Update expected graduation date" Width="300px" Height="29px" OnClick="Unnamed2_Click" /> <br>
            <asp:Button runat="server" Text="delete course from graduation plan" Height="31px" OnClick="Unnamed3_Click" Width="300px" /><br>
            <asp:Button runat="server" Text="View all students" Height="30px" OnClick="Unnamed4_Click" Width="303px" /><br />
            <asp:Button runat="server" Text="Approve/reject extra credit hours request." Width="304px" OnClick="Unnamed5_Click1" />
            <asp:Button runat="server" Text="Approve/ reject extra course request." OnClick="Unnamed6_Click" Width="307px" />
        </div>
    </form>
</body>
</html>
