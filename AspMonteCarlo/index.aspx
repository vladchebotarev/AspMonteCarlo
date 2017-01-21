<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="AspMonteCarlo.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: x-large; color: #333333; text-align: center;">
    
        <br />
        Program liczący calkę z sin(x) za pomocą metody Monte Carlo<br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="30px"  Width="230px" style ="margin-bottom: 10px;" placeholder = "Od"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Height="30px"  Width="230px" style ="margin-bottom: 10px;" placeholder = "Do"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox3" runat="server" Height="30px" Width="230px" style ="margin-bottom: 10px;" placeholder = "Liczba wątków"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox4" runat="server" Height="30px" Width="230px" style ="margin-bottom: 10px;" placeholder = "Liczba iteracji"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Height="35px" OnClick="Button1_Click" Text="Licz" Width="127px" />
        <br />
    
    </div>
    </form>
</body>
</html>
