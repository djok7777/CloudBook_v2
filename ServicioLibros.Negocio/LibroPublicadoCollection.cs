using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioLibros.Negocio
{
    public class LibroPublicadoCollection
    {
        private List<LibroPublicado> GenerarListado(List<DALC.LibroPublicado> librosPubDALC) {
            List<LibroPublicado> librosPublicados = new List<LibroPublicado>();

            foreach (DALC.LibroPublicado p in librosPubDALC)
            {
                LibroPublicado pub = new LibroPublicado();
                pub.Id_libro = p.Id_libro;
                pub.Titulo = p.Titulo;
                pub.Autor = p.Autor;
                pub.Anno_publicacion = p.Anno_publicacion;
                pub.Categoria = p.Categoria;
                pub.Contenido = p.Contenido;
                pub.Descripcion = p.Descripcion;
                pub.Cantidad_paginas = p.Cantidad_paginas;
                pub.Cantidad_Votos = p.Cantidad_Votos;
                pub.Tipo_Estado = p.Tipo_Estado;
                pub.Tipo_Periodicidad = p.Tipo_Periodicidad;
                pub.Portada = p.Portada;
                pub.Pdf = p.Pdf;
                pub.Id_cuenta = p.Id_cuenta;

                librosPublicados.Add(pub);
            }
            return librosPublicados;
        }

        public List<LibroPublicado> ReadAll() {
            var librosPublicados = CommonBC.ModeloServicioLibros.LibroPublicado;
            return GenerarListado(librosPublicados.ToList());
        }

        public int CantidadLibros() {
            int numero;
            numero = CommonBC.ModeloServicioLibros.LibroPublicado.Count();
            return numero;
        }

        public double PromedioPaginasPublicaciones()
        {
            double numero = 0;
            numero = CommonBC.ModeloServicioLibros.LibroPublicado.Average(p=>p.Cantidad_paginas);
            return numero;
        }

        public List<LibroPublicado> MayorPuntuacion() {
            int max = (from pub in CommonBC.ModeloServicioLibros.LibroPublicado
                        select pub.Cantidad_Votos).Max();
            var librosM = (from pub in CommonBC.ModeloServicioLibros.LibroPublicado
                           where pub.Cantidad_Votos == max
                            select pub);
            return GenerarListado(librosM.ToList());
        }

        public List<LibroPublicado> MayorPuntuacion(int categoria)
        {
            var libros = CommonBC.ModeloServicioLibros.LibroPublicado.Where(l=>l.Categoria == categoria);
            return GenerarListado(libros.ToList());
        }
    }
}
