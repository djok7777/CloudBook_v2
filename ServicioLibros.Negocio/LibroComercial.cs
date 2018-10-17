using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioLibros.Negocio
{
    public class LibroComercial
    {
        public int Id_libro { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Anno_publicacion { get; set; }
        public int Categoria { get; set; }
        public int Contenido { get; set; }
        public string Descripcion { get; set; }
        public string Isbn { get; set; }
        public string Editorial { get; set; }
        public int Cantidad_paginas { get; set; }
        public string Portada { get; set; }
        public string Audio { get; set; }
        public string Pdf { get; set; }

        public LibroComercial()
        {
            this.Init();
        }

        private void Init()
        {
            Id_libro = 0;
            Titulo = string.Empty;
            Autor = string.Empty;
            Anno_publicacion = 0;
            Categoria = 0;
            Contenido = 0;
            Descripcion = string.Empty;
            Isbn = string.Empty;
            Editorial = string.Empty;
            Cantidad_paginas = 0;
            Portada = string.Empty;
            Audio = string.Empty;
            Pdf = string.Empty;
        }

        //Métodos CRUD
        public bool Create()
        {
            try
            {
                DALC.LibroComercial lib = new DALC.LibroComercial();
                lib.Id_libro = Id_libro;
                lib.Titulo = Titulo;
                lib.Autor = Autor;
                lib.Anno_publicacion = Anno_publicacion;
                lib.Categoria = Categoria;
                lib.Contenido = Contenido;
                lib.Descripcion = Descripcion;
                lib.Isbn = Isbn;
                lib.Editorial = Editorial;
                lib.Cantidad_paginas = Cantidad_paginas;
                lib.Portada = Portada;
                lib.Audio = Audio;
                lib.Pdf = Pdf;

                CommonBC.ModeloServicioLibros.LibroComercial.Add(lib);
                CommonBC.ModeloServicioLibros.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                DALC.LibroComercial lib = CommonBC.ModeloServicioLibros.LibroComercial.First(l=>l.Id_libro == Id_libro);

                Titulo = lib.Titulo;
                Autor = lib.Autor;
                Anno_publicacion = lib.Anno_publicacion;
                Categoria = lib.Categoria;
                Contenido = lib.Contenido;
                Descripcion = lib.Descripcion;
                Isbn = lib.Isbn;
                Editorial = lib.Editorial;
                Cantidad_paginas = lib.Cantidad_paginas;
                Portada = lib.Portada;
                Audio = lib.Audio;
                Pdf = lib.Pdf;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                DALC.LibroComercial lib = CommonBC.ModeloServicioLibros.LibroComercial.First(l => l.Id_libro == Id_libro);
                lib.Titulo = Titulo;
                lib.Autor = Autor;
                lib.Anno_publicacion = Anno_publicacion;
                lib.Categoria = Categoria;
                lib.Contenido = Contenido;
                lib.Descripcion = Descripcion;
                lib.Isbn = Isbn;
                lib.Editorial = Editorial;
                lib.Cantidad_paginas = Cantidad_paginas;
                lib.Portada = Portada;
                lib.Audio = Audio;
                lib.Pdf = Pdf;

                CommonBC.ModeloServicioLibros.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                DALC.LibroComercial lib = CommonBC.ModeloServicioLibros.LibroComercial.First(l => l.Id_libro == Id_libro);
                CommonBC.ModeloServicioLibros.LibroComercial.Remove(lib);
                CommonBC.ModeloServicioLibros.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
