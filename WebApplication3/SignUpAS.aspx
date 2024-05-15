<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUpAS.aspx.cs" Inherits="WebApplication3.SignUpAS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Sign Up As</h1>
            <asp:Button ID="Button1" runat="server" Text="Student" OnClick="Button1_Click" />
            </br> </br><asp:Button ID="Button2" runat="server" Text="Advisor" OnClick="advisorReg"/>
        </div>
    </form>
</body>
</html>
