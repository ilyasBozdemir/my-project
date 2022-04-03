<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="slider-ayrinti.aspx.cs" Inherits="mySite.slider_ayrinti1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       <script src="../javascript/kullanici.js"></script><%-- slider ve govde sagı gizlemek istedigin sayfaya ekle :) --%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div style="width: 1000px; height: auto;">
                    <div style="margin-left: 350px">
                        <asp:Image ID="imgSlider" runat="server" Width="300" Height="93.33" />
                        <div>
                            <asp:Label ID="lblSliderAdi" runat="server"></asp:Label>
                        </div>
                        <div>
                            <asp:Label ID="lblSliderAciklama" runat="server"></asp:Label>
                        </div>
                    </div>
                </div>
</asp:Content>
