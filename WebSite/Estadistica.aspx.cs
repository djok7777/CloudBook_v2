using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServicioLibros.Negocio;

public partial class Estadistica : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CargarEstadisticas();
    }

    private ContactoCollection listaContactos = new ContactoCollection();
    private CuentaUsuarioCollection listaUsuarios = new CuentaUsuarioCollection();
    private LibroPublicadoCollection listaPublicados = new LibroPublicadoCollection();
    private LibroComercialCollection listaComerciales = new LibroComercialCollection();

    private void CargarEstadisticas()
    {
        txtCantUsuarios.Text = listaUsuarios.UsuariosRegistrados().ToString();
        txtCantPub.Text = listaPublicados.CantidadLibros().ToString();
        txtCantOfi.Text = listaComerciales.CantidadLibros().ToString();
        txtPromPub.Text = listaPublicados.PromedioPaginasPublicaciones().ToString();
    }

    protected void btnRevisar_Click(object sender, EventArgs e)
    {
        CargarMensajes();
    }

    private void CargarMensajes()
    {
        gdMensajes.DataSource = listaContactos.ReadAll();
        gdMensajes.DataBind();
    }

    private void CargarMayorPuntuacion()
    {
        gdvMayorPuntuacion.DataSource = listaPublicados.MayorPuntuacion();
        gdvMayorPuntuacion.DataBind();
    }

    protected void gdMensajes_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gdMensajes.PageIndex = e.NewPageIndex;
        CargarMensajes();
    }

    protected void txtMayorPuntuacion_Click(object sender, EventArgs e)
    {
        CargarMayorPuntuacion();
    }

    protected void gdvMayorPuntuacion_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gdvMayorPuntuacion.PageIndex = e.NewPageIndex;
        CargarMayorPuntuacion();
    }
}