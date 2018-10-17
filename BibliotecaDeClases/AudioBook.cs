using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class AudioBook : Libro
    {
        private int tiempo_duracion;
        private string isbn, editorial,formato, nombre_narrador;


        #region Constructor
        public AudioBook(int idProducto, string titulo, string autor, int fechaPublicacion, CategoriaLibros categoria, TipoContenido contenido, String descripcion,
        string isbn, string editorial, int tiempo_duracion, string formato, string nombre_narrador)
        : base(idProducto, titulo, autor, fechaPublicacion, categoria, contenido, descripcion)
        {
            Tiempo_duracion = tiempo_duracion;
            Isbn = isbn;
            Editorial = editorial;
            Formato = formato;
            Nombre_narrador = nombre_narrador;
        }

        public AudioBook()
        {
            Init();
        }

        public new void Init()
        {
            Tiempo_duracion = 0;
            Isbn = "Sin ISBN";
            Editorial = "Editorial desconocida";
            Formato = "Formato desconocido";
            Nombre_narrador = "Narrador desconocido";
        } 
        #endregion

        #region Propiedades
        public int Tiempo_duracion
        {
            get
            {
                return tiempo_duracion;
            }

            set
            {
                tiempo_duracion = value;
            }
        }

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

        public string Formato
        {
            get
            {
                return formato;
            }

            set
            {
                formato = value;
            }
        }

        public string Nombre_narrador
        {
            get
            {
                return nombre_narrador;
            }

            set
            {
                nombre_narrador = value;
            }
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder str = new StringBuilder(base.ToString());
            str.AppendFormat("\nTIEMPO DURAC.\t{0} \nFORMATO\t\t{1} \nNARRADOR\t{2}", Tiempo_duracion, Formato, Nombre_narrador);
            return str.ToString();
        }
        #endregion
    }
}
