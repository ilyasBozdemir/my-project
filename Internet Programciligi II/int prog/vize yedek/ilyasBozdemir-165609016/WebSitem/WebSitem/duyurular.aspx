<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="duyurular.aspx.cs" Inherits="WebSitem.duyurular" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<center>
    <div><h3>Duyuru Panosu</h3>
        <br />
     <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
   </div>
    </center>
</asp:Content>
