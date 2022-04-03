<%@ Page Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="Duyurular.aspx.cs" Inherits="odev.Admin.WebForm1" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div>
    <div  style=" margin:auto; width:440px; padding:30px;  background-color:#FFD4AA;">
    
         <table>
        <tbody><tr>
            <td>
                 Duyuru Ekle 
            </td>
            <td>
                 </td>
            <td>
            <asp:label id="Label1" runat="server" ForeColor="#009933"></asp:label>
                 </td>
        </tr>
        <tr>
            <td>
               
            </td>
            <td >
                 </td>
            <td>
                 </td>
        </tr>
        <tr>
            <td>
                Başlık</td>
            <td >
                :</td>
            <td>
                <asp:textbox id="baslik1" runat="server" width="200px"></asp:textbox>
            </td>
        </tr>
       
        <tr>
            <td>
                İçerik</td>
            <td >
                :</td>
            <td >
                <asp:textbox id="icerik1" runat="server" width="200px"></asp:textbox></td>
        </tr>
     
        <tr>
            <td >
                 
            <td >
                 </td>
            <td>
                <br />
                <asp:button id="Button4" runat="server" style="font-weight: 700" 
                    text="Duyuru Ekle" OnClick="Button4_Click">
            </asp:button>
            </td> 
        </tr>
    </tbody></table>
    </div>
    </div>
   <br />
   <br />
     
    <div>
    <div  style=" margin:auto; width:440px; padding:30px;  background-color:#FFD4AA;">
    
         Duyuru Güncelle <asp:label id="lblHata" runat="server"></asp:label>
         <br />
                <asp:GridView ID="GridView1" runat="server" Width="400px" HorizontalAlign="Center"
            AutoGenerateColumns="false" AllowPaging="false" DataKeyNames="id" ShowFooter="true">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="chksec" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:BoundField DataField="id" HeaderText="ID" />
                <asp:BoundField DataField="baslik" HeaderText="BAŞLIK" />
                <asp:BoundField DataField="icerik" HeaderText="İÇERİK" />
            </Columns>
        </asp:GridView>
        <asp:Button runat="server" Text="Seçilileri Sil" ID="btnsil" 
             onclick="btnsil_Click"/>
         </div>
    </div>
</asp:Content>
