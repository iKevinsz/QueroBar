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

    //Botão para deslogar
    protected void btnSair_Click(object sender, EventArgs e)
    {
        Session["USUÁRIO"] = null;
        Response.Redirect("Default.aspx");
    }

}
