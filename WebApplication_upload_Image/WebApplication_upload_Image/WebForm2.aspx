<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication_upload_Image.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:dbString %>" 
            SelectCommand="SELECT * FROM [ImageTable]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
        <asp:DataList ID="DataList1" runat="server" BackColor="White" 
            BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
            DataSourceID="SqlDataSource1" GridLines="Horizontal" RepeatColumns="43" 
            Height="244px" Width="896px">
            <AlternatingItemStyle BackColor="#F7F7F7" />
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <ItemTemplate>
                <br />
                ItemName:<asp:Label ID="ItemNameLabel" runat="server" 
                    Text='<%# Eval("ItemName") %>' />
                <br />
                Notes:<asp:Label ID="NotesLabel" runat="server" Text='<%# Eval("Notes") %>' />
                <br />
                Location:<asp:Label ID="LocationLabel" runat="server" 
                    Text='<%# Eval("Location") %>' />
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Buy" onclick="Button1_Click" />
                <br />
                &nbsp;<br />
                <br />
                <asp:Image ID="Image1" runat="server" 
                    ImageUrl='<%# "~/storage/"+Eval("ImageName") %>'  Height="400px" Width="400px"/>
                &nbsp;<br />ImageName:
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("ImageName") %>'></asp:TextBox>
                <br />
                <br />
                <br />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        </asp:DataList>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
