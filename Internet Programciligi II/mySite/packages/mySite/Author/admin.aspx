<%@ Page Title="" Language="C#" MasterPageFile="~/management/management.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="mySite.author.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="new-row">
        <table class="admin-table">
            <tr>
                <td>
                    <asp:Image ID="imgFoto" runat="server" Width="200px"/>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbladminName" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
