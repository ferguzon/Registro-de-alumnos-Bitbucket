using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class wfUsuarioPrueba : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            
            try
            {

                Negocio.usuarioNegocio dc = new Negocio.usuarioNegocio();
                Entidad.Usuarios usuario = new Entidad.Usuarios();

                usuario = dc.obtenerUsuarioNegocio(txtLoginUsuario.Text);

                if (usuario != null)
                {

                    lblResultado.Text = "El usuario sí existe";

                }
                else
                {

                    lblResultado.Text = "El usuario no existe";

                }

            }
            catch (Exception)
            {

                lblResultado.Text = "Ocurrió un error al buscar el registro";
            }

        }
    }
}