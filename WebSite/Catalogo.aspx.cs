using System;
using System.Data;
using System.IO;
using ServicioLibros.Negocio;

public partial class Catalogo : System.Web.UI.Page
{
    LibroComercialCollection listaComerciales = new LibroComercialCollection();
    LibroPublicadoCollection listaPublicados = new LibroPublicadoCollection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["MiCuenta"] == null)
        {
            gdvLibrosComerciales.AutoGenerateSelectButton = false;
            gdvLibrosPublicados.AutoGenerateSelectButton = false;
            lblInfo.Text = "Inicie sesión para acceder a los libros";
            lbRegistro.Visible = true;
        }
        else
        {
            gdvLibrosComerciales.AutoGenerateSelectButton = true;
            gdvLibrosPublicados.AutoGenerateSelectButton = true;
            lblInfo.Text = "Seleccione un libro";
            lbRegistro.Visible = false;
        }
        CargarGdvPublicados();
        CargarGdvComerciales();
    }

    protected void CargarGdvComerciales()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("Portada", typeof(String));
        dt.Columns.Add("Id_Libro", typeof(String));
        dt.Columns.Add("Titulo", typeof(String));
        dt.Columns.Add("Categoria", typeof(String));
        dt.Columns.Add("Autor", typeof(String));
        dt.Columns.Add("Cantidad_Paginas", typeof(String));
        dt.Columns.Add("Audio", typeof(String));

        foreach (LibroComercial com in listaComerciales.ReadAll())
        {
            dt.Rows.Add(buscarPortada(com.Portada), com.Id_libro, com.Titulo, (CategoriaLibros)com.Categoria, com.Autor, com.Cantidad_paginas, (com.Audio == null) ? "No" : "Si");
        }

        gdvLibrosComerciales.DataSource = dt;
        gdvLibrosComerciales.DataBind();
    }

    protected void CargarGdvPublicados(){
        DataTable dt = new DataTable();
        dt.Columns.Add("Id_Libro", typeof(String));
        dt.Columns.Add("Portada", typeof(String));
        dt.Columns.Add("Titulo", typeof(String));
        dt.Columns.Add("Categoria", typeof(String));
        dt.Columns.Add("Autor", typeof(String));
        dt.Columns.Add("Cantidad_Paginas", typeof(String));
        dt.Columns.Add("Tipo_Estado", typeof(String));
        dt.Columns.Add("Tipo_Periodicidad", typeof(String));

        foreach (LibroPublicado pub in listaPublicados.ReadAll())
        {
            dt.Rows.Add(pub.Id_libro, buscarPortada(pub.Portada), pub.Titulo, (CategoriaLibros)pub.Categoria, pub.Autor, pub.Cantidad_paginas, 
                (TipoEstado)pub.Tipo_Estado, (TipoPeriodicidad)pub.Tipo_Periodicidad);
        }
        gdvLibrosPublicados.DataSource = dt;
        gdvLibrosPublicados.DataBind();
    }

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

    protected void gdvLibrosComerciales_SelectedIndexChanged(object sender, EventArgs e)
    {
        int idLibro = int.Parse(gdvLibrosComerciales.SelectedRow.Cells[2].Text);
        Response.Redirect("PaginaLibro.aspx?libro=" + idLibro + "&&tipo=comercial");
    }

    protected void gdvLibrosPublicados_SelectedIndexChanged(object sender, EventArgs e)
    {
        int idLibro = int.Parse(gdvLibrosPublicados.SelectedRow.Cells[2].Text);
        Response.Redirect("PaginaLibro.aspx?libro=" + idLibro + "&&tipo=publicado");
    }

}