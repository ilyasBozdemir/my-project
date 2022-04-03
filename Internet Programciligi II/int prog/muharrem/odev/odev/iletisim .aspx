<%@ Page Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="iletisim .aspx.cs" Inherits="odev.WebForm6" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


  
<div align=center> 
<div style="border:0px solid red;height:377px; width:100%;  " >
    
    
    
    <div style="border:0px solid red; float:left; margin-left:290px" > 
    
        Adı:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Soyad:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        Konu :&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        Mesaj&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Height="142px" TextMode="MultiLine" 
            Width="198px"></asp:TextBox>
        <br />
        <br />
        
        <asp:Button ID="Button1" runat="server" Text="Gönder" />
    </div>
    
                    </div>












</div>



















</asp:Content>
