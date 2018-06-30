<%@ Page Title="" Language="VB" MasterPageFile="~/master.master" AutoEventWireup="false" CodeFile="editDB.aspx.vb" Inherits="editDB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script>
        function doConfirm() {
            var sql = document.getElementById('<%= hfSQLStatament.ClientID %>').value;
            var gameId = document.getElementById('<%= hfPlatformId.ClientID %>').value;
            if (confirm('Are you suer you want to insert this recored?\n \nYour sql statment:\n' + sql))
                return true;
            else
                return false;
        }
    </script>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <asp:GridView ID="gv" runat="server" Width="491px">
    </asp:GridView>
    <br />
    <br />
    
    &nbsp;Input Data for New Record.<br />
<div id="inputField">
    <p style="font-size:10px;">Leave gameID blank unless you have a resaon not to</p>
    <h5>&nbsp;gameID:............................................................<asp:TextBox ID="tbID" runat="server" AutoPostBack="True" CausesValidation="true"></asp:TextBox>&nbsp;<asp:CompareValidator ID="CompareValidator2" runat="server" Operator="DataTypeCheck" Type="Double" ControlToValidate="tbID" ErrorMessage="Numbers Only!" ForeColor="Red"></asp:CompareValidator>
    </h5>
    <h5>name:................................................................<asp:TextBox ID="tbName" runat="server" AutoPostBack="True" CausesValidation="true"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="tbName" ErrorMessage="Must Set!" ForeColor="Red"></asp:RequiredFieldValidator>
    </h5>
    <h5>dev:...................................................................<asp:TextBox ID="tbDev" runat="server" AutoPostBack="True" CausesValidation="true"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvDev" runat="server" ControlToValidate="tbDev" ErrorMessage="Must Set!" ForeColor="Red"></asp:RequiredFieldValidator>
    </h5>
    <h5>publisher:.........................................................<asp:TextBox ID="tbPub" runat="server" AutoPostBack="True" CausesValidation="true"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvPub" runat="server" ControlToValidate="tbPub" ErrorMessage="Must Set!" ForeColor="Red"></asp:RequiredFieldValidator>
    </h5>
    <h5>&nbsp;cost:.................................................................<asp:TextBox ID="tbCost" runat="server" AutoPostBack="True" CausesValidation="true"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvCost" runat="server" ControlToValidate="tbCost" ErrorMessage="Must Set!" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" Operator="DataTypeCheck" Type="Double" ControlToValidate="tbCost" ErrorMessage="Numbers Only!" ForeColor="Red"></asp:CompareValidator>
    </h5>
    <h5>platform:...........................................................<asp:DropDownList ID="ddSelect" runat="server" AutoPostBack="True">
            </asp:DropDownList>
        <br /></h5></div>
    <br />
    <br />
    <br />
    <asp:Button ID="btnInsert" runat="server" Text="Insert Record" OnClick="btnInsert_Click"  OnClientClick="if ( ! doConfirm()) return false;" meta:resourcekey="BtnUserDeleteResource1"/>

    <asp:HiddenField ID="hfSQLStatament" runat="server" />
    <br />
    <asp:HiddenField ID="hfPlatformId" runat="server" />

    <br />

</asp:Content>

