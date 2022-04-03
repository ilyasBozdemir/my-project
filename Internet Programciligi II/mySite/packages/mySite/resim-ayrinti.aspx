<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="resim-ayrinti.aspx.cs" Inherits="mySite.resim_ayrinti" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function Yuklendi() {
            //masterdan miras alınan content-275 ve content-300 classlarını burda gizlemek amac bu sayfada onlar gorunmesin
            var Content275 = document.getElementById("c275").style.display = 'none';// divin id'sini al ve gizle
            var Content300 = document.getElementById("c300").style.display = 'none';
        }
        window.onload = Yuklendi;
        function BilgileriAl() {
            alert("Yorum id = " + document.getElementById("lblYorumID"));
        }
    </script>
    <%-- slider ve govde sagı gizlemek istedigin sayfaya ekle :) --%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-200">
        <div>
            <asp:Image ID="imgResim" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblAdi" runat="server"></asp:Label>
        </div>
        <div>
            <asp:Label ID="lblAciklamasi" runat="server"></asp:Label>
        </div>
    </div>
    <div class="content-500">
        <h3 style="text-align: center; margin-top: 20px">Yorum Ekleme Panel Örnegi</h3>
        <h4>
            <asp:Label ID="lblYorumSayisi" runat="server"></asp:Label>
        </h4>
        <asp:DataList ID="dl_yorum" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnItemDataBound="dl_yorum_ItemDataBound">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <ItemTemplate>
                <%-- Ana Datalist--%>
                <div style="display: none">
                    <asp:Label ID="lblYorumID" runat="server" Text='<%# Eval("Yorum_ID") %>'></asp:Label>
                </div>
                <div class="yorumlar-ana-kutu">
                    <div class="yorumlar-img-box">
                        <asp:Image ID="imgYorumFoto" runat="server" Class="yorumlar-img-resim" ImageUrl='<%# Eval("Yorumcu_Fotograf","siteiçi resim/{0}") %>' />
                    </div>
                    <div class="yorumlar-adsoyad-box">
                        <a href='<%# string.Format(userIDGetir(Eval("Yorumcu_AdSoyad").ToString())==null? admin() : users()) %>' class="yorumlar-adsoyad-link">
                            <asp:Label ID="lblYorumcuAdSoyad" runat="server" CssClass="yorumlar-adsoyad-metin" Text='<%# Eval("Yorumcu_AdSoyad") %>'></asp:Label>
                        </a>
                    </div>
                    <div class="yorumlar-tarih-box">
                        <asp:Label ID="lblYorumTarihi" CssClass="yorumlar-tarih-metin" runat="server" Text='<%# Eval("Yorum_Tarihi") %>'></asp:Label>
                    </div>
                    <div class="yorumlar-yetki-box">
                        <asp:Label ID="lblaltUst" CssClass="yorumlar-yetki-metin" runat="server" Text='<%# Eval("Yorum_Yetki") %>'></asp:Label>
                    </div>
                    <div class="yorumlar-mesaj-box">
                        <asp:Label ID="lblYorum" runat="server" CssClass="yorumlar-mesaj-metin" Text='<%# Eval("Yorum_Mesaji") %>'></asp:Label>
                    </div>
                    <div class="yorumlar-cevapla-box">
                        <a href='<%# "resim-ayrinti.aspx?resim-id="+ Eval("Yorum_ID", Request.QueryString["resim-id"] +"&yorum-id={0}#yorum-yap") %>'
                            class="yorumlar-cevapla-link" onclick="BilgileriAl()">
                            <asp:Label ID="lblCevapla" runat="server" Text="Cevapla" CssClass="yorumlar-cevapla-metin"></asp:Label></a>
                    </div>
                </div>
                <%--- Alt DataList---%>
                <asp:DataList ID="dl_alt_yorum" runat="server" CssClass="alt-yorum" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnItemDataBound="dl_alt_yorum_ItemDataBound">
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                    <ItemTemplate>
                        <div style="display: none">
                            <asp:Label ID="lblYorumID" runat="server" Text='<%# Eval("Yorum_ID") %>'></asp:Label>
                        </div>
                        <div class="alt-yorum-img">
                            <img src="siteiçi%20resim/alt-yorum.png" />
                        </div>
                        <div class="alt-yorumlar-ana-kutu">
                            <div class="yorumlar-yanıtOlarak-box">
                                <%--auto--%>
                                <a href='#' class="yorumlar-yanıtOlarak-link"><%--- linki verme en yakın zamanda ---%>
                                    <asp:Label ID="lblYanitVerilen" runat="server" CssClass="yorumlar-yanıtOlarak-link"></asp:Label>
                                </a>
                                <asp:Label ID="lblYanitVerilenText" runat="server" CssClass="yorumlar-yanıtOlarak-metin" Text=" Kişisine Yanıt Olarak"></asp:Label>
                            </div>
                            <div class="yorumlar-img-box">
                                <%--system--%>
                                <asp:Image ID="imgYorumFoto" runat="server" Class="yorumlar-img-resim" ImageUrl='<%# Eval("Yorumcu_Fotograf","siteiçi resim/{0}") %>' />
                            </div>
                            <div class="yorumlar-adsoyad-box">
                                <%--client--%>
                                <a href='<%# string.Format(userIDGetir(Eval("Yorumcu_AdSoyad","@{0}").ToString())==null? admin() : users()) %>' class="yorumlar-adsoyad-link" onclick="BilgileriAl()">
                                    <asp:Label ID="lblYorumcuAdSoyad" runat="server" CssClass="yorumlar-adsoyad-metin" Text='<%# Eval("Yorumcu_AdSoyad") %>'></asp:Label>
                                </a>
                            </div>
                            <div class="yorumlar-tarih-box">
                                <%--system--%>
                                <asp:Label ID="lblYorumTarihi" CssClass="yorumlar-tarih-metin" runat="server" Text='<%# Eval("Yorum_Tarihi") %>'></asp:Label>
                            </div>
                            <div class="yorumlar-yetki-box">
                                <%--system--%>
                                <asp:Label ID="lblaltUst" CssClass="yorumlar-yetki-metin" runat="server" Text='<%# Eval("Yorum_Yetki") %>'></asp:Label>
                            </div>
                            <div class="yorumlar-mesaj-box">
                                <%--client--%>
                                <asp:Label ID="lblYorum" runat="server" CssClass="yorumlar-mesaj-metin" Text='<%# Eval("Yorum_Mesaji") %>'></asp:Label>
                            </div>
                            <div class="yorumlar-cevapla-box">
                                <a href='<%# "resim-ayrinti.aspx?resim-id=" + Eval("Yorum_ID", Request.QueryString["resim-id"] + "&alt-yorum-id={0}") %>'
                                    class="yorumlar-cevapla-link">
                                    <asp:Label ID="lblCevapla" runat="server" Text="Cevapla" CssClass="yorumlar-cevapla-metin"></asp:Label></a>
                            </div>
                        </div>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                </asp:DataList>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        </asp:DataList>
        <div class="space-50"></div>
        <div id="yorum-yap" style="margin-left: 150px">
            <div class="yorum-yap-isim-box">
                <h3 class="yorum-yap-isim">Yorum Yap</h3>
            </div>
            <div>
                <div style="width: 100%; clear: both;">
                    Yorum Yapabilmeniz için Kaydolmanız gerekmektedir
                <a href="users/Kaydol" class="yorum-bilgilendirme-mesaji">Hemen Kaydolun
                </a>
                </div>
                <asp:Label ID="lblKontrol" runat="server" CssClass="yorum-bilgilendirme-mesaji"></asp:Label>
            </div>
            <div class="yorum-yap-box">
                <div class="yorum-yap-isim-box">
                    <asp:Label ID="Label1" runat="server" CssClass="yorum-yap-isim" Text="Ad-Soyad"></asp:Label>
                </div>
                <div class="yorum-yap-isim-box">
                    <asp:TextBox ID="tbAdSoyadtxt" runat="server" CssClass="yorum-yap-txt"></asp:TextBox>
                </div>
                <div class="yorum-yap-isim-box">
                    <asp:Label ID="Label2" runat="server" CssClass="yorum-yap-isim" Text="E-mail"></asp:Label>
                </div>
                <div class="yorum-yap-isim-box">
                    <asp:TextBox ID="tbEmailtxt" runat="server" CssClass="yorum-yap-txt"></asp:TextBox>
                </div>
                <div class="yorum-yap-isim-box">
                    <asp:Label ID="Label3" runat="server" CssClass="yorum-yap-isim" Text="Mesajınız"></asp:Label>
                </div>
                <div class="yorum-yap-isim-box">
                    <asp:TextBox ID="tbYorumtxt" runat="server" Height="57px" CssClass="yorum-yap-txt" TextMode="MultiLine"></asp:TextBox>
                </div>
                <div class="yorum-yap-isim-box">
                    <div>
                        <asp:Button ID="btnYorumYap" runat="server" Text="Yorum Yap" CssClass="yorum-yap-cevapla" OnClick="btnYorumYap_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <%--s--%>
</asp:Content>
