using System;
using System.Linq;
using ServicioLibros.Negocio;

public partial class ModificarPublicacion : System.Web.UI.Page
{
    private LibroPublicadoCollection librosPublicados = new LibroPublicadoCollection();

    public CuentaUsuario MiUsuario
    {
        get
        {
            return (CuentaUsuario)Session["MiCuenta"];
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["MiCuenta"] == null || Request.Params["libro"] == null)
        {
            Response.Redirect("Index.aspx");
        }
        if (!IsPostBack)
        {
            pnlDatosLibro.BorderStyle = System.Web.UI.WebControls.BorderStyle.Dotted;
            cargarComboBox();
            CargarDatosLibro();
        }
    }

    protected void btnActualizar_Click(object sender, EventArgs e)
    {
        int idLibro = int.Parse(Request.Params["libro"]);
        LibroPublicado pub = librosPublicados.ReadAll().First(p=>p.Id_libro == idLibro);
        String titulo = pub.Titulo;

        try
        {
            pub.Autor = txtAutor.Text;
            pub.Categoria = ddlCategoria.SelectedIndex;
            pub.Descripcion = txtDescripcion.Text;
            pub.Cantidad_paginas = int.Parse(txtCantPaginas.Text);
            pub.Tipo_Estado = ddlEstado.SelectedIndex;
            pub.Contenido = ddlContenido.SelectedIndex;

            if (archivoPDF.HasFile)
            {
                archivoPDF.PostedFile.SaveAs(Server.MapPath("~/Libros/") + archivoPDF.FileName);            //Guarda archivo pdf a la carpeta Libros
                pub.Pdf = archivoPDF.FileName;
            }
            if (archivoPortada.HasFile)
            {
                archivoPortada.PostedFile.SaveAs(Server.MapPath("~/Portadas/") + archivoPortada.FileName);  //Guarda archivo jpg a la carpeta Portadas
                pub.Portada = archivoPortada.FileName;
            }

            pub.Update();
            lblInfo.Text = "Libro actualizado";
        }
        catch (Exception ex)
        {
            lblInfo.Text = "Error " + ex.Message;
        }

    }

    private void CargarDatosLibro()
    {
        int id_libro = int.Parse(Request.Params["libro"]);
        LibroPublicado pub = librosPublicados.ReadAll().First(p=>p.Id_libro == id_libro);
        txtAutor.Text = pub.Autor;
        txtCantPaginas.Text = pub.Cantidad_paginas.ToString();
        ddlCategoria.SelectedIndex = pub.Categoria;
        ddlContenido.SelectedIndex = pub.Contenido;
        ddlEstado.SelectedIndex = pub.Tipo_Estado;
    }

    private void cargarComboBox()
    {
        ddlCategoria.DataSource = Enum.GetValues(typeof(CategoriaLibros));
        ddlContenido.DataSource = Enum.GetValues(typeof(TipoContenido));
        ddlEstado.DataSource = Enum.GetValues(typeof(TipoEstado));
        ddlCategoria.DataBind();
        ddlContenido.DataBind();
        ddlEstado.DataBind();
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("GestionarPublicacion.aspx");
    }

}