<%@ Page Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="Slider.aspx.cs" Inherits="odev.Admin.WebForm3" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 193px;
            text-align: right;
        }
        .style3
        {
            width: 347px;
            text-align: center;
        }
    .style4
    {
        width: 193px;
        text-align: right;
        height: 23px;
    }
    .style5
    {
        width: 347px;
        text-align: center;
        height: 23px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
    <table class="style1">
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
  
                Resim Yolu:</td>
            <td class="style3">
    <asp:FileUpload ID="fuResim" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
    <asp:Button ID="Button1" runat="server" Text="Ekle" onclick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
             <td class="style3 ">
                 &nbsp;</td>
        </tr>
    </table>
</asp:Content>
