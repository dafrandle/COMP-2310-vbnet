<%@ Page Title="" Language="VB" MasterPageFile="~/master.master" AutoEventWireup="false" CodeFile="myDataView.aspx.vb" Inherits="myDataView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script>
        function doConfirm() {
            var sql = document.getElementById('<%= hfSQLStatament.ClientID %>').value;
            var gameId = document.getElementById('<%= hfGameId.ClientID %>').value;
            if (confirm('Are you suer you want to delete reccord: ' + gameId +  '? \n This CAN NOT be undone\n \nYour sql statment:\n' + sql))
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
        Select ID for deletetion.<br />
        <h5>Game ID:<asp:DropDownList ID="ddSelect" runat="server" AutoPostBack="True">
            </asp:DropDownList>
        </h5>
        <asp:Button ID="btnDrop" runat="server" Text="Drop Record" OnClick="btnDrop_Click"  OnClientClick="if ( ! doConfirm()) return false;" meta:resourcekey="BtnUserDeleteResource1"/>

        <asp:Button ID="btnExcel" runat="server" Text="Convert To Excel" />

<br />
<br />

    <asp:HiddenField ID="hfSQLStatament" runat="server" />
    <asp:HiddenField ID="hfGameId" runat="server" />

</asp:Content>

