<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="result.aspx.cs" Inherits="AspMonteCarlo.result" %>

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
         <br />
         Wynik:
         <asp:Label ID="Label2" runat="server" Text="0"></asp:Label>
         <br />
         Czas obliczeń:
         <asp:Label ID="Label3" runat="server" Text="0"></asp:Label>
        
    
    </div>
    </form>
</body>
</html>
