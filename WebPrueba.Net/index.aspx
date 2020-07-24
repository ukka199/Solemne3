<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebPrueba.Net.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblmonto1" runat="server" Text="Monto 1"></asp:Label>
        </div>
        <p>
            <asp:TextBox type="number" ID="txtmonto1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblmonto2" runat="server" Text="Monto 2"></asp:Label>
        </p>
        <p>
            <asp:TextBox type="number" ID="txtmonto2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" />
        </p>
        <asp:Label ID="lblResultado" runat="server" OnLoad="btnCalcular_Click" Text="Label"></asp:Label>
    </form>
</body>
</html>
