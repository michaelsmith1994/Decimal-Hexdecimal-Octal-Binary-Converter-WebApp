<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASSIG1_BinaryConverter.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href ="StyleSheet2.css" rel="stylesheet" />

</head>
<body>
        
    <form id="form1" runat="server" class="auto-style1">     
            <div class="auto-style4">
        &nbsp;
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Numeric Conversion Tool" BackColor="Black" ForeColor="Lime" CssClass="default-row-spacer"></asp:Label>
      
                <br />
      
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="From:" BackColor="White" CssClass="default-row-spacer2"></asp:Label>

        <asp:DropDownList ID="numList1" runat="server" AutoPostBack="True" ValidationGroup="dropList" CssClass="default-row-spacer2" OnSelectedIndexChanged="numList1_SelectedIndexChanged">
            <asp:ListItem>Select A Value</asp:ListItem>
            <asp:ListItem>Decimal</asp:ListItem>
            <asp:ListItem>Hexadecimal</asp:ListItem>
            <asp:ListItem>Octal</asp:ListItem>
            <asp:ListItem>Binary</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" Height="21px" Width="147px" CssClass="default-row-spacer2"></asp:TextBox>
                <br />
                &nbsp;<asp:Label ID="Label3" runat="server" Font-Bold="True" Text="To:" BackColor="White" CssClass="default-row-spacer2"></asp:Label>
                
        <asp:DropDownList ID="numList2" runat="server" AutoPostBack="True" ValidationGroup="dropList" Width="147px" Height="21px" CssClass="default-row-spacer">
        </asp:DropDownList>
       
            
            <p class="auto-style5">
            &nbsp;<asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Converted Equivalent:" BackColor="White" CssClass="auto-style5"></asp:Label>

            <asp:Label ID="result1" runat="server" BackColor="White" CssClass="auto-style4"></asp:Label>
        </p>
        <p class="auto-style5">
            <asp:Button ID="Button1" runat="server" Text="Clear" ForeColor="#FF3300" OnClick="Button1_Click" CssClass="auto-style4" Height="26px" />
<asp:Button ID="Button2" runat="server" Font-Bold="True" Text="Calculate" OnClick="Button2_Click" CssClass="auto-style4" />
            
        </p>
        
    </form>
    <p>
    </p>
</body>
</html>
