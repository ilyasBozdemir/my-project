<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="iletisim-mail.aspx.cs" Inherits="mySite.mail_sayfalari.iletisim_mail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #main-box { /*ana kutu*/
            width: 1000px;
            height: auto;
            margin: 0 auto;
        }

        .content-50 { /*nav-bar*/
            width: 1000px;
            height: 50px;
            background-color: #0bb9d1;
        }

        .content-50-left {
            float: left;
            width: auto;
            height: 50px;
        }

        .content-50-left-logo {
            width: 100px;
            height: 50px;
            margin-left: 10px;
            background-color: #aaa;
        }

        .content-50-right {
            margin-left: 30px;
            float: left;
            width: 400px;
            height: 50px;
        }

        .anon-uye {
            height: 50px;
        }

            .anon-uye .uyeAdsoyad {
                font-size: 20px;
                color: #fff;
            }

        ul li {
            list-style: none;
            display: inline-block;
            font-size: 25px;
        }

            ul li a {
                text-decoration: none;
                color: #fff;
                border-radius: 5px;
                opacity: .9;
            }

                ul li a:hover {
                    opacity: 1;
                    background-color: #678;
                }

        .bilgiler {
            clear: both;
        }
    </style>

</head>

<body>
    <form id="form1" runat="server">
        <div id="main-box">
            <%--nav-bar--%>
            <div class="content-50">
                <div class="content-50-left">
                    <div class="content-50-left-logo">
                        <a href="../Anasayfa">
                            <asp:Image ID="imgLogo" runat="server" />
                        </a>
                    </div>
                </div>
                <div style="float: left">
                    <asp:Label ID="logoAciklama" runat="server"></asp:Label>
                </div>
                <div class="content-50-right">
                    <ul>
                        <li><a href="<%: Home()%>">Anasayfa</a></li>
                        <li><a href="<%: About()%>">Hakkımızda</a></li>
                        <li><a href="<%: Contact()%>">İletişim</a></li>
                        <%-- baglantıları buraya ekleyin--%>
                    </ul>
                </div>
            </div>
        </div>
        <div class="bilgiler">
            <table>
                <tr>
                    <td>Adı Soyadı:</td>
                    <td>
                        <asp:Label ID="lblAdSoyad" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>E-posta Adresi:</td>
                    <td>
                        <asp:Label ID="lblmailAdresi" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Web Adresi:</td>
                    <td>
                        <asp:Label ID="lblWebAdres" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>IP Adresi:</td>
                    <td>
                        <asp:Label ID="lblIPAdresi" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Mesaji</td>
                    <td>
                        <asp:Label ID="lblMesaji" runat="server"></asp:Label></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
