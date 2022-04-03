<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="oturum-ac.aspx.cs" Inherits="mySite.oturum_ac" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        window.onload =  function () {
            var lblKaydol = document.getElementById("Kaydol").style.display = 'block';
            var lblOturumAc = document.getElementById("oturumAc").style.display = 'none';
            var Content275 = document.getElementById("c275").style.display = 'none';
            var Content300 = document.getElementById("c300").style.display = 'none';
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="new-row">
        <div class="uye-alani-box">
            <div class="uye-alani">
                <table class="uye-kayit-table">
                    <tr>
                        <td colspan="5">Üyelik Oturum Aç
                        </td>
                    </tr>
                    <tr>
                        <td>E-posta Girin :</td>
                        <td>
                            <asp:TextBox ID="tbE_posta" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Sifre Girin :</td>
                        <td>
                            <asp:TextBox ID="tbSifre" runat="server" TextMode="Password"></asp:TextBox></td>
                        <td><a href="Kaydol">Üye Ol</a></td>
                    </tr>
                    <tr>
                        <td colspan="5" style="text-align: center;">
                            <asp:Label ID="lblBilgi" runat="server" ForeColor="#ff0000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="5" style="text-align: center;">
                            <asp:Button ID="btnOturumAc" runat="server" Text="Oturum Aç" CssClass="btnUye" OnClick="btnOturumAc_Click" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
