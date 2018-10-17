using System;
using System.Data;
using System.Linq;
using ServicioLibros.Negocio;

public partial class AdminEliminar : System.Web.UI.Page
{
    private LibroComercialCollection librosComerciales = new LibroComercialCollection();
    private LibroPublicadoCollection librosPublicados = new LibroPublicadoCollection();
    private CuentaUsuarioCollection usuarios = new CuentaUsuarioCollection();

    public CuentaUsuario Cuenta
    {
        get
        {
            return (CuentaUsuario)Session["MiCuenta"];
        }
        set
        {
            Session["MiCuenta"] = value;
        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Cuenta == null)
            {
                Response.Redirect("Index.aspx");
            }

            if (Cuenta.Administrador)
            {
                CargarGridPublicados();
                CargarGridComerciales();
                CargarGridUsuarios();
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }
    }

    protected void CargarGridPublicados()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("ID", typeof(String));
        dt.Columns.Add("Titulo", typeof(String));
        dt.Columns.Add("Autor", typeof(String));

        foreach (LibroPublicado publi in librosPublicados.ReadAll())
        {
            dt.Rows.Add(publi.Id_libro, publi.Titulo, publi.Autor);
        }

        gdvPublicaciones.DataSource = dt;
        gdvPublicaciones.DataBind();
    }

    protected void CargarGridComerciales()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("ID", typeof(String));
        dt.Columns.Add("Titulo", typeof(String));
        dt.Columns.Add("Autor", typeof(String));

        foreach (LibroComercial com in librosComerciales.ReadAll())
        {
            dt.Rows.Add(com.Id_libro, com.Titulo, com.Autor);
        }

        gdvComerciales.DataSource = dt;
        gdvComerciales.DataBind();
    }

    protected void CargarGridUsuarios()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("Id Cuenta", typeof(String));
        dt.Columns.Add("Usuario", typeof(String));
        dt.Columns.Add("Correo", typeof(String));
        dt.Columns.Add("Libros publicados", typeof(String));
        dt.Columns.Add("Tipo usuario", typeof(String));

        foreach (CuentaUsuario usuario in usuarios.ReadAll())
        {
            dt.Rows.Add(usuario.Id_cuenta, usuario.Nombre_cuenta, usuario.Correo, librosPublicados.ReadAll().Where(p=>p.Id_cuenta == usuario.Id_cuenta).Count()
                , (usuario.Administrador) ? "Administrador" : "Usuario");
        }

        gdvUsuarios.DataSource = dt;
        gdvUsuarios.DataBind();
    }

    protected void btnEliminarComer_Click(object sender, EventArgs e)
    {
        int idLibro = int.Parse(gdvComerciales.SelectedRow.Cells[1].Text);
        LibroComercial libcomercial = librosComerciales.ReadAll().First(l=>l.Id_libro == idLibro);

        if (libcomercial.Delete())
        {
            lblComer.Text = "Libro eliminado";
            CargarGridComerciales();
        }
        else
            lblComer.Text = "No se pudo eliminar";
        btnEliminarComer.Enabled = false;
    }

    protected void btnEliminarPubli_Click(object sender, EventArgs e)
    {
        int idLibro = int.Parse(gdvPublicaciones.SelectedRow.Cells[1].Text);
        LibroPublicado libPub = librosPublicados.ReadAll().First(l=>l.Id_libro == idLibro);

        if (libPub.Delete())
            {
                lblPubli.Text = "Publicación eliminada";
                CargarGridPublicados();
            }
            else
                lblPubli.Text = "No se pudo eliminar";
        btnEliminarPubli.Enabled = false;
    }

    protected void btnEliminarUsu_Click(object sender, EventArgs e)
    {
        int idCuenta = int.Parse(gdvUsuarios.SelectedRow.Cells[1].Text);
        CuentaUsuario cu = usuarios.ReadAll().First(c=>c.Id_cuenta == idCuenta);

        if (cu.Delete())
        {
            lblUsu.Text = "Usuario eliminado";
            CargarGridUsuarios();
        }
        else
            lblUsu.Text = "No se pudo eliminar (Asegure eliminar sus publicaciones primero)";
        btnEliminarUsu.Enabled = false;
    }

    protected void gdvComerciales_SelectedIndexChanged(object sender, EventArgs e)
    {
        btnEliminarComer.Enabled = true;
    }

    protected void gdvPublicaciones_SelectedIndexChanged(object sender, EventArgs e)
    {
        btnEliminarPubli.Enabled = true;
    }

    protected void gdvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
    {
        btnEliminarUsu.Enabled = true;
    }
}