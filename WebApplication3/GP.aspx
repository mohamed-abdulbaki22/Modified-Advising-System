<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GP.aspx.cs" Inherits="WebApplication3.viewGP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Missing Courses</title>
    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body {
            min-height: 100vh;
            background: #f2f2f2;
            display: flex;
            font-family: Arial, sans-serif;
            justify-content: center;
            align-items: center;
            margin: 0;
        }

        #gplan {
            width: 90%;
            max-width: 800px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            margin-top: 20px;
            background: #fff; /* Add background color if needed */
            border-collapse: collapse;
            margin: 0 auto; /* Center the grid on the page */
        }

        #gplan th, #gplan td {
            border: 1px solid #ddd;
            padding: 8px;
            text-align: center;
        }

        #gplan th {
            background-color: #4caf50;
            color: white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>View Missing Courses</h1>
            <asp:GridView ID="gplan" runat="server" CssClass="schedule">
            </asp:GridView>
            <br /><br /> <asp:Button ID="Button2" runat="server" Text="Home Page" OnClick="returnHome" />
        </div>
    </form>
</body>
</html>
