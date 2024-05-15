<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="nextInstallment.aspx.cs" Inherits="WebApplication3.nextInstallment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Next Installment</title>
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
            max-width: 400px;
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

        label {
            display: block;
            margin-bottom: 10px;
            font-size: 16px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Next Installment</h1>
        </div>
        <div> 
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br /><br /> <asp:Button ID="Button2" runat="server" Text="Home Page" OnClick="returnHome" />
        </div>
    </form>
</body>
</html>
