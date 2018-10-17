using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioLibros.Negocio
{
    public class LibroComercialCollection
    {
        private List<LibroComercial> GenerarListado(List<DALC.LibroComercial> librosComDALC)
        {

            List<LibroComercial> librosComerciales = new List<LibroComercial>();

            foreach (DALC.LibroComercial l in librosComDALC)
            {
                LibroComercial lib = new LibroComercial();
                lib.Id_libro = l.Id_libro;
                lib.Titulo = l.Titulo;
                lib.Autor = l.Autor;
                lib.Anno_publicacion = l.Anno_publicacion;
                lib.Categoria = l.Categoria;
                lib.Contenido = l.Contenido;
                lib.Descripcion = l.Descripcion;
                lib.Isbn = l.Isbn;
                lib.Editorial = l.Editorial;
                lib.Cantidad_paginas = l.Cantidad_paginas;
                lib.Portada = l.Portada;
                lib.Audio = l.Audio;
                lib.Pdf = l.Pdf;

                librosComerciales.Add(lib);
            }
            return librosComerciales;
        }

        public List<LibroComercial> ReadAll()
        {
            var LibrosComerciales = CommonBC.ModeloServicioLibros.LibroComercial;
            return GenerarListado(LibrosComerciales.ToList());
        }

        public int CantidadLibros()
        {
            int numero;
            numero = CommonBC.ModeloServicioLibros.LibroComercial.Count();
            return numero;
        }
    }
}
