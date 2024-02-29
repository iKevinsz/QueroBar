using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

/// <summary>
/// Descrição resumida de MapeamentoBD
/// </summary>
public class MapeamentoBD
{
    //1 método: conexão com o bd;
    //public static IDbConnection Conexao() {
    //    MySqlConnection objConexao = new MySqlConnection(ConfigurationManager.AppSettings["stringConexaoBD"]);
    //    objConexao.Open();
    //    return objConexao;
    //}

    public static MySqlConnection Conexao()
    {
        MySqlConnection objConexao = new MySqlConnection(ConfigurationManager.AppSettings["stringConexaoBD"]);
        objConexao.Open();
        return objConexao;
    }

    //2 método: executar comando sql;
    //public static IDbCommand ComandoSQL(string sql, IDbConnection Conexao) {
    //    IDbCommand Comando = Conexao.CreateCommand();
    //    Comando.CommandText = sql;
    //    return Comando;
    //}

    public static MySqlCommand ComandoSQL(string sql, MySqlConnection Conexao2)
    {
        MySqlCommand Comando = Conexao2.CreateCommand();
        Comando.CommandText = sql;
        return Comando;
    }

    //3 método: container de dados;
    //public static IDataAdapter Adapter(IDbCommand Comando) {
    //    IDbDataAdapter Adapter = new MySqlDataAdapter();
    //    Adapter.SelectCommand = Comando;
    //    return Adapter;
    //}

    public static MySqlDataAdapter Adapter(MySqlCommand Comando)
    {
        MySqlDataAdapter Adapter = new MySqlDataAdapter();
        Adapter.SelectCommand = Comando;
        return Adapter;
    }

    //4 método: parametrização;
    //C# Data: SQL Injection / XCS => Cross Script;
    public static MySqlParameter ValidarParametros(string nomeParametro, object Valor) {
        return new MySqlParameter(nomeParametro, Valor);
    }

}