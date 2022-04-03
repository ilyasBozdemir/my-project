<%@ Page Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="odev.WebForm1" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




<marquee direction=right class="auto-style1"> 
    <asp:DataList ID="DataList1" runat="server" DataKeyField="icerik" 
            DataSourceID="AccessDataSource1" Height="100%" Width="100%">
            <ItemTemplate>
               <asp:Label ID="duyuruLabel" runat="server" Text='<%# Eval("icerik") %>' />
                <br />
            </ItemTemplate>
        </asp:DataList>
</marquee>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/vt1_admin.mdb" SelectCommand="SELECT * FROM [duyuru]">
        </asp:AccessDataSource>
<br /><br />




<div style=" padding-left:auto; padding-right:"auto; height: 585px; width: 1055px;">

<div>
    <table class="style1">
        <tr>
            <td class="style8">
                <div style="float:left; border:1px solid red; padding:10px; margin:10px;"> <img src="resimler/div1.jpeg" style=" width:170px" /> </div>
                <div class="style12"><b style="text-align: left">EVENTS&amp;ACTIVITIES </b></div></td>
            <td class="style10">
                <div style="float:left; border:1px solid red; padding:10px; margin:10px;"> <img src="resimler/div2.jpeg" style=" width:170px" /></div>
                <div style="font-style :inherit; float:inherit; width: 284px;" align=center>
                    <b>RESTAURANTS</b></div></td>
            <td>
            
             <div style="float:left; border:1px solid red; padding:10px; margin:10px;"> <img src="resimler/div3.jpg" style=" width:170px" /></div>
                <div style="font-style :inherit; float:inherit; width: 284px;" align=center>
                    <b>WEDDING PACKAGE</b></div></td>
            
             </td>
        </tr>
        </table>
        </div>
        <div>
         <table class="style1" style="width: 102%" >
        <tr>
            <td class="style11">
                <div style="float:left; border:1px solid red; padding:10px; margin:10px;"> <img src="resimler/div4.jpeg" style=" width:170px" /> </div>
                <div class="style12"><b>SPA&amp;WELLNESS</b></div></td>
            <td class="style9">
                <div style="float:left; border:1px solid red; padding:10px; margin:10px;"> <img src="resimler/div5.jpeg" style=" width:170px" /></div>
               <div style="width: 212px" class="style13"> <b>MEETING&amp;CONGRESS </b></div> </td>
            <td>
            
          
          
            <div style="float:left; border:1px solid red; padding:10px; margin:10px;"> <img src="resimler/div6.jpg" style=" width:170px" /></div>
               <div style="width: 212px" align=center> <b>AQUA PARK</b></div>
          
         
              
              </td>
        </tr>
        </table>
   
                
</div>

</div>

</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style8
        {
            width: 316px;
        }
        .style9
        {
            width: 293px;
        }
        .style10
        {
            width: 249px;
        }
        .style11
        {
            width: 298px;
        }
        .style12
        {
            text-align: left;
        }
        .style13
        {
            text-align: center;
        }
        .auto-style1 {
            width: 947px;
            margin-top: 0px;
        }
    </style>

    </asp:Content>

