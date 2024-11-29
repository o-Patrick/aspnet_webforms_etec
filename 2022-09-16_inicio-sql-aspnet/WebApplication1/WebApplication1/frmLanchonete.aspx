<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLanchonete.aspx.cs" Inherits="WebApplication1.frmLanchonete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblComanda" runat="server" Text="Comanda: "></asp:Label>
&nbsp;<asp:TextBox ID="txtComanda" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblNome" runat="server" Text="Nome: "></asp:Label>
&nbsp;<asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblGenero" runat="server" Text="Gênero"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbMasculino" runat="server" GroupName="genero" Text="Masculino" />
&nbsp;&nbsp;
            <asp:RadioButton ID="rdbFeminino" runat="server" GroupName="genero" Text="Feminino" />
            <br />
            <br />
            <asp:Label ID="lblDescricao" runat="server" Text="Descrição"></asp:Label>
&nbsp;<asp:Label ID="lblValor" runat="server" Text="Valor"></asp:Label>
&nbsp;<asp:Label ID="lblQuantidade" runat="server" Text="Quantidade"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblSalgado" runat="server" Text="Salgado"></asp:Label>
&nbsp;<asp:Label ID="lblValorSalgado" runat="server" Text="5.0"></asp:Label>
&nbsp;<asp:TextBox ID="txtQuantidadeSalgado" runat="server">0</asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblBebidas" runat="server" Text="Bebidas"></asp:Label>
&nbsp;<asp:Label ID="lblValorBebidas" runat="server" Text="5.0"></asp:Label>
&nbsp;<asp:TextBox ID="txtQuantidadeBebidas" runat="server">0</asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblOutros" runat="server" Text="Outros"></asp:Label>
&nbsp;<asp:Label ID="lblValorOutros" runat="server" Text="5.0"></asp:Label>
&nbsp;<asp:TextBox ID="txtQuantidadeOutros" runat="server">0</asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnFechamento" runat="server" OnClick="btnFechamento_Click" Text="Fechamento" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Resultado"></asp:Label>
&nbsp;<asp:TextBox ID="txtResultado" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
