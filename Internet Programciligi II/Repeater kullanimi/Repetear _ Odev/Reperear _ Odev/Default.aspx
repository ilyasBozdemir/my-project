<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Reperear___Odev._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
    <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate><!-- görüntülenecek bilgilerin başlıkları  -->
                <table border="1" >
                    <tr>
                        <th>
                            ADI
                        </th>
                        <th>
                            GÖREVİ
                        </th>
                        <th>
                            ÜCRETİ
                        </th>
                        <th>
                            İŞE BAŞLAMA TARİHİ
                        </th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate> <!-- okunan bilgilerden hangileri nerde gösterilecek  -->
                <tr>
                    <td>
                    <%#DataBinder.Eval(Container.DataItem,"ADI") %>
                       
                    </td>
                    <td>
                        <%#DataBinder.Eval(Container.DataItem, "GOREVI")%>
                    </td>
                    <td>
                        <%#DataBinder.Eval(Container.DataItem, "UCRET")%>
                    </td>
                    <td>
                        <%#DataBinder.Eval(Container.DataItem, "GIRIS_TAR")%>
                    </td><!-- www.aspnetornekleri.com  -->
                </tr>
            </ItemTemplate>
            <AlternatingItemTemplate><!-- ikinci satırda görüntülenecek bilgilerin biçimi  -->
                <tr bgcolor="#e9e9e9">
                    <td>
                        <%#DataBinder.Eval(Container.DataItem, "ADI")%>
                    </td>
                    <td>
                        <%#DataBinder.Eval(Container.DataItem, "GOREVI")%>
                    </td>
                    <td>
                        <%#DataBinder.Eval(Container.DataItem, "UCRET")%>
                    </td>
                    <td>
                        <%#DataBinder.Eval(Container.DataItem, "GIRIS_TAR")%>
                    </td>
                </tr>
            </AlternatingItemTemplate>
            <SeparatorTemplate> <!-- kayıtlar arasında çizgi  -->
                <tr>
                    <td colspan="4">
                        <hr>
                    </td>
                </tr>
            </SeparatorTemplate>
            <FooterTemplate><!-- son satırda tabloyu kapatıyoruz  -->
                </table>
            </FooterTemplate>
        </asp:Repeater>
   
    </div>
    </form>
</body>
</html>
