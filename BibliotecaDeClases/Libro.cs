using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Libro
    {
        private int _idLibro, _fechaPublicacion;
        private string _titulo, _autor, _descripcion;
        private CategoriaLibros _categoria;
        private TipoContenido _contenido;
        private string _ruta, _portada;

        #region Constructores

        public Libro(int _idLibro, string _titulo, string _autor, int _fechaPublicacion, CategoriaLibros _categoria, TipoContenido _contenido, String _descripcion)
        {
            this.IdLibro = _idLibro;
            this.FechaPublicacion = _fechaPublicacion;
            this.Titulo = _titulo;
            this.Autor = _autor;
            this.Categoria = _categoria;
            this.Contenido = _contenido;
            this.Descripcion = _descripcion;
        }

        public Libro()
        {
            Init();
        }

        //Inicia valores por default
        public void Init()
        {
            IdLibro = 0;
            Titulo = "Titulo desconocido";
            Autor = "Autor desconocido";
            FechaPublicacion = 0;
            Categoria = CategoriaLibros.Sin_Identificar;
            Contenido = TipoContenido.Sin_Identificar;
        }
        #endregion

        #region Propiedades

        public int IdLibro
        {
            get
            {
                return _idLibro;
            }

            set
            {
                _idLibro = value;
            }
        }

        public int FechaPublicacion
        {
            get
            {
                return _fechaPublicacion;
            }

            set
            {
                _fechaPublicacion = value;
            }
        }

        public string Titulo
        {
            get
            {
                return _titulo;
            }

            set
            {
                _titulo = value;
            }
        }

        public string Autor
        {
            get
            {
                return _autor;
            }

            set
            {
                _autor = value;
            }
        }

        public CategoriaLibros Categoria
        {
            get
            {
                return _categoria;
            }

            set
            {
                _categoria = value;
            }
        }

        public TipoContenido Contenido
        {
            get
            {
                return _contenido;
            }

            set
            {
                _contenido = value;
            }
        }

        public string Ruta
        {
            get
            {
                return _ruta;
            }

            set
            {
                _ruta = value;
            }
        }

        public string Portada
        {
            get
            {
                return _portada;
            }

            set
            {
                _portada = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }

            set
            {
                _descripcion = value;
            }
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("\nID\t\t{0} \nTITULO\t\t{1} \nAUTOR\t\t{2}"
                + "\nFECHA PUBLI.\t{3} \nCATEGORIA\t{4} \nCONTENIDO\t{5}",
                IdLibro, Titulo, Autor, FechaPublicacion, Categoria, Contenido);
            return str.ToString();
        }
        #endregion
    }
}
