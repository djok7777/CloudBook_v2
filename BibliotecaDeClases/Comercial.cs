using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Comercial : Libro
    {
        private string isbn, editorial;
        int cantidad_paginas;
        private string _audio;

        #region Constructor
        public Comercial(int idProducto, string titulo, string autor, int fechaPublicacion, CategoriaLibros categoria, TipoContenido contenido, String descripcion,
        string isbn, string editorial, int cantidad_paginas)
        : base(idProducto, titulo, autor, fechaPublicacion, categoria, contenido, descripcion)
        {
            Isbn = isbn;
            Editorial = editorial;
            Cantidad_paginas = cantidad_paginas;
        }

        public Comercial()
        {
            Init();
        }

        public new void Init()
        {
            base.Init();
            Isbn = "Sin ISBN";
            Editorial = "Sin editorial";
            Cantidad_paginas = 0;
        } 
        #endregion

        #region Propiedades
        public string Isbn
        {
            get
            {
                return isbn;
            }

            set
            {
                isbn = value;
            }
        }

        public string Editorial
        {
            get
            {
                return editorial;
            }

            set
            {
                editorial = value;
            }
        }

        public int Cantidad_paginas
        {
            get
            {
                return cantidad_paginas;
            }

            set
            {
                cantidad_paginas = value;
            }
        }

        public string Audio
        {
            get
            {
                return _audio;
            }

            set
            {
                _audio = value;
            }
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder str = new StringBuilder(base.ToString());
            str.AppendFormat("\nCant. pags.\t{0}\nISBN\t\t{1}\nEditorial\t{2}",
                Cantidad_paginas, Isbn, Editorial);
            return str.ToString();
        }
        #endregion
    }
}
