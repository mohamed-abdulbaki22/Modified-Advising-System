<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view all students.aspx.cs" Inherits="WebApplication1.view_all_students" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>List Students With</h1>
<h1>Their Advisors</h1>
<asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="True" Width="354px" style="margin: 0 auto; text-align: center;">
</asp:GridView>
        </div>
    </form>
</body>
</html>
