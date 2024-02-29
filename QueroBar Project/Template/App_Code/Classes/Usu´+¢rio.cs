using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Estrutura do Usuário (classe)
/// </summary>

public class Pessoa
{
    private string _nome;

    public string Nome { get => _nome; set => _nome = value; }
}

public class Aluno
{
    private string _ra;

    public string RA { get => _ra; set => _ra = value; }
}

public class Usuario
{
    private string _email;
    private string _senha;

    public string Email { get => _email; set => _email = value; }
    public string Senha { get => _senha; set => _senha = value; }

}