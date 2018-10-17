using System;
using System.Data;
using System.IO;
using System.Linq;
using ServicioLibros.Negocio;

public partial class Contactos : System.Web.UI.Page
{
    private ContactoCollection listaContactos = new ContactoCollection();

    public CuentaUsuario MiUsuario
    {
        get
        {
            return (CuentaUsuario)Session["MiCuenta"];
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        ServicioLibros.Negocio.Contacto conta = new ServicioLibros.Negocio.Contacto();
        try
        {
            if (listaContactos.ReadAll().Count > 0)
            {
                conta.Id_contacto = listaContactos.ReadAll().Last().Id_contacto + 1;
            }
            else
            {
                conta.Id_contacto = 1;
            }

            conta.Mensaje = txtCorreo.Text + " >> " + txtEscribanos.Text;
            conta.Id_cuenta = MiUsuario.Id_cuenta;

            if (conta.Create())
            {
                lblInfo.Text = "Mensaje enviado con éxito";
            }
            else
            {
                lblInfo.Text = "Hubo un problema al enviar";
            }
            
            txtCorreo.Text = String.Empty;
            txtEscribanos.Text = String.Empty;
            
        }
        catch (Exception ex)
        {
            lblInfo.Text = "No se pudo envíar el mensaje: " + ex.Message;
        }
    }
}