using MySql.Data.MySqlClient;
using System;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogar_Click(object sender, EventArgs e)
    {
        MySqlConnection Conexao = MapeamentoBD.Conexao();
        MySqlCommand Comando;

        Usuario usuario = new Usuario();
        usuario.Email = txtEmail.Text;
        usuario.Senha = Funcoes.BaseCodifica(Funcoes.Hash(txtSenha.Text));

        Comando = MapeamentoBD.ComandoSQL("select count(*) from usu_usuario where usu_email = @usuario.Email and usu_senha = @usuario.Senha;", Conexao);
        Comando.Parameters.AddWithValue("@usuario.Email", usuario.Email);
        Comando.Parameters.AddWithValue("@usuario.Senha", usuario.Senha);

        Int64 resultado = (Int64)Comando.ExecuteScalar();
        Conexao.Close();

        if (resultado > 0)
        {
            // usuário válido, redirecionar para a página principal
            if (txtEmail.Text == "admin@gmail.com")
                Response.Redirect("Default2.aspx");
            else
                Response.Redirect("Pagina_Pessoas.aspx");
        }
        else
        {
            // usuário inválido, exibir mensagem de erro
            //errorMessageLabel.Text = "Nome de usuário ou senha incorretos";
        }

        Session["USUARIO"] = usuario;

    }
}