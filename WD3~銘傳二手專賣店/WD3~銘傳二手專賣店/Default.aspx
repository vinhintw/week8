<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WD3_銘傳二手專賣店._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<h6><i>周年慶特價優惠中</i></h6>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="Button1" runat="server" Text="選購" OnClick="Button1_Click" />
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem>品名</asp:ListItem>
        <asp:ListItem>IPHONE6</asp:ListItem>
        <asp:ListItem>LV包</asp:ListItem>
        <asp:ListItem>KITTY時鐘</asp:ListItem>
        <asp:ListItem>小熊耳機</asp:ListItem>
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList2" runat="server">
        <asp:ListItem>最高價格</asp:ListItem>
        <asp:ListItem>不超過500元</asp:ListItem>
        <asp:ListItem>不超過5000元</asp:ListItem>
        <asp:ListItem>不超過50000元</asp:ListItem>
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList3" runat="server">
        <asp:ListItem>最低價格</asp:ListItem>
        <asp:ListItem>不低於0元</asp:ListItem>
        <asp:ListItem>不低於500元</asp:ListItem>
        <asp:ListItem>不低於5000元</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Font-Size="18pt" Height="200px" TextMode="MultiLine" Width="400px"></asp:TextBox>
</asp:Content>
