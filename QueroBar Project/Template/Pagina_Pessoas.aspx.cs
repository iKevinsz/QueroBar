using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina_Pessoas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CarregarPessoasComGrid();
    }

    void CarregarPessoas() {
        DataSet dsPessoas = PessoasBD.SelecionarTodasPessoas();
        int qtdLinhas = Funcoes.QuantidadeRegistros(dsPessoas);
        if ( qtdLinhas > 0 ) {
            foreach(DataRow dr in dsPessoas.Tables[0].Rows) {
                lblPessoas.Text += dr["pes_nome"].ToString() + "<br/>";
            }
        } else
            lblPessoas.Text = "Não há pessoas cadastradas";
    }

    void CarregarPessoasComGrid()
    {
        DataSet dsPessoas = PessoasBD.SelecionarTodasPessoas();
        Funcoes.CarregarGridViewComDataSet(dsPessoas, gdvPessoas);
    }

    //Botão para deslogar
    protected void btnSair_Click(object sender, EventArgs e)
    {
        Session["USUÁRIO"] = null;
        Response.Redirect("Default.aspx");
    }



}