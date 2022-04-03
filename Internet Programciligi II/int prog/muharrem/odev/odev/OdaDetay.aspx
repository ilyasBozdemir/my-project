<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OdaDetay.aspx.cs" Inherits="odev.OdaDetay" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 50%;
           
        }
    </style>
</head>

<body bgcolor="#99ccff" >
    <form id="form1" runat="server">
    <div >
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/vt1_admin.mdb" 
            
            SelectCommand="SELECT * FROM [odalar] WHERE ([oda_id] = ?) ORDER BY [oda_id] DESC">
            <SelectParameters>
                <asp:QueryStringParameter Name="oda_id" QueryStringField="odaid" Type="Int32" />
            </SelectParameters>
        </asp:AccessDataSource>
        
        <br />
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="AccessDataSource1">
        <ItemTemplate>
        
        
        <table width="500" style="align:center" class="style1">
            <tr>
                <td rowspan="3">
                   <img width="400" height="250" src="<%#Eval("resim") %>" />
                </td>
                <td>
                    <asp:Literal ID="Literal2" Text=<%#Eval("oda_adi") %> runat="server"></asp:Literal>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Literal ID="Literal1" Text=<%#Eval("fiyat") %> runat="server"></asp:Literal>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Literal ID="Literal3" Text=<%#Eval("oda_aciklamasi") %> runat="server"></asp:Literal>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>

</html>
