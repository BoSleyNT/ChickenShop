<%@ Page Title="Book Details" Language="C#" MasterPageFile="~/Site.Master"
AutoEventWireup="true" CodeBehind="BookDetails.aspx.cs"
Inherits="ChickenShop.BookDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<asp:FormView ID="bookDetail" runat="server"
ItemType="ChickenShop.Models.Book" SelectMethod ="GetDetails"
RenderOuterTable="false">
<ItemTemplate>
<div>
<h1><%#:Item.BookName %></h1>
</div>
<br />
<table>
<tr>
<td>
<img src="/Images/<%#:Item.ImagePath %>"
style="border:solid; height:225px" alt="<%#:Item.BookName %>"/>
</td>
<td>&nbsp;</td>
<td style="vertical-align: top; text-align:left;">
<b>Thông tin về gà:</b><br /><%#:Item.Description %>
<br />
<span><b>Giá:</b>&nbsp;<%#: String.Format("{0:g} $",Item.UnitPrice)
%></span>
<br />
<span><b>Số lượng gà:</b>&nbsp;<%#:Item.BookID %></span>
<br />
</td>
</tr>
</table>
</ItemTemplate>
</asp:FormView>
</asp:Content>