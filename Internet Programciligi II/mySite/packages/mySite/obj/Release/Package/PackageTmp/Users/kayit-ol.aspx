<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="kayit-ol.aspx.cs" Inherits="mySite.kayit_ol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        window.onload = function () {
            document.getElementById("Kaydol").style.display = 'none';
            document.getElementById("oturumAc").style.display = 'block';
            document.getElementById("c275").style.display = 'none';
            document.getElementById("c300").style.display = 'none';
        };
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="new-row">
        <div class="uye-alani-box">
            <div id="uyelik" class="uye-alani">
                <div style="text-align: center; font-size: 20px; font-family: Corbel;">Kayıt Ol Formu</div>
                <table class="uye-kayit-table">
                    <tr>
                        <td>Adı Soyadı :</td>
                        <td>
                            <asp:TextBox ID="tbAdSoyad" runat="server"></asp:TextBox></td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Ad Soyad Boş Olamaz" ForeColor="#FF1000" ControlToValidate="tbAdSoyad"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>E-Posta :</td>
                        <td>
                            <asp:TextBox ID="tbEposta" runat="server"></asp:TextBox></td>
                        <td>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Geçersiz E-posta adresi" ControlToValidate="tbEposta" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="#FF1000"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Yeni Şifre Girin : </td>
                        <td>
                            <asp:TextBox ID="tbSifre" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                        <td rowspan="2">
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Şifreler Uyuşmuyor" ControlToCompare="tbSifre" ControlToValidate="tbSifreTekrar" ForeColor="#FF1000"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Yeni Şifre Tekrar Girin :</td>
                        <td>
                            <asp:TextBox ID="tbSifreTekrar" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="5">
                            <a href="../Account/Sifremi-Unuttum" >Şifremi Unuttum</a>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="5">Üye Misiniz ? Hemen 
                                <a href="Oturum-Aç">Oturum Açın</a>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="5" style="text-align: center;">
                            <asp:Button ID="btnKaydol" runat="server" Text="Şimdi Kaydol" CssClass="btnUye" OnClick="btnKaydol_Click" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
