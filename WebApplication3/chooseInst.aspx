<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chooseInst.aspx.cs" Inherits="WebApplication3.chooseInst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Choose Instructor</title>
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

        form {
            width: 90%;
            max-width: 500px;
            background: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            text-align: center;
        }

        div {
            margin-bottom: 20px;
        }

        #Button1, #Button2 {
            padding: 10px;
            background-color: #4caf50;
            color: #fff;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        #Button2 {
            background-color: #2196f3;
        }

        #done {
            color: #4caf50;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Choose Instructor for a Certain Selected Course</h2>
        </div>
        <div> 
            Instructor ID: <br />
            <asp:TextBox ID="instructorID" runat="server"></asp:TextBox><br />
            Course ID: <br />
            <asp:TextBox ID="courseID" runat="server"></asp:TextBox><br />
            Current Semester Code: <br />
            <asp:TextBox ID="currentSemester" runat="server"></asp:TextBox><br />
           <br /> <asp:Button ID="Button1" runat="server" Text="Choose" OnClick="choose" />
           <br /><br /> <asp:Label ID="done" runat="server" Text=""></asp:Label>
           <br /><br /> <asp:Button ID="Button2" runat="server" Text="Home Page" OnClick="returnHome" />
        </div>
    </form>
</body>
</html>
