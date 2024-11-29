<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAlunos.aspx.cs" Inherits="WebApplication1.frmAlunos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
&nbsp;<asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Nota 1"></asp:Label>
&nbsp;<asp:TextBox ID="txtNota1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Nota 2"></asp:Label>
&nbsp;<asp:TextBox ID="txtNota2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Nota 3"></asp:Label>
&nbsp;<asp:TextBox ID="txtNota3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Resultado"></asp:Label>
&nbsp;<asp:TextBox ID="txtResultado" runat="server" ReadOnly="True"></asp:TextBox>
        </div>
    </form>
</body>
</html>
