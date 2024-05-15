<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Slots.aspx.cs" Inherits="WebApplication3.Slots" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Slots</title>
    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body {
            min-height: 100vh;
            background: #e0e0ee;
            font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        h1 {
            margin-bottom: 20px;
            color: #333;
        }

        .Container {
            width: 90%;
            max-width: 1200px;
            background: #fff;
            padding: 30px;
            border-radius: 12px;
            box-shadow: 0 0 20px rgba(0, 0, 0, 0.2);
        }

        form {
            text-align: center;
        }

        input[type="text"], input[type="button"] {
            width: 100%;
            padding: 10px;
            margin: 10px 0;
            box-sizing: border-box;
        }

        input[type="button"] {
            background-color: #4caf50;
            color: white;
            border: none;
            border-radius: 6px;
            cursor: pointer;
        }

        input[type="button"]:hover {
            background-color: #45a049;
        }

        #slotsGrid {
            margin-top: 30px;
            width: 100%;
            border-collapse: collapse;
        }

        #slotsGrid th, #slotsGrid td {
            border: 1px solid #ddd;
            padding: 12px;
            text-align: left;
        }

        #slotsGrid th {
            background-color: #4caf50;
            color: white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="Container">
            <h1>View Slots</h1>
            Course ID:<br />
            <asp:TextBox ID="courseID" runat="server"></asp:TextBox><br />
            Instructor ID:<br />
            <asp:TextBox ID="instructorID" runat="server"></asp:TextBox><br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="View" OnClick="showSlots"/><br />
            <div>
                <br />
                <asp:GridView ID="slotsGrid" runat="server"></asp:GridView>
                <br /><br /> <asp:Button ID="Button2" runat="server" Text="Home Page" OnClick="returnHome" />
            </div>
        </div>
    </form>
</body>
</html>
