using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.Colecciones
{
    public class ColeccionLibrosPublicados : List<Publicacion>
    {
        public bool Eliminar(int idLibro)
        {
            if (this.Exists(libro => libro.IdLibro == idLibro))
            {
                this.Remove(this.First(libro => libro.IdLibro == idLibro));
                return true;
            }
            else
                return false;
        }

        public Publicacion RetornarPublicacion(int idLibro) {
            if (this.Exists(libro => libro.IdLibro == (idLibro))) {
                return this.First(libro=>libro.IdLibro == idLibro);
            }
            return null;
        }
    }
}
