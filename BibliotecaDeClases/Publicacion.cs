using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Publicacion : Libro
    {
        private int _cantidad_paginas, _cantidad_votos;
        private TipoEstado _estado;
        private TipoPeriodicidad _periodicidad;

        #region Constructor
        public Publicacion()
        {
            Init();
        }

        public Publicacion(int idLibro, string titulo, string autor, int fechaPublicacion, CategoriaLibros categoria, TipoContenido contenido, String descripcion,
            int _cantidad_paginas, int _cantidad_votos, TipoEstado _estado, TipoPeriodicidad _periodicidad) : 
            base(idLibro, titulo, autor, fechaPublicacion, categoria, contenido, descripcion)
        {
            this.Cantidad_paginas = _cantidad_paginas;
            this.Cantidad_votos = _cantidad_votos;
            this.Estado = _estado;
            this.Periodicidad = _periodicidad;
        }

        public new void Init()
        {
            base.Init();
            Cantidad_paginas = 0;
            Cantidad_votos = 0;
            Estado = TipoEstado.Sin_Identificar;
            Periodicidad = TipoPeriodicidad.Sin_Identificar;
        }
        #endregion

        #region Propiedades
        public int Cantidad_paginas
        {
            get
            {
                return _cantidad_paginas;
            }

            set
            {
                _cantidad_paginas = value;
            }
        }

        public int Cantidad_votos
        {
            get
            {
                return _cantidad_votos;
            }

            set
            {
                _cantidad_votos = value;
            }
        }

        public TipoEstado Estado
        {
            get
            {
                return _estado;
            }

            set
            {
                _estado = value;
            }
        }

        public TipoPeriodicidad Periodicidad
        {
            get
            {
                return _periodicidad;
            }

            set
            {
                _periodicidad = value;
            }
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder str = new StringBuilder(base.ToString());
            str.AppendFormat("\nCant. pags.\t{0}\nCant. votos\t{1}\nEstado\t\t{2}\nPeriodicidad\t{3}", 
                Cantidad_paginas, Cantidad_votos, Estado, Periodicidad);
            return str.ToString();
        }
        #endregion
    }
}
