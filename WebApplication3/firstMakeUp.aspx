<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="firstMakeUp.aspx.cs" Inherits="WebApplication3.firstMakeUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register For First Makeup</title>
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
            width: 90%;
            max-width: 400px;
            background: #fff;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
        }

        h1 {
            margin-bottom: 20px;
            color: #333;
            text-align: center;
        }

        div {
            margin-bottom: 15px;
        }

        label {
            display: block;
            margin-bottom: 5px;
        }

        input {
            width: 100%;
            padding: 8px;
            box-sizing: border-box;
            margin-bottom: 10px;
        }

        button {
            width: 100%;
            padding: 10px;
            background-color: #4caf50;
            color: #fff;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }

        button:hover {
            background-color: #45a049;
        }

        #res {
            color: #4caf50;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Register For First Makeup</h1>
        </div>
        <div>
            <label for="courseID">Enter Course ID:</label>
            <asp:TextBox ID="courseID" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="semesterCode">Enter Semester Code:</label>
            <asp:TextBox ID="semesterCode" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="regButton" runat="server" Text="Register" OnClick="regester" />
        </div>
        <div>
            <asp:Label ID="res" runat="server" Text=""></asp:Label>
            <br /><br /> <asp:Button ID="Button2" runat="server" Text="Home Page" OnClick="returnHome" />
        </div>
    </form>
</body>
</html>
