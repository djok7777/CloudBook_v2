//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicioLibros.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contacto
    {
        public int Id_contacto { get; set; }
        public string Mensaje { get; set; }
        public int Id_cuenta { get; set; }
    
        public virtual CuentaUsuario CuentaUsuario { get; set; }
    }
}