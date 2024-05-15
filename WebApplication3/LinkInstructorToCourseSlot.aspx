<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinkInstructorToCourseSlot.aspx.cs" Inherits="WebApplication1.LinkInstructorToCourseSlot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
            width: 500px;
            max-width: 90%;
            background: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            text-align: center; /* Center the content inside the form */
        }

        label {
            display: block;
            margin-bottom: 5px;
        }

        input {
            width: 100%;
            padding: 10px;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
        }

        button {
            width: 100%;
            padding: 15px;
            background-color: #4CAF50;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            font-size: 16px;
        }

        button:hover {
            background-color: #45a049;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Link Instructor To</h1>
            <h1> Course Slot</h1>
            <label for="courseID">Course ID:</label>
            <asp:TextBox ID="courseID" runat="server"></asp:TextBox> <br>
            <label for="instructorID">Instructor ID:</label>
            <asp:TextBox ID="instructorID" runat="server"></asp:TextBox> <br>
            <label for="slotID">Slot ID:</label>
            <asp:TextBox ID="slotID" runat="server"></asp:TextBox> <br>
            <asp:Button ID="link" runat="server" Text="Link" OnClick="link_Click" /><br />
            <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
