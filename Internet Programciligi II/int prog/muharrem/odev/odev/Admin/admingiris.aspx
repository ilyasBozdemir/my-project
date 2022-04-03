<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admingiris.aspx.cs" Inherits="odev.Admin._default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div style=" margin:auto; width:320px; height:226px; background-color:#FFD4AA;">
    
    <div style=" padding:15px;">
    <div style=" display:block; margin-bottom:5px; text-align:center;">
    Giriş Yap
    </div>
    
    <div style=" display:block; margin-bottom:5px;">
    Kullanıcı Adı
    </div>
    <div style=" display:block; margin-bottom:5px;">
    <asp:TextBox ID="kadi" runat="server"></asp:TextBox>
    </div>
    
    <div style=" display:block; margin-bottom:5px;">
    Şifre
    </div>
    <div style=" display:block; margin-bottom:5px;">
    <asp:TextBox ID="sifre" runat="server" TextMode="Password"></asp:TextBox>
    </div>
        <br />
        
         <div style=" display:block; margin-bottom:5px;">
    <asp:Button runat="server" Text="Giris" ID="btngiris"  Width="127px" 
                 OnClick="btngiris_Click" />
            <asp:Label ID="lblInfo" runat="server" ForeColor="#F70008"></asp:Label>
    </div>
    
    </div>
    
    </div>  
    
    
    </div>
    </form>
</body>
</html>
