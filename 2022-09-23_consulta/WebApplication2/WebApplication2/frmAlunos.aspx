<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAlunos.aspx.cs" Inherits="WebApplication2.frmAlunos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Cadastro de alunos"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Matrícula"></asp:Label>
&nbsp;<asp:TextBox ID="TxtMatricula" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Nome"></asp:Label>
&nbsp;<asp:TextBox ID="TxtNome" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="E-mail"></asp:Label>
&nbsp;<asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Curso"></asp:Label>
&nbsp;<asp:TextBox ID="TxtCurso" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:DropDownList ID="DdlTipo" runat="server">
                <asp:ListItem>Chamada</asp:ListItem>
                <asp:ListItem>Geral</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="BtnPesquisar" runat="server" OnClick="BtnPesquisar_Click" Text="Pesquisar" />
            <br />
            <br />
            <asp:GridView ID="GridAlunos" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
