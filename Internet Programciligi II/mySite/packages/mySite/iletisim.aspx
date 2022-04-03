<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="mySite.iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="iletisim-formu">
        <div style="text-align:center">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/siteiçi resim/iletisim.png" />
        </div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Ad Soyad : (Gerekli) "></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tbAdSoyad" runat="server" Width="170px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbAdSoyad" ErrorMessage="İsim - soyisim bos olamaz" ForeColor="#FF1000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="E-posta Adresi : (Gerekli)"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tbMail" runat="server" Width="170px"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbMail" ErrorMessage="Yanlıs E-Mail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="#FF1000"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Web Siteniz : (Varsa)"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tbSite" runat="server" Width="170px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Mesajınız : (Gerekli)"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tbMesaj" runat="server" Height="80px" TextMode="MultiLine" Width="170px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbMesaj" ErrorMessage="Mesaj Bos Olamaz" ForeColor="#FF1000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center;">
                    <asp:Button ID="btnGonder" runat="server"  Text="Gönder &gt;&gt;&gt;" CssClass="btnSearch" OnClick="btnGonder_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
