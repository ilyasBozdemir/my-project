<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="Verify.aspx.cs" Inherits="mySite.Account.Verify" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        window.onload = function () {
            var Kaydol = document.getElementById("Kaydol").style.display = 'none';
            var OturumAc = document.getElementById("oturumAc").style.display = 'block';
            var Content275 = document.getElementById("c275").style.display = 'none';
            var Content300 = document.getElementById("c300").style.display = 'none';
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblBilgilendirme" runat="server"></asp:Label>
</asp:Content>
