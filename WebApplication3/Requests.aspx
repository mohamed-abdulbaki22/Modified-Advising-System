<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Requests.aspx.cs" Inherits="WebApplication3.Requests" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Requests Page</title>
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
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="Container">
            <h1>Requests Page</h1>
            <div>
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
                </asp:DropDownList>
            </div>
            <div>&nbsp;</div>
            <div>&nbsp;</div>
            <div>&nbsp;<asp:Label ID="credit_course" runat="server" Text="label" Visible="False"></asp:Label></div>
            <div>&nbsp;<asp:TextBox ID="value" runat="server" Visible="False"></asp:TextBox></div>
            <div>
                <asp:Label ID="comment_label" runat="server" Text="Comment" Visible="False"></asp:Label>
            </div>
            <div>&nbsp;<asp:TextBox ID="comment" runat="server" Visible="False"></asp:TextBox></div>
            <div>&nbsp;</div>
            <div>&nbsp;<asp:Button ID="Button1" runat="server" Text="Submit Request" Visible="False" OnClick="submit" />
                <br /><br /> <asp:Button ID="Button2" runat="server" Text="Home Page" OnClick="returnHome" />
            </div>
        </div>
    </form>
</body>
</html>
