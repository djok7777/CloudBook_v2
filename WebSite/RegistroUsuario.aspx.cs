using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaDeClases;
using BibliotecaDeClases.BaseDatos;

public partial class RegistroUsuario : System.Web.UI.Page
{
    ServicioLibros.Negocio.CuentaUsuarioCollection listaUsuarios = new ServicioLibros.Negocio.CuentaUsuarioCollection();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        ServicioLibros.Negocio.CuentaUsuario nuevoUsuario = new ServicioLibros.Negocio.CuentaUsuario();
        int idCuenta = 0;
        String nombre_usuario, correo, clave;
        String nombres, apellido_paterno, apellido_materno;

        try
        {
            //Asigna la siguiente id del ultimo usuario registrado en la base de datos
            idCuenta = listaUsuarios.ReadAll().Last().Id_cuenta + 1;
            nombre_usuario = txtNombreUsuario.Text;
            correo = txtCorreo.Text;
            clave = txtClave.Text;
            nombres = txtNombres.Text;
            apellido_paterno = txtPaterno.Text;
            apellido_materno = txtMaterno.Text;

            nuevoUsuario.Id_cuenta = idCuenta;
            nuevoUsuario.Nombre_cuenta = nombre_usuario;
            nuevoUsuario.Correo = correo;
            nuevoUsuario.Clave = clave;
            nuevoUsuario.Nombres = nombres;
            nuevoUsuario.Apellido_paterno = apellido_paterno;
            nuevoUsuario.Apellido_materno = apellido_materno;

            nuevoUsuario.Create();
            LimpiarControles();
            lblInfo.Text = "Usuario registrado con éxito";
            
        }
        catch (Exception ex)
        {
            lblInfo.Text = "Error: " + ex.Message;
        }

    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }

    protected void LimpiarControles()
    {
        txtNombreUsuario.Text = string.Empty;
        txtCorreo.Text = string.Empty;
        txtClave.Text = string.Empty;
        txtNombres.Text = string.Empty;
        txtPaterno.Text = string.Empty;
        txtMaterno.Text = string.Empty;
    }
}