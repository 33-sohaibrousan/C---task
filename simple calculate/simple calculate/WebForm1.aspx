<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="simple_calculate.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
     
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 410px; width: 254px; color: #000000; background-color: #233342;" aria-atomic="False">
            <asp:Label ID="Label1" runat="server" Text="Calculator" Font-Size="XX-Large" ForeColor="#FF9900" ></asp:Label> <br />
            <asp:Label ID="Labelx" runat="server" Text="X :  " Font-Bold="True" ForeColor="#FF9900"></asp:Label>
                <asp:TextBox runat="server" ID="txtx" OnTextChanged="txtx_TextChanged" Width="43px"></asp:TextBox><br />
        
            
            <asp:Label ID="Labely" runat="server" Text="Y :   " Font-Bold="True" ForeColor="#FF9900"></asp:Label>
                <asp:TextBox runat="server" OnTextChanged="txty_TextChanged" ID="txty" Width="44px"></asp:TextBox>
            <br />


        <asp:Label ID="result" runat="server" Text="result :    " Font-Bold="True" ForeColor="#FF9900"></asp:Label>
                <asp:TextBox runat="server"  OnTextChanged="txtresult_TextChanged" ID="txtresult" Width="71px"></asp:TextBox>
           <br />
            <br />
            <asp:Button ID="add" runat="server" Text="+" OnClick="add_Click" />
            <asp:Button ID="sub" runat="server" Text="-" OnClick="sub_Click" />
            <asp:Button ID="mul" runat="server" Text="*" OnClick="mul_Click" style="width: 19px" />
            <asp:Button ID="div" runat="server" Text="/" OnClick="div_Click" /><br />
            <asp:Button ID="mudol" runat="server" Text="%" Width="89px" OnClick="mudol_Click" />
            <br />
            <asp:Button ID="exit" runat="server" Text="Exit" OnClick="div_Click" />
    </div>

        
    </form>
    </body>
    </html>