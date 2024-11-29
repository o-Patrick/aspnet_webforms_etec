<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAlunos.aspx.cs" Inherits="Alunos.frmAlunos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Century Gothic" Font-Size="30pt" Text="Cadastro de alunos:"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Names="Century Gothic" Font-Size="15pt" Text="Nome: "></asp:Label>
&nbsp;<asp:TextBox ID="txtNome" runat="server" Width="300px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Bim. 1: " Font-Names="Glacial Indifference" Font-Size="15pt"></asp:Label>
&nbsp;<asp:TextBox ID="txtBim1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Bim. 2: "></asp:Label>
&nbsp;<asp:TextBox ID="txtBim2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Resultado"></asp:Label>
&nbsp;<asp:Label ID="lblResultado" runat="server" Text="..."></asp:Label>

            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Resultado final:"></asp:Label>
&nbsp;<asp:Label ID="lblResultadoFinal" runat="server" Text="..."></asp:Label>

        </div>
    </form>
</body>
</html>
