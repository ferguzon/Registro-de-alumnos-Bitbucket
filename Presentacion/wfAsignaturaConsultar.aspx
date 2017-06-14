<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfAsignaturaConsultar.aspx.cs" Inherits="Presentacion.wfAsignaturaConsultar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <table class="nav-justified">
        <tr>
            <td>&nbsp;</td>
            <asp:GridView ID="gvAsignatura" runat="server"> </asp:GridView>
            <td>&nbsp;</td>
        </tr>
        
    </table>
    
</asp:Content>
