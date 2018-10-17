using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicioLibros.DALC;

namespace ServicioLibros.Negocio
{
    public class CommonBC
    {
        private static CloudbookEntities _modeloServicioLibros;

        public static CloudbookEntities ModeloServicioLibros
        {
            get
            {
                if (_modeloServicioLibros == null)
                {
                    _modeloServicioLibros = new CloudbookEntities();
                }
                return _modeloServicioLibros;
            }
        }
    }
}
