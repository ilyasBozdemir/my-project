<%@ Page Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="Oda.aspx.cs" Inherits="odev.Admin.WebForm2" Title="Untitled Page" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" > 
 <div>
    <div  style=" margin:auto; width:440px; padding:30px;  background-color:#FFD4AA;">
    
     <table>
        <tbody><tr>
            <td>
                Oda Ekle 
            </td>
            <td>
                 </td>
            <td class="style1">
            <asp:label id="Label1" runat="server" ForeColor="#009933"></asp:label>
                 </td>
        </tr>
        <tr>
            <td>
               
            </td>
            <td >
                 </td>
            <td class="style1">
                 </td>
        </tr>
       
        <tr>
            <td>
               Oda Adı</td>
            <td >
                :</td>
            <td class="style1">
                <asp:textbox id="txtodaadi" runat="server" width="200px"></asp:textbox>
            </td>
        </tr>
       
        <tr>
            <td>
                Fiyatı</td>
            <td >
                :</td>
            <td class="style1" >
                <asp:textbox id="txtfiyat" runat="server" width="200px"></asp:textbox>
                
        </tr>
     
      <tr>
      
            <td>
            <br />
                Resim Seç:</td>
            <td>
            <br />
                :</td>
            <td class="style1">
            
                <asp:FileUpload ID="odaresmi" runat="server" />
                <br />
                
            </td>
        </tr>
       
        <tr>
            <td >
                 &nbsp;</td>
            <td >
                 </td>
            <td class="style1">
                <br />
                <asp:button id="Button4" runat="server" style="font-weight: 700" 
                    text="Oda Ekle" OnClick="Button4_Click">
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
    
        Oda Sil <asp:label id="lblHata" runat="server"></asp:label>
         <br />
         
      
                
            

                <asp:GridView ID="GridView1" runat="server" Width="400px" HorizontalAlign="Center"
            AutoGenerateColumns="false" AllowPaging="false" DataKeyNames="oda_id" ShowFooter="true">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="chksec" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:BoundField DataField="oda_id" HeaderText="ID" />
                <asp:BoundField DataField="oda_adi" HeaderText="Oda Adı" />
                <asp:BoundField DataField="fiyat" HeaderText="Fiyat" />
                <asp:BoundField DataField="resim" HeaderText="Resim" />
           
            </Columns>
        </asp:GridView>
        <asp:Button runat="server" Text="Seçilileri Sil" ID="btnsil" onclick="btnsil_Click" 
              />
                
    
    </div> 
    </div>


</asp:Content>



<asp:Content ID="Content1" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style1
        {
            width: 235px;
        }
    </style>

</asp:Content>
