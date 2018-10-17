using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioLibros.Negocio
{
    public class CuentaUsuario
    {
        public int Id_cuenta { get; set; }
        public string Nombre_cuenta { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string Nombres { get; set; }
        public string Apellido_paterno { get; set; }
        public string Apellido_materno { get; set; }
        public bool Administrador { get; set; }

        public CuentaUsuario()
        {
            this.Init();
        }

        private void Init()
        {
            Id_cuenta = 0;
            Nombre_cuenta = string.Empty;
            Correo = string.Empty;
            Clave = string.Empty;
            Nombres = string.Empty;
            Apellido_paterno = string.Empty;
            Apellido_materno = string.Empty;
            Administrador = false;
        }

        //Métodos CRUD
        public bool Create()
        {
            try
            {
                DALC.CuentaUsuario user = new DALC.CuentaUsuario();
                user.Id_cuenta = Id_cuenta;
                user.Nombre_cuenta = Nombre_cuenta;
                user.Correo = Correo;
                user.Clave = Clave;
                user.Nombres = Nombres;
                user.Apellido_paterno = Apellido_paterno;
                user.Apellido_materno = Apellido_materno;
                user.Administrador = Administrador;

                CommonBC.ModeloServicioLibros.CuentaUsuario.Add(user);
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
                DALC.CuentaUsuario user = CommonBC.ModeloServicioLibros.CuentaUsuario.First(c => c.Id_cuenta == Id_cuenta);

                Nombre_cuenta = user.Nombre_cuenta;
                Correo = user.Correo;
                Clave = user.Clave;
                Nombres = user.Nombres;
                Apellido_paterno = user.Apellido_paterno;
                Apellido_materno = user.Apellido_materno;
                Administrador = user.Administrador;
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
                DALC.CuentaUsuario user = CommonBC.ModeloServicioLibros.CuentaUsuario.First(c => c.Id_cuenta == Id_cuenta);
                user.Nombre_cuenta = Nombre_cuenta;
                user.Correo = Correo;
                user.Clave = Clave;
                user.Nombres = Nombres;
                user.Apellido_paterno = Apellido_paterno;
                user.Apellido_materno = Apellido_materno;
                user.Administrador = Administrador;

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
                DALC.CuentaUsuario user = CommonBC.ModeloServicioLibros.CuentaUsuario.First(c => c.Id_cuenta == Id_cuenta);
                CommonBC.ModeloServicioLibros.CuentaUsuario.Remove(user);
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
