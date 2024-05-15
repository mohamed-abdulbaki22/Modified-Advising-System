<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="WebApplication3.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Profile Page</title>
    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body {
            min-height: 100vh;
            background: #f5f5f5;
            display: flex;
            font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
            justify-content: center;
            align-items: center;
        }

        .Container {
            width: 80%;
            max-width: 600px;
            background: #fff;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 0 20px rgba(0, 0, 0, 0.1);
            text-align: center; /* Center the content horizontally */
        }

        h1 {
            color: #333;
            margin-bottom: 20px;
        }

        .button-container {
            margin-bottom: 15px;
        }

        .button-container button {
            display: block;
            width: 100%;
            padding: 12px;
            margin-bottom: 10px;
            font-size: 16px;
            border: none;
            border-radius: 25px; /* Adjust the border-radius to make buttons more rounded */
            cursor: pointer;
            transition: background 0.3s ease;
            background-color: #3498db;
            color: #fff;
        }

        .button-container button:hover {
            background: #2980b9;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="Container">
            <h1>User Profile</h1>

            <div class="button-container">
                <asp:Button ID="Button1" runat="server" Text="Add Student Mobile Number" OnClick="add" />
            </div>

            <div class="button-container">
                <asp:Button runat="server" Text="View All Optional Courses" OnClick="viewOptional"></asp:Button>
                <asp:Button runat="server" Text="View Available Courses" OnClick="availablePage"></asp:Button>
                <asp:Button runat="server" Text="Send Request" OnClick="sendRequest"></asp:Button>
            </div>

            <div class="button-container">
                <asp:Button ID="Button2" runat="server" Text="Missing Courses" OnClick="viewMS"></asp:Button>
                <asp:Button ID="Button3" runat="server" Text="View Required Courses" OnClick="required"></asp:Button>
                <asp:Button ID="Button4" runat="server" Text="View Graduation Plan" OnClick="viewGP"></asp:Button>
            </div>

            <div class="button-container">
                <asp:Button ID="Button5" runat="server" Text="Next Installment" OnClick="viewNextInstallment"></asp:Button>
                <asp:Button ID="Button6" runat="server" Text="View Courses & Exam Details" OnClick="viewCourse"></asp:Button>
                <asp:Button ID="Button7" runat="server" Text="Register For First Makeup" OnClick="regFirst"></asp:Button>
            </div>

            <div class="button-container">
                <asp:Button ID="Button8" runat="server" Text="Register For Second Makeup" OnClick="regSecond"></asp:Button>
                <asp:Button ID="Button9" runat="server" Text="View Courses, Corresponding Slots and Instructors" OnClick="viewCSI"></asp:Button>
                <asp:Button ID="Button10" runat="server" Text="View Slots" OnClick="viewSlot"></asp:Button>
            </div>

            <div class="button-container">
                <asp:Button ID="Button11" runat="server" Text="Choose Instructor" OnClick="choose"></asp:Button>
                <asp:Button ID="Button12" runat="server" Text="View Courses' Prerequisites" OnClick="viewPre"></asp:Button>
            </div>
        </div>
    </form>
</body>
</html>
