<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="mySite.users.user" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../javascript/kullanici.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="new-row">
        <table class="user-table">
            <tr>
                <td>
                    <asp:Image ID="imgFoto" runat="server" Width="200px"/>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblUserName" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <asp:Label ID="lblHakkinda" runat="server"></asp:Label>
            </tr>
        </table>
    </div>
</asp:Content>
