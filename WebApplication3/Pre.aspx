<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pre.aspx.cs" Inherits="WebApplication3.Pre" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Courses and their Prerequisites</title>
    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body {
            min-height: 100vh;
            background: #f4f4f4;
            font-family: Arial, sans-serif;
            margin: 0;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        #preGrid {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }

        #preGrid th, #preGrid td {
            border: 1px solid #ddd;
            padding: 8px;
            text-align: center;
        }

        #preGrid th {
            background-color: #4caf50;
            color: white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>View Courses and their Prerequisites</h1>
        <asp:GridView ID="preGrid" runat="server" CssClass="schedule">
        </asp:GridView>
        <br /><br /> <asp:Button ID="Button2" runat="server" Text="Home Page" OnClick="returnHome" />
    </form>
</body>
</html>
