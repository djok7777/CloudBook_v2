using BibliotecaDeClases;
using System;
using System.Linq;
using System.Net;

public partial class PaginaLibro : System.Web.UI.Page
{
    ServicioLibros.Negocio.LibroComercialCollection librosComerciales = new ServicioLibros.Negocio.LibroComercialCollection();
    ServicioLibros.Negocio.LibroPublicadoCollection librosPublicados = new ServicioLibros.Negocio.LibroPublicadoCollection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            String tipo;
            if (Request.Params["libro"] == null)
            {
                Response.Redirect("Index.aspx");
            }
            else
            {
                tipo = Request.Params["tipo"];
                if (tipo.Equals("comercial"))
                {
                    CargarLibroComercial();
                }
                else
                {
                    CargarLibroPublicado();
                    audio_player.Visible = false;
                }
            }
        }
    }

    private void CargarLibroComercial()
    {
        int idLibro = int.Parse(Request.Params["libro"]);
        ServicioLibros.Negocio.LibroComercial com = librosComerciales.ReadAll().First(l=>l.Id_libro == idLibro);

        imgPortada.ImageUrl = "/Portadas/" + com.Portada;
        lblAutor.Text = com.Autor;
        lblTitulo.Text = com.Titulo;
        lblDescripcion.Text = com.Descripcion;
        lblFecha.Text = com.Anno_publicacion.ToString();
        lblCategoria.Text = com.Categoria.ToString();
        lblPaginas.Text = com.Cantidad_paginas.ToString();
        CargarAudio(idLibro);
    }

    private void CargarLibroPublicado()
    {
        int idLibro = int.Parse(Request.Params["libro"]);
        ServicioLibros.Negocio.LibroPublicado pub = librosPublicados.ReadAll().First(p=>p.Id_libro == idLibro);

        imgPortada.ImageUrl = "/Portadas/" + pub.Portada;
        lblAutor.Text = pub.Autor;
        lblTitulo.Text = pub.Titulo;
        lblDescripcion.Text = pub.Descripcion;
        lblFecha.Text = pub.Anno_publicacion.ToString();
        lblCategoria.Text = pub.Categoria.ToString();
        lblPaginas.Text = pub.Cantidad_paginas.ToString();
        lblVotos.Text = pub.Cantidad_Votos.ToString() + " votos";
        ImageButton1.Visible = true;
    }

    protected void CargarAudio(int idLibro)
    {
        String rutaAudio = librosComerciales.ReadAll().First(l=>l.Id_libro == idLibro).Audio;
        audio_player.Attributes["src"] = "LibroAudio/" + rutaAudio;
    }

    protected void btnLeerPDF_Click(object sender, EventArgs e)
    {
        String rutaPDF;
        int idLibro = int.Parse(Request.Params["libro"]);
        String tipo = Request.Params["tipo"];
        if (tipo.Equals("comercial"))
        {
            rutaPDF = librosComerciales.ReadAll().First(l => l.Id_libro == idLibro).Pdf;
        }
        else
        {
            rutaPDF = librosPublicados.ReadAll().First(p => p.Id_libro == idLibro).Pdf;
        }

        AbrirPdf(rutaPDF);
    }

    protected void AbrirPdf(String rutaPDF)
    {
        try
        {
            string FilePath = Server.MapPath("Libros/" + rutaPDF);
            WebClient User = new WebClient();
            Byte[] FileBuffer = User.DownloadData(FilePath);
            if (FileBuffer != null)
            {
                Response.ContentType = "application/pdf";
                Response.AddHeader("content-length", FileBuffer.Length.ToString());
                Response.BinaryWrite(FileBuffer);
            }
        }
        catch (Exception)
        {
            string FilePath = Server.MapPath("Libros/sample.pdf");
            WebClient User = new WebClient();
            Byte[] FileBuffer = User.DownloadData(FilePath);
            if (FileBuffer != null)
            {
                Response.ContentType = "application/pdf";
                Response.AddHeader("content-length", FileBuffer.Length.ToString());
                Response.BinaryWrite(FileBuffer);
            }
        }
    }
}