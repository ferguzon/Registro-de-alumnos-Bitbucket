<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfUsuarioPrueba.aspx.cs" Inherits="Presentacion.wfUsuarioPrueba" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <table class="nav-justified">
        <tr>
            <td style="width: 316px">Nombre de login del usuario</td>
            <td>
                <asp:TextBox ID="txtLoginUsuario" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 316px">&nbsp;</td>
            <td>
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
&nbsp;<asp:Label ID="lblResultado" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
