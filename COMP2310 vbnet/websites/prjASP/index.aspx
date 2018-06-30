<%@ Page Title="" Language="VB" MasterPageFile="~/masterNoNav.master" AutoEventWireup="false" CodeFile="index.aspx.vb" Inherits="index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <h3>Login</h3>
    <h5>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Username: <asp:TextBox ID="tbUsername" runat="server" BackColor="#B1DCE4" BorderColor="#7EC4D4" Height="16px" Width="128px">Bob</asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="tbUsername" ErrorMessage="Must enter username!" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
    </h5>
    <h5>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password:
    <asp:TextBox ID="tbPassword" runat="server" BackColor="#B1DCE4" BorderColor="#7EC4D4" Width="128px">Please99!</asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="tbPassword" ErrorMessage="Must enter password!" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
    </h5>
    <asp:Button ID="btnLogin" runat="server" Text="Login" />
    <br />
    <b><p style="font-size: 12px; color:red;" id="loginError"></p></b>
    <p style="font-size: 12px;">Forgot pasword? You're sorry out of luck, we dont reset paswords here.</p>

</asp:Content>

