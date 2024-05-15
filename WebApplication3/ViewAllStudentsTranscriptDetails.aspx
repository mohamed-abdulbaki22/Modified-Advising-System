<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAllStudentsTranscriptDetails.aspx.cs" Inherits="WebApplication1.ViewAllStudentsTranscriptDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="True" Width="354px" >
            </asp:GridView><br>
            <asp:Button ID="home" runat="server" Text="HomePage" OnClick="home_Click" /><br>
        </div>
    </form>
</body>
</html>
