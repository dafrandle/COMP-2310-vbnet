<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>ASP.NET with Databases</h1>
    <br />    
    <h2>data:</h2>

    <div>
    
        <asp:GridView ID="gv" runat="server" Width="491px">
        </asp:GridView>
        <br />
        <asp:DropDownList ID="lstPhone" runat="server">
        </asp:DropDownList>
        <hr />
        UserID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:TextBox ID="txtUserID" runat="server" Height="16px"></asp:TextBox>
&nbsp;
        &nbsp;<br />
        <br />
        UserName:
        <br />
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;<asp:Button ID="btnSave" runat="server" Text="Save to Database" Height="21px" />
        <br />
    
    </div>
    </form>
</body>
</html>
