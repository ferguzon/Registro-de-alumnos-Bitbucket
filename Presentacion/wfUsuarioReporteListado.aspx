<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfUsuarioReporteListado.aspx.cs" Inherits="Presentacion.wfUsuarioReporteListado" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <table class="nav-justified">
        <tr>
            <td>
                <asp:Button ID="btnCargarReporte" runat="server" OnClick="btnCargarReporte_Click" Text="Cargar reporte" />
            </td>
        </tr>
        <tr>
            <td>
                <rsweb:ReportViewer ID="rptUsuarioListado" runat="server" Width="1231px">
                </rsweb:ReportViewer>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>

    </table>


</asp:Content>
