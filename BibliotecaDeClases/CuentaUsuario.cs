using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class CuentaUsuario
    {
        private int _idCuenta;
        private string _nombre_usuario, _correo, _clave, _nombres, _apellido_paterno, _apellido_materno;
        private ArrayList _catalogo;
        private List<Publicacion> _publicaciones;
        private bool _admin;

        #region Constructores
        public CuentaUsuario(int _idCuenta, string _nombre_usuario, string _correo, string _clave, string _nombres, string _apellido_paterno, string _apellido_materno)
        {
            this.IdCuenta = _idCuenta;
            this.Nombre_usuario = _nombre_usuario;
            this.Correo = _correo;
            this.Clave = _clave;
            this.Nombres = _nombres;
            this.Apellido_paterno = _apellido_paterno;
            this.Apellido_materno = _apellido_materno;
            this.Catalogo = new ArrayList();
            this.Publicaciones = new List<Publicacion>();
            this.Admin = false;
        }

        public CuentaUsuario()
        {
            Init();
        }

        public void Init()
        {
            IdCuenta = 0;
            Nombres = "No identificado";
            Apellido_paterno = "No identificado";
            Apellido_materno = "No identificado";
            Correo = "No identificado";
            Nombre_usuario = "No identificado";
            Clave = "No identificado";
            this.Admin = false;
        }
        #endregion

        #region Propiedad
        public int IdCuenta
        {
            get
            {
                return _idCuenta;
            }

            set
            {
                _idCuenta = value;
            }
        }

        public string Nombre_usuario
        {
            get
            {
                return _nombre_usuario;
            }

            set
            {
                _nombre_usuario = value;
            }
        }

        public string Correo
        {
            get
            {
                return _correo;
            }

            set
            {
                _correo = value;
            }
        }

        public string Clave
        {
            get
            {
                return _clave;
            }

            set
            {
                _clave = value;
            }
        }

        public string Nombres
        {
            get
            {
                return _nombres;
            }

            set
            {
                _nombres = value;
            }
        }

        public string Apellido_paterno
        {
            get
            {
                return _apellido_paterno;
            }

            set
            {
                _apellido_paterno = value;
            }
        }

        public string Apellido_materno
        {
            get
            {
                return _apellido_materno;
            }

            set
            {
                _apellido_materno = value;
            }
        }

        public ArrayList Catalogo
        {
            get
            {
                return _catalogo;
            }

            set
            {
                _catalogo = value;
            }
        }

        public List<Publicacion> Publicaciones
        {
            get
            {
                return _publicaciones;
            }

            set
            {
                _publicaciones = value;
            }
        }

        public bool Admin
        {
            get
            {
                return _admin;
            }

            set
            {
                _admin = value;
            }
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("\nID\t\t{0}\nNOMBRE\t\t{1}\nAPELL PAT.\t{2}\nAPELL MAT.\t{3}\nEMAIL\t\t{4}\nUSUARIO\t\t{5}\nCLAVE\t\t{6}",
                IdCuenta, Nombres, Apellido_paterno, Apellido_materno, Correo, Nombre_usuario, Clave);
            return str.ToString();
        } 
        #endregion
    }
}
