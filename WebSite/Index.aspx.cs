using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServicioLibros.Negocio;

public partial class Index : System.Web.UI.Page
{
    CuentaUsuarioCollection listaUsuarios = new CuentaUsuarioCollection();

    public CuentaUsuario Cuenta
    {
        get {
            return (CuentaUsuario)Session["MiCuenta"];
        }
        set {
            Session["MiCuenta"] = value;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Session["IdLibro"] = null;
        //DatosBD.CargarDatos();
        GestionaControladores();
    }

    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        String nombre_usuario, clave;

        nombre_usuario = txtNombreUsuario.Text;
        clave = txtClave.Text;

        try
        {
            CuentaUsuario usuario = listaUsuarios.ReadAll().First(u => u.Nombre_cuenta.Equals(nombre_usuario));
            //Si existe usuario en clase DatosBD
            if (usuario != null)
            {
                //Si clave ingresada coincide con la del usuario en DatosBD
                if (usuario.Clave.Equals(clave))
                {
                    Cuenta = usuario;
                    GestionaControladores();
                }
                else
                {
                    lblInfo.Text = "Clave incorrecta";
                }
            }
            else
            {
                lblInfo.Text = "Usuario no se encuentra registrado";
            }
        }
        catch (Exception)
        {
            lblInfo.Text = "Usuario no se encuentra registrado";
        }
        
                
        
    }

    protected void btnCerrarSesion_Click(object sender, EventArgs e)
    {
        Cuenta = null;
        Session["MiCuenta"] = null;
        GestionaControladores();
    }

    protected void GestionaControladores() {
        if (Cuenta == null)
        {
            btnCerrarSesion.Visible = false;
            btnIngresar.Visible = true;
            txtNombreUsuario.Enabled = true;
            txtClave.Enabled = true;
            lblNombreUsuario.Text = "Inicie sesión";
        }
        else
        {
            btnCerrarSesion.Visible = true;
            btnIngresar.Visible = false;
            txtNombreUsuario.Enabled = false;
            txtClave.Enabled = false;
            lblNombreUsuario.Text = "Te damos la bienvenida " + Cuenta.Nombre_cuenta + " !";
            lblInfo.Text = String.Empty;
        }
    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegistroUsuario.aspx");
    }
}