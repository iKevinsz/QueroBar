using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        MySqlConnection Conexao = MapeamentoBD.Conexao();

        DateTime dateTime = DateTime.Now;
        string DataAtual = dateTime.Date.ToString("yyyyy-MM-dd");
        //string DataInserida = txtNascimento.Text.ToString("yyyyy-MM-dd");
        
        Pessoa pessoa = new Pessoa();
        pessoa.Nome = txtNome.Text;

        Aluno aluno = new Aluno();
        aluno.RA = txtRA.Text;

        Usuario usuario = new Usuario();
        usuario.Email = txtEmail.Text;
        usuario.Senha = Funcoes.BaseCodifica(Funcoes.Hash(txtSenha.Text));

        //if( < dateTime.Date)

        MySqlCommand Comando = MapeamentoBD.ComandoSQL("insert into pes_pessoas values(0, '" + pessoa.Nome + "', '" + txtNascimento.Text + "');insert into alu_alunos values('" + aluno.RA + "', '" + txtDataVest.Text + "', 0);insert into usu_usuario values('" + usuario.Email + "', '" + usuario.Senha + "', '" + DataAtual + "', 0);", Conexao);
        MySqlDataAdapter adapter = MapeamentoBD.Adapter(Comando);
        Comando.ExecuteNonQuery();
        Conexao.Close();

        Session["PESSOA"] = pessoa;
        Session["ALUNO"] = aluno;
        Session["USUARIO"] = usuario;

        txtNome.Text = "";
        txtNascimento.Text = "";
        txtRA.Text = "";
        txtDataVest.Text = "";
        txtEmail.Text = "";
        txtSenha.Text = "";

    }

}