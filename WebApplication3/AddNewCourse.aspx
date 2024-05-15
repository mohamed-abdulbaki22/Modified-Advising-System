<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNewCourse.aspx.cs" Inherits="WebApplication1.AddNewCourse" %>

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

        checkbox {
            margin-bottom: 15px;
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
            <h1>Add Course</h1>
            <label for="Major">Major:</label>
            <asp:TextBox ID="Major" runat="server"></asp:TextBox> <br>
            <label for="semester">Semester:</label>
            <asp:TextBox ID="semester" runat="server"></asp:TextBox> <br>
            <label for="creditHours">Credit Hours:</label>
            <asp:TextBox ID="creditHours" runat="server"></asp:TextBox> <br>
            <label for="Name">Name:</label>
            <asp:TextBox ID="Name" runat="server"></asp:TextBox> <br><br> 
            Is Offered
            <asp:CheckBox ID="isOffered" runat="server" /><br><br>
            <asp:Button ID="enter" runat="server" Text="Enter" Height="49px" OnClick="enter_Click" /> <br />
            <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
