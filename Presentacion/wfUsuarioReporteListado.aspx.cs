using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class wfUsuarioReporteListado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnCargarReporte_Click(object sender, EventArgs e)
        {

            cargarReporte();

        }

        public void cargarReporte()
        {


            //if (!IsPostBack)
            //{

                Negocio.usuarioNegocio dc = new Negocio.usuarioNegocio();

                // establecemos el origen de los datos

                rptUsuarioListado.LocalReport.ReportEmbeddedResource = "Presentacion.rptUsuarioListado.rdlc";

                rptUsuarioListado.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("dtsUsuario", dc.obtenerListadoUsuariosNegocio()));

                // establecemos los parámetros del reporte

                rptUsuarioListado.LocalReport.SetParameters(new Microsoft.Reporting.WebForms.ReportParameter("id", "id"));

                rptUsuarioListado.LocalReport.SetParameters(new Microsoft.Reporting.WebForms.ReportParameter("login", "login"));

                rptUsuarioListado.LocalReport.SetParameters(new Microsoft.Reporting.WebForms.ReportParameter("nombre", "nombre"));

                rptUsuarioListado.LocalReport.SetParameters(new Microsoft.Reporting.WebForms.ReportParameter("fechaProceso", "fechaProceso"));

                rptUsuarioListado.LocalReport.SetParameters(new Microsoft.Reporting.WebForms.ReportParameter("correoElectronico", "correoElectronico"));

                rptUsuarioListado.LocalReport.SetParameters(new Microsoft.Reporting.WebForms.ReportParameter("correoElectronico", "correoElectronico"));
                         
                       


            //}

        }
    }
}