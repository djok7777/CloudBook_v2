using System.Collections.Generic;
using System.Linq;

namespace ServicioLibros.Negocio
{
    public class ContactoCollection
    {
        private List<Contacto> GenerarListado(List<DALC.Contacto> contactoDalc)
        {
            List<Contacto> contactos = new List<Contacto>();

            foreach (DALC.Contacto c in contactoDalc)
            {
                Contacto contacto = new Contacto();
                contacto.Id_contacto = c.Id_contacto;
                contacto.Mensaje = c.Mensaje;
                contacto.Id_cuenta = c.Id_cuenta;
                contactos.Add(contacto);
            }
            return contactos;
        }

        public List<Contacto> ReadAll()
        {
            var contactos = CommonBC.ModeloServicioLibros.Contacto;
            return GenerarListado(contactos.ToList());
        }
    }
}
