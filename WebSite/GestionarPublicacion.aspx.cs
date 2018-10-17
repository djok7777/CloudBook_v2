using System;
using System.Data;
using System.IO;
using System.Linq;
using ServicioLibros.Negocio;

public partial class GestionarPublicacion : System.Web.UI.Page
{
    private LibroPublicadoCollection librosPublicados = new LibroPublicadoCollection();
    private CuentaUsuarioCollection listaUsuarios = new CuentaUsuarioCollection();

    public CuentaUsuario MiUsuario
    {
        get
        {
            return (CuentaUsuario)Session["MiCuenta"];
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["MiCuenta"] == null)
        {
            Response.Redirect("Index.aspx");
        }

        if (!IsPostBack)
        {
            cargarComboBox();
            CargarGrid();
        }
        else
        {

        }
    }

    protected void gdvMisPublicaciones_SelectedIndexChanged(object sender, EventArgs e)
    {
        ActivarControladores(false);
        Session["IdLibro"] = gdvMisPublicaciones.SelectedRow.Cells[2].Text;
        lblInfo.Text = "¿Desea modificar o eliminar el archivo?";
        ActivarValidadores(false);
        btnEliminar.Visible = true;
        btnModificar.Visible = true;
        btnSubir.Visible = false;
    }

    protected void btnSubir_Click(object sender, EventArgs e)
    {
            int idLibro = 0;
            //ID del libro, se calcula obteniendo el idLibro del último libro registrado en base de datos y se le suma 1
            if (librosPublicados.ReadAll().Count() > 0)
            {
                idLibro = librosPublicados.ReadAll().Last().Id_libro + 1;
            }
            else {
                idLibro = 1;
            }

            LibroPublicado publicacion = new LibroPublicado();
            publicacion.Id_libro = idLibro;
            publicacion.Titulo = txtTitulo.Text;
            publicacion.Autor = txtAutor.Text;
            publicacion.Anno_publicacion = DateTime.Now.Year;
            publicacion.Categoria = ddlCategoria.SelectedIndex;
            publicacion.Descripcion = txtDescripcion.Text;
            publicacion.Cantidad_paginas = int.Parse(txtCantPaginas.Text);
            publicacion.Tipo_Estado = ddlEstado.SelectedIndex;
            publicacion.Contenido = ddlContenido.SelectedIndex;
            publicacion.Id_cuenta = MiUsuario.Id_cuenta;

            //Guarda archivo pdf a la carpeta Libros
            if (archivoSubido.HasFile)
            {
                archivoSubido.PostedFile.SaveAs(Server.MapPath("~/Libros/") + archivoSubido.FileName);
                publicacion.Pdf = archivoSubido.FileName;
            }
            //Guarda archivo jpg a la carpeta Portadas
            if (archivoPortada.HasFile)
            {
                archivoPortada.PostedFile.SaveAs(Server.MapPath("~/Portadas/") + archivoPortada.FileName);
                publicacion.Portada = archivoPortada.FileName;
            }
            else
            {
                publicacion.Portada = "~/Portadas/no_image.jpg";
            }

            publicacion.Create();
            LimpiarControladores();
            lblInfo.Text = "Libro registrado éxitosamente";
            CargarGrid();
    }

    protected void btnModificar_Click(object sender, EventArgs e)
    {
        int id_cuenta, id_libro;
        id_cuenta = MiUsuario.Id_cuenta;
        id_libro = int.Parse(gdvMisPublicaciones.SelectedRow.Cells[2].Text);
        Response.Redirect(String.Format("ModificarPublicacion.aspx?libro={0}", id_libro));
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        ActivarControladores(false);
        if (Session["IdLibro"] != null)
        {
            int idLibro = int.Parse(Session["IdLibro"].ToString());
            LibroPublicado pub = librosPublicados.ReadAll().First(l => l.Id_libro.Equals(idLibro));

            //Remueve libro del usuario en DatosBD segun idLibro de la session
            if (pub.Delete())
            {
                lblInfo.Text = "Libro eliminado con éxito";
                CargarGrid();
            }
            else
                lblInfo.Text = "No se pudo eliminar";
        }
        btnSubir.Visible = true;
        btnEliminar.Visible = false;
        btnModificar.Visible = false;
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

    protected void CargarGrid()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("Id_Libro", typeof(String));
        dt.Columns.Add("Titulo", typeof(String));
        dt.Columns.Add("Categoria", typeof(String));
        dt.Columns.Add("Autor", typeof(String));
        dt.Columns.Add("Anno_publicacion", typeof(String));
        dt.Columns.Add("Cantidad_Votos", typeof(String));
        dt.Columns.Add("Tipo_Periodicidad", typeof(String));
        dt.Columns.Add("Contenido", typeof(String));
        dt.Columns.Add("Cantidad_paginas", typeof(String));
        dt.Columns.Add("Portada", typeof(String));

        foreach (LibroPublicado publi in librosPublicados.ReadAll().Where(l=>l.Id_cuenta == MiUsuario.Id_cuenta))
        {
            dt.Rows.Add(publi.Id_libro, publi.Titulo, publi.Categoria, publi.Autor, publi.Anno_publicacion,
                publi.Cantidad_Votos, publi.Tipo_Periodicidad, publi.Contenido, publi.Cantidad_paginas, buscarPortada(publi.Portada));
        }

        gdvMisPublicaciones.DataSource = dt;
        gdvMisPublicaciones.DataBind();
    }

    //Busca imagen de portade de libros almacenados en la carpeta Portadas
    private String buscarPortada(String rutaPortada)
    {
        String ruta = "~/Portadas/";
        foreach (string strfile in Directory.GetFiles(Server.MapPath("~/Portadas")))
        {
            FileInfo fi = new FileInfo(strfile);
            if (fi.Name.Equals(rutaPortada))
            {
                //"/Portadas/" + publi.Titulo+".jpg"
                ruta += fi.Name;
                return ruta;
            }

        }
        ruta += "no_image.jpg";
        return ruta;
    }

    //Desactiva o activa controles de validacion
    protected void ActivarValidadores(bool valor)
    {
        RequiredFieldValidator1.EnableClientScript = valor;
        RequiredFieldValidator2.EnableClientScript = valor;
        RequiredFieldValidator3.EnableClientScript = valor;
        RequiredFieldValidator4.EnableClientScript = valor;
        RequiredFieldValidator5.EnableClientScript = valor;
        RequiredFieldValidator6.EnableClientScript = valor;
        RequiredFieldValidator7.EnableClientScript = valor;
        valPaginas.EnableClientScript = valor;
        archivoSubido.Enabled = false;
    }

    protected void ActivarControladores(bool valor)
    {
        archivoSubido.Enabled = valor;
        archivoPortada.Enabled = valor;
        txtTitulo.Enabled = valor;
        txtAutor.Enabled = valor;
        txtCantPaginas.Enabled = valor;
        ddlCategoria.Enabled = valor;
        ddlContenido.Enabled = valor;
        ddlEstado.Enabled = valor;
    }

    protected void LimpiarControladores()
    {
        txtTitulo.Text = String.Empty;
        txtAutor.Text = String.Empty;
        txtCantPaginas.Text = String.Empty;
        ddlCategoria.SelectedValue = CategoriaLibros.Seleccionar.ToString();
        ddlContenido.SelectedValue = TipoContenido.Seleccionar.ToString();
        ddlEstado.SelectedValue = TipoEstado.Seleccionar.ToString();
    }

}