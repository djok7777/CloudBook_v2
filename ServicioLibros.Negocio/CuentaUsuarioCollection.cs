using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioLibros.Negocio
{
    public class CuentaUsuarioCollection
    {
        private List<CuentaUsuario> GenerarListado(List<DALC.CuentaUsuario> usuariosDALC)
        {
            List<CuentaUsuario> cuentasDeUsuarios = new List<CuentaUsuario>();

            foreach (DALC.CuentaUsuario c in usuariosDALC)
            {
                CuentaUsuario user = new CuentaUsuario();
                user.Id_cuenta = c.Id_cuenta;
                user.Nombre_cuenta = c.Nombre_cuenta;
                user.Correo = c.Correo;
                user.Clave = c.Clave;
                user.Nombres = c.Nombres;
                user.Apellido_paterno = c.Apellido_paterno;
                user.Apellido_materno = c.Apellido_materno;
                user.Administrador = c.Administrador;
                cuentasDeUsuarios.Add(user);
            }
            return cuentasDeUsuarios;
        }

        public List<CuentaUsuario> ReadAll()
        {
            var cuentasDeUsuarios = CommonBC.ModeloServicioLibros.CuentaUsuario;
            return GenerarListado(cuentasDeUsuarios.ToList());
        }

        public int UsuariosRegistrados() {
            int numero = 0;
            numero = CommonBC.ModeloServicioLibros.CuentaUsuario.Count();
            return numero;
        }

    }
}
