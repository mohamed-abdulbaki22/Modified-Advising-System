<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="advisor_delete_course.aspx.cs" Inherits="WebApplication1.advisor_delete_course" %>

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
            student ID <br>,
           
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />semester code <br>,
           
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br>course Id <br>,
           
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" Width="93px" />

        </div>
    </form>
</body>
</html>
