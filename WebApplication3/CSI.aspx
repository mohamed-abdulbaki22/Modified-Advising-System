<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CSI.aspx.cs" Inherits="WebApplication3.CSI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Courses, Slots, and Instructors</title>
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

        form {
            width: 100%;
            background: #fff;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        h1 {
            margin-bottom: 20px;
            color: #333;
            text-align: center;
        }

        #GridView3 {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }

        #GridView3 th, #GridView3 td {
            border: 1px solid #ddd;
            padding: 8px;
            text-align: center;
        }

        #GridView3 th {
            background-color: #4caf50;
            color: white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>View Courses, Slots, and Instructors</h1>
            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="True" CssClass="schedule">
            </asp:GridView>
            <br /><br /> <asp:Button ID="Button2" runat="server" Text="Home Page" OnClick="returnHome" />
        </div>
    </form>
</body>
</html>
