<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication3.Login" %>

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
        <div class="Container">
            <h1>Login Page</h1>
            <div>
                <asp:Label runat="server" Text="UserID:"></asp:Label>
            </div>
            <div>
                <asp:TextBox ID="username" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Label runat="server" Text="Password:"></asp:Label>&nbsp;
            </div>
            <div class="">
                <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>&nbsp;
            </div>
            <div class="">Login As:
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
</asp:DropDownList>
            </div>
            <div class="center">
                <asp:Button ID="admin" runat="server" Text="admin" OnClick="admin_Click" />&nbsp;
                <asp:Button runat="server" Text="Log In" OnClick="login"></asp:Button>&nbsp;
                <asp:HyperLink runat="server" Text="Create An Account" NavigateUrl="SignUpAs.aspx"></asp:HyperLink>
            </div>
        </div>
    </form>
</body>
</html>
