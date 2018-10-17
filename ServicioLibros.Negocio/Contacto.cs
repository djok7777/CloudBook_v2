using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioLibros.Negocio
{
    public class Contacto
    {
        public int Id_contacto { get; set; }
        public string Mensaje { get; set; }
        public int Id_cuenta { get; set; }

        public Contacto() {
            Init();
        }

        private void Init()
        {
            Id_contacto = 0;
            Mensaje = string.Empty;
            Id_cuenta = 0;
        }

        //Métodos CRUD
        public bool Create()
        {
            try
            {
                DALC.Contacto contact = new DALC.Contacto();

                contact.Id_contacto = Id_contacto;
                contact.Mensaje = Mensaje;
                contact.Id_cuenta = Id_cuenta;

                CommonBC.ModeloServicioLibros.Contacto.Add(contact);
                CommonBC.ModeloServicioLibros.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                DALC.Contacto contact = CommonBC.ModeloServicioLibros.Contacto.First(c => c.Id_contacto== Id_contacto);

                Id_contacto = contact.Id_contacto;
                Mensaje = contact.Mensaje;
                Id_cuenta = contact.Id_cuenta;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                DALC.Contacto contact = CommonBC.ModeloServicioLibros.Contacto.First(c => c.Id_contacto == Id_contacto);
                contact.Id_contacto = Id_contacto;
                contact.Mensaje = Mensaje;
                contact.Id_cuenta = Id_cuenta;

                CommonBC.ModeloServicioLibros.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                DALC.Contacto contact = CommonBC.ModeloServicioLibros.Contacto.First(c => c.Id_contacto == Id_contacto);
                CommonBC.ModeloServicioLibros.Contacto.Remove(contact);
                CommonBC.ModeloServicioLibros.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
