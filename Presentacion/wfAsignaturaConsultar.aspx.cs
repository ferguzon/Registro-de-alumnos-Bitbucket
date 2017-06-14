using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class wfAsignaturaConsultar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarAsignaturas();
        
        }

        private void CargarAsignaturas()
        {
            Negocio.asignaturaNegocio dc = new Negocio.asignaturaNegocio();
            gvAsignatura.DataSource = dc.obtenerAsignaturaNegocio();
            gvAsignatura.DataBind();
        }
       


    }
}