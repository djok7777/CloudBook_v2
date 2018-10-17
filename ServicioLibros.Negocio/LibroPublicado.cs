using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioLibros.Negocio
{
    public class LibroPublicado
    {
        public int Id_libro { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Anno_publicacion { get; set; }
        public int Categoria { get; set; }
        public int Contenido { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad_paginas { get; set; }
        public int Cantidad_Votos { get; set; }
        public int Tipo_Estado { get; set; }
        public int Tipo_Periodicidad { get; set; }
        public string Portada { get; set; }
        public string Pdf { get; set; }
        public int Id_cuenta { get; set; }

        public LibroPublicado()
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
            Cantidad_paginas = 0;
            Cantidad_Votos = 0;
            Tipo_Estado = 0;
            Tipo_Periodicidad = 0;
            Portada = string.Empty;
            Pdf = string.Empty;
            Id_cuenta = 0;
        }

        //Métodos CRUD
        public bool Create()
        {
            try
            {
                DALC.LibroPublicado lib = new DALC.LibroPublicado();
                lib.Id_libro = Id_libro;
                lib.Titulo = Titulo;
                lib.Autor = Autor;
                lib.Anno_publicacion = Anno_publicacion;
                lib.Categoria = Categoria;
                lib.Contenido = Contenido;
                lib.Descripcion = Descripcion;
                lib.Cantidad_paginas = Cantidad_paginas;
                lib.Cantidad_Votos = Cantidad_Votos;
                lib.Tipo_Estado = Tipo_Estado;
                lib.Tipo_Periodicidad = Tipo_Periodicidad;
                lib.Portada = Portada;
                lib.Pdf = Pdf;
                lib.Id_cuenta = Id_cuenta;

                CommonBC.ModeloServicioLibros.LibroPublicado.Add(lib);
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
                DALC.LibroPublicado lib = CommonBC.ModeloServicioLibros.LibroPublicado.First(l => l.Id_libro == Id_libro);

                Autor = lib.Autor;
                Anno_publicacion = lib.Anno_publicacion;
                Categoria = lib.Categoria;
                Contenido = lib.Contenido;
                Descripcion = lib.Descripcion;
                Cantidad_paginas = lib.Cantidad_paginas;
                Cantidad_Votos = lib.Cantidad_Votos;
                Tipo_Estado = lib.Tipo_Estado;
                Tipo_Periodicidad = lib.Tipo_Periodicidad;
                Portada = lib.Portada;
                Pdf = lib.Pdf;
                Id_cuenta = lib.Id_cuenta;

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
                DALC.LibroPublicado lib = CommonBC.ModeloServicioLibros.LibroPublicado.First(l => l.Id_libro == Id_libro);
                lib.Titulo = Titulo;
                lib.Autor = Autor;
                lib.Anno_publicacion = Anno_publicacion;
                lib.Categoria = Categoria;
                lib.Contenido = Contenido;
                lib.Descripcion = Descripcion;
                lib.Cantidad_paginas = Cantidad_paginas;
                lib.Cantidad_Votos = Cantidad_Votos;
                lib.Tipo_Estado = Tipo_Estado;
                lib.Tipo_Periodicidad = Tipo_Periodicidad;
                lib.Portada = Portada;
                lib.Pdf = Pdf;
                lib.Id_cuenta = Id_cuenta;

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
                DALC.LibroPublicado lib = CommonBC.ModeloServicioLibros.LibroPublicado.First(l => l.Id_libro == Id_libro);
                CommonBC.ModeloServicioLibros.LibroPublicado.Remove(lib);
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
