<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="mySite.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- <div class="picture-curtain-hover"></div> --%>
    <%--1.secenek--%>
    
    <div >
        <div class="new-row">
            <div class="align-left">
                <a href="<%:"Resim_ayrıntı?resim-id=" +resimID[0]%>">
                    <asp:Image ID="Image1" runat="server" /></a>
            </div>
            <div class="align-center">
                <a href="<%:"Resim_ayrıntı?resim-id="+resimID[1]%>">
                    <asp:Image ID="Image2" runat="server" /></a>
            </div>
            <div class="align-right">
                <a href="<%:"Resim_ayrıntı?resim-id="+resimID[2]%>">
                    <asp:Image ID="Image3" runat="server" /></a>
            </div>
        </div>
        <div class="new-row">
            <div class="align-left">
                <a href="<%:"Resim_ayrıntı?resim-id="+resimID[3]%>">
                    <asp:Image ID="Image4" runat="server" /></a>
            </div>
            <div class="align-center">
                <a href="<%:"Resim_ayrıntı?resim-id="+resimID[4]%>">
                    <asp:Image ID="Image5" runat="server" /></a>
            </div>
            <div class="align-right">
                <a href="<%:"Resim_ayrıntı?resim-id="+resimID[5]%>">
                    <asp:Image ID="Image6" runat="server" /></a>
            </div>
        </div>
        <div class="new-row">
            <div class="align-left">
                <a href="<%:"Resim_ayrıntı?resim-id="+resimID[6]%>">
                    <asp:Image ID="Image7" runat="server" /></a>
            </div>
            <div class="align-center">
                <a href="<%:"Resim_ayrıntı?resim-id="+resimID[7]%>">
                    <asp:Image ID="Image8" runat="server" /></a>
            </div>
            <div class="align-right">
                <a href="<%:"Resim_ayrıntı?resim-id="+resimID[8]%>">
                    <asp:Image ID="Image9" runat="server" /></a>
            </div>
        </div>
    </div>
    <%--2.secenek--%>

    <div class="new-row" >
        <asp:Table ID="Table1" runat="server">
        </asp:Table>
    </div>
</asp:Content>
