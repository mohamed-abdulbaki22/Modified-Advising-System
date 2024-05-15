<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegister.aspx.cs" Inherits="WebApplication3.StudentRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Register Page</title>
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
        <div class="Container">
            <h1>Student Register Page</h1>
            <div>
                <asp:Label runat="server" Text="First Name:"></asp:Label>&nbsp;
            </div>
            <div>
                <asp:TextBox ID="first_name" runat="server"></asp:TextBox>&nbsp;
            </div>
            <div>Last Name:</div>
            <div>
                <asp:TextBox ID="last_name" runat="server"></asp:TextBox>&nbsp;
            </div>
            <div>Password:</div>
            <div>
                <asp:TextBox ID="passwordR" runat="server"></asp:TextBox>&nbsp;
            </div>
            <div>Faculty:</div>
            <div>
                <asp:TextBox ID="faculty" runat="server"></asp:TextBox>&nbsp;
            </div>
            <div>Email:</div>
            <div>
                <asp:TextBox ID="email" runat="server"></asp:TextBox>
            </div>
            <div>Major:</div>
            <div>
                <asp:TextBox ID="major" runat="server"></asp:TextBox>&nbsp;
            </div>
            <div>Semester:</div>
            <div>
                <asp:TextBox ID="sem" runat="server"></asp:TextBox>&nbsp;
            </div>
            <div>&nbsp;</div>
            <div class="center">
                <asp:Button runat="server" Text="Sign Up" OnClick="signUp"></asp:Button>&nbsp;
                <asp:HyperLink runat="server" Text="Login" NavigateUrl="Login.aspx"></asp:HyperLink>
            </div>
        </div>
    </form>
</body>
</html>
