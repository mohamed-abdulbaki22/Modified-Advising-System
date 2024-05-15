<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="approve_reject_extra _credi_ hours.aspx.cs" Inherits="WebApplication1.approve_reject_extra__credi__hours" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            requestID<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br>
            Semester_Code<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br>
            <asp:Button ID="Button1" runat="server" Text="Approve/Reject" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
