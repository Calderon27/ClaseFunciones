<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testWeb.aspx.cs" Inherits="FunWeb.testWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label3" runat="server" Text="Por favor ingrese un número entero      :"></asp:Label>
            <asp:TextBox ID="txtNumero1" runat="server" Width="47px"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnParImpar" runat="server" OnClick="Button1_Click" Text="Par o Impar" />
            <asp:TextBox ID="txtR1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label7" runat="server">Por favor ingresar un mes en numeros   :</asp:Label>
            <asp:TextBox ID="txtNumero2" runat="server" Width="48px"></asp:TextBox>
            <br />
            <asp:Label ID="Label8" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnVerificar" runat="server" OnClick="Button2_Click" Text="Verificar Mes" />
            <asp:TextBox ID="txtR2" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
