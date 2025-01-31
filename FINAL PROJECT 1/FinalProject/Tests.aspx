﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tests.aspx.cs" Inherits="FinalProject.Tests" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet1.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <p>
            Total Tests:<asp:Label ID="lbltotalcount" runat="server" Font-Bold="true"></asp:Label>
            </p>
            <asp:GridView ID="GridView1" runat="server"  Width="1121px" CellPadding="0" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" >
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CheckBoxField />
                    <asp:BoundField HeaderText="nameTest" DataField="nameTest" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:CheckBox ID="CheckBox1" runat="server"  />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
             
        </div>
       
    
    <p>&nbsp;</p>
        <div style="position:absolute;bottom:40px;">
        <h1><asp:Label ID="Label2" runat="server" Text="Add New Test"></asp:Label></h1>
        <table>
            <tr>
                <td> <asp:TextBox ID="TextBox1" runat="server" Width="240px" placeholder="Test Name"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr><td> <asp:Button ID="Button1" class="butn2" runat="server" Text="Done" OnClick="Button1_Click1" /></td></tr>
        </table>
        </div>
   </form>
</body>
</html>