<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPets.aspx.cs" Inherits="WebApplication1.frmPets" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblPets" runat="server" Font-Bold="True" Font-Names="Engravers MT" Text="Pets"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblEspecie" runat="server" Font-Bold="True" Text="Espécie"></asp:Label>
&nbsp;<asp:DropDownList ID="ddlEspecie" runat="server" OnSelectedIndexChanged="ddlEspecie_SelectedIndexChanged" AutoPostBack="True" BackColor="#FFFF99">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblRaca" runat="server" Font-Bold="True" Text="Raça"></asp:Label>
&nbsp;<asp:DropDownList ID="ddlRaca" runat="server" BackColor="#FFFF99">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblPet" runat="server" Font-Bold="True" Text="Pet"></asp:Label>
&nbsp;<asp:TextBox ID="txtPet" runat="server" BackColor="#FFFF99"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblSexo" runat="server" Font-Bold="True" Text="Sexo"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbFemea" runat="server" Text="Fêmea" GroupName="rdbSexo" />
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="rdbMacho" runat="server" Text="Macho" GroupName="rdbSexo" />
            <br />
            <br />
            <asp:Label ID="lblServico" runat="server" Font-Bold="True" Text="Serviço"></asp:Label>
            <br />
            <asp:CheckBox ID="chkBanho" runat="server" Text="Banho" />
&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="chkCastracao" runat="server" Text="Castração" />
&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="chkTosa" runat="server" Text="Tosa" />
            <br />
            <br />
            <asp:Button ID="btnRecibo" runat="server" OnClick="btnRecibo_Click" Text="Recibo" BackColor="#FFFF99" ForeColor="Black" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Valor total: "></asp:Label>
&nbsp;<asp:Label ID="lblValorTotal" runat="server" Text="..."></asp:Label>
        </div>
    </form>
</body>
</html>
