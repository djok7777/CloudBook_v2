using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public enum CategoriaLibros {
        Seleccionar,
        Sin_Identificar,
        Ciencia,
        Ciencia_Ficción,
        Computación,
        Comedia,
        Gótico,
        Magia,
        Misterio,
        Paranormal,
        Policial,
        Romance,
        Aventura,
        Ficción_Contemporánea,
        Fantasía
    }

    public enum TipoContenido
    {
        Seleccionar,
        Sin_Identificar,
        Universal,
        Infantil,
        Juvenil,
        Adulto
    }

    public enum TipoEstado
    {
        Seleccionar,
        Sin_Identificar,
        Activo,
        Abandonado,
        Finalizado
    }

    public enum TipoPeriodicidad
    {
        Seleccionar,
        Sin_Identificar,
        Ninguno,
        Semanal,
        Quincenal,
        Mensual
    }
}
