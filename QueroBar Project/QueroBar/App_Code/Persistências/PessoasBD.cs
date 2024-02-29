using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de PessoasBD
/// </summary>
public static class PessoasBD {
    
    public static DataSet SelecionarTodasPessoas()
    {
        DataSet ds = new DataSet();
        MySqlConnection Conexao = MapeamentoBD.Conexao();
        MySqlCommand Comando;
        MySqlDataAdapter Adapter;
        string sql = "select alu_ra, pes_nome, usu_email, usu_dataadd from pes_pessoas pes inner join usu_usuario usu on usu.pes_codigo = pes.pes_codigo inner join alu_alunos alu on alu.pes_codigo = usu.pes_codigo";
        Comando = MapeamentoBD.ComandoSQL(sql, Conexao);
        Adapter = MapeamentoBD.Adapter(Comando);
        Adapter.Fill(ds);
        return ds;
    }

}
