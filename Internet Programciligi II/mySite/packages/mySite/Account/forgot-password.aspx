<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="forgot-password.aspx.cs" Inherits="mySite.Account.forgot_password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="new-row">
        <div class="uye-alani-box">
            <div class="uye-alani">
                <div id="pasw-reset" class="new-row">
                    <table class="uye-kayit-table">
                        <tr>
                            <th colspan="5">Şifremi Unuttum</th>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblResult" runat="server" ForeColor="#3399FF"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>E-posta Adresini Girin:</td>
                            <td>
                                <asp:TextBox ID="tbE_posta" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Geçersiz E-posta adresi" ControlToValidate="tbE_posta" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="#FF1000"></asp:RegularExpressionValidator></td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <asp:Button ID="btnPasswReset" runat="server" Text="Yenileme Kodu Gönder" CssClass="btnReset" OnClick="btnPasswReset_Click" />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
