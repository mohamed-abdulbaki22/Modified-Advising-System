<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailsOfAllActiveStudents.aspx.cs" Inherits="WebApplication1.DetailsOfAllActiveStudents" %>

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
            <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="True" Width="354px" >
            </asp:GridView><br>
            <asp:Button ID="home" runat="server" Text="HomePage" OnClick="home_Click" /><br>
        </div>
    </form>
</body>
</html>
