<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PendingRequests.aspx.cs" Inherits="WebApplication1.PendingRequests" %>

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

        .Container {
            width: 80%; /* Adjust the width as needed */
            max-width: 10000px; /* Set a maximum width if desired */
            background: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            text-align: center; /* Center the content inside the form */
        }

        #GridView3 {
            width: 100%;
            margin: 0 auto;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="Container">
            <h1>Pending requests</h1>
            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="True" style="text-align: center;">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
