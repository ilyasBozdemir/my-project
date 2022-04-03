<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="users-chat.aspx.cs" Inherits="mySite.users_chat" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../javascript/kullanici.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>

        <script type="text/javascript">  
        $(document).ready(function() {  
            SearchText();  
        });  
        function SearchText() {  
            $("#tbUserName").autocomplete({
                source: function(request, response) {  
                    $.ajax({  
                        type: "POST",  
                        contentType: "application/json; charset=utf-8",  
                        url: "users-chat.aspx/GetUserName",
                        data: "{'userName':'" + document.getElementById('tbUserName').value + "'}",
                        dataType: "json",  
                        success: function(data) {  
                            response(data.d);  
                        },  
                        error: function(result) {  
                            alert("No Match");  
                        }  
                    });  
                }  
            });  
        }  
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--Bu alan siteiçi mesajlasmak içindir.--%>
    <div class="left-div">
        <table style="text-align: center">
            <tr>
                <th>Mesaj Gönder</th>
            </tr>
            <tr>
                <td>Kime</td>
                <td>
                    <asp:DropDownList ID="ddlKime" runat="server" Width="100"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Mesajınız:</td>
                <td>
                    <asp:TextBox ID="txtMesaj" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnGonder" runat="server" Text="Gönder.." />
                </td>
            </tr>
        </table>
    </div>
    <div class="middle-div"> <%-- gelen-giden mesajları listele--%>
        <asp:DataList ID="dlMesajlar" runat="server" OnItemDataBound="dlMesajlar_ItemDataBound">
            <ItemTemplate>
               <div class="gelen-mesaj">
                   <asp:Label ID="lblgelen" runat="server" ></asp:Label>
               </div>
            </ItemTemplate>
            <ItemTemplate>
               <div class="giden-mesaj">
                   <asp:Label ID="lblgiden" runat="server"></asp:Label>
               </div>
            </ItemTemplate>
        </asp:DataList>
        <div>
            <table>
                <tr>  
                     <td> <asp:TextBox ID="tbUserName" runat="server"></asp:TextBox></td>
                    <td><asp:Button ID="btn_Gonder" runat="server" Text="Gönder" /></td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
