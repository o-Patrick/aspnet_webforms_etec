<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMedico.aspx.cs" Inherits="WebApplication1.frmMedico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
        Atendimento<br />
        <br />
        Cliente
        <asp:TextBox ID="txtCliente" runat="server"></asp:TextBox>
        <br />
        <br />
        Data Atendimento
        <asp:TextBox ID="txtAtend" runat="server"></asp:TextBox>
        <br />
        <br />
        Valor Consulta&nbsp;
        <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
        <br />
        <br />
        Médico
        <asp:DropDownList ID="ddlMedico" runat="server">
            <asp:ListItem>Carlos</asp:ListItem>
            <asp:ListItem>Marcel</asp:ListItem>
            <asp:ListItem>Heitor</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Especialidade <asp:DropDownList ID="ddlEsp" runat="server">
            <asp:ListItem>Cardiologista</asp:ListItem>
            <asp:ListItem>Neurologista</asp:ListItem>
            <asp:ListItem>Endocrinologista</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click" Text="Inserir" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnGeral" runat="server" Text="Cons. Geral" OnClick="btnGeral_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEsp" runat="server" OnClick="btnEsp_Click" Text="Cons. Especialidade" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAlterar" runat="server" OnClick="btnAlterar_Click" Text="Alterar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnExcluir" runat="server" OnClick="btnExcluir_Click" Text="Excluir" />
        <br />
        <br />
        <asp:GridView ID="gridConsulta" runat="server">
        </asp:GridView>
&nbsp;
    </form>
</body>
</html>
