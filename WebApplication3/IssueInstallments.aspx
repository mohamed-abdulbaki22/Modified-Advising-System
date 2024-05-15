<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IssueInstallments.aspx.cs" Inherits="WebApplication1.IssueInstallments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Payment Id : <br>
            <asp:TextBox ID="pId" runat="server"></asp:TextBox> <br>
            <asp:Button ID="Enter" runat="server" Text="Enter" OnClick="Enter_Click" /> <br>
            <asp:Button ID="home" runat="server" Text="HomePage" OnClick="home_Click" /><br>
        </div>
    </form>
</body>
</html>
