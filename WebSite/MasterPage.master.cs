using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void linkFacebook_Click(object sender, EventArgs e)
    {
        Response.Redirect("https://es-la.facebook.com/");
    }

    protected void linkTwitter_Click(object sender, EventArgs e)
    {
        Response.Redirect("https://twitter.com/?lang=es");
    }
}
