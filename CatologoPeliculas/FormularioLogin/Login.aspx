<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FormularioLogin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="FormularioDeLogin" runat="server">
    <div>
    
    </div>
                <table style="width:100%;">
            <tr>
                <td class="auto-style1">Usuario:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtUser" runat="server" Width="207px" placeholder="&#128272;"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Contraseña:</td>
                <td class="auto-style2">
                    <asp:TextBox type="password" ID="txtPassword" runat="server" Width="207px" placeholder="&#128272;"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
