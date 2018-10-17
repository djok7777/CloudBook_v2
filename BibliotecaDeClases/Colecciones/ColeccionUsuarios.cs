using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class ColeccionUsuarios : List<CuentaUsuario>
    {

        #region Metodos
        public bool EncuentrarUsuario(String nombreUsuario)
        {
            if (this.Exists(user => user.Nombre_usuario.Equals(nombreUsuario)))
                return true;
            else
                return false;
        }

        public bool ValidarClave(String nombreUsuario, String clave)
        {
            if (this.First(user => user.Nombre_usuario.Equals(nombreUsuario)).Clave.Equals(clave))
            {
                return true;
            }
            return false;
        }

        public CuentaUsuario RetornarUsuario(String nombreUsuario)
        {
            if (this.Exists(user => user.Nombre_usuario.Equals(nombreUsuario)))
                return this.First(user => user.Nombre_usuario.Equals(nombreUsuario));
            else
            {
                return null;
            }
        } 
        #endregion

    }
}
