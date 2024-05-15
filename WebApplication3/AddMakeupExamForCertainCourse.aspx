<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMakeupExamForCertainCourse.aspx.cs" Inherits="WebApplication1.AddMakeupExamForCertainCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
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

        .Container {
            width: 500px;
            max-width: 90%;
            background: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        h1 {
            text-align: center;
        }

        div {
            margin-bottom: 10px;
        }

        .center {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Adding Makeup Excam : <br>
            Type: <br>
            <asp:TextBox ID="type" runat="server"></asp:TextBox> <br>
            Date : <br>
            <asp:TextBox ID="date" runat="server"></asp:TextBox> <br>
            Course ID : <br>
            <asp:TextBox ID="courseid" runat="server"></asp:TextBox> <br>
            <asp:Button ID="Enter" runat="server" Text="Enter" OnClick="Enter_Click" /><br>
            <asp:Button ID="home" runat="server" Text="HomePage" OnClick="home_Click" /><br>
        </div>
    </form>
</body>
</html>
