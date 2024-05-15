<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewCourse.aspx.cs" Inherits="WebApplication3.viewCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Courses & Exam Details</title>
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

        form {
            width: 90%;
            max-width: 600px;
            background: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            text-align: center;
        }

        h1 {
            margin-bottom: 20px;
            color: #333;
        }

        #GridView3 {
            margin-top: 20px;
            width: 100%;
            border-collapse: collapse;
        }

        #GridView3 th, #GridView3 td {
            border: 1px solid #ddd;
            padding: 8px;
            text-align: left;
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
            <h1>View Courses & Exam Details</h1>
            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="True" Width="100%">
            </asp:GridView>
            <br /><br /> <asp:Button ID="Button2" runat="server" Text="Home Page" OnClick="returnHome" />
        </div>
    </form>
</body>
</html>
