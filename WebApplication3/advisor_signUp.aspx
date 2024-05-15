<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="advisor_signUp.aspx.cs" Inherits="WebApplication3.advisor_signUp" %>

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
            advisor name:<br>
            <asp:TextBox ID="advisor_name" runat="server"></asp:TextBox> <br>
            password: <br>
            <asp:TextBox ID="password" runat="server"></asp:TextBox> <br>
            email: <br>
            <asp:TextBox ID="email" runat="server"></asp:TextBox> <br>
            office: <br>
            <asp:TextBox ID="office" runat="server"></asp:TextBox> <br>
            <asp:Button ID="Button1" runat="server" Text="register" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
