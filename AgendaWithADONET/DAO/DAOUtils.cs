using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace AgendaWithADONET.DAO
{
    //Classe para a criação dos componentes do DataSet do ADO.NET
    public class DAOUtils
    {
        //Componente para a executar a conexão com o banco de dados;
        public static DbConnection GetConnection()
        {
            DbConnection conexao = new SqlConnection(@"Server=.\SQLEXPRESS;Database=CursoCSharpIntermediario;User Id=sa;Password=gerente;");
            conexao.Open();
            return conexao;
        }
        
        //Componente para exercutar um comando no banco de dadoss SELECT/INSERT/UPDATE/DELETE
        public static DbCommand GetCommand(DbConnection conexao)
        {
            DbCommand comando = conexao.CreateCommand();
            return comando;
        }

        //Componente para ler e trazer o resultado da execução do comando
        public static DbDataReader GetDataReader(DbCommand comando)
        {
            return comando.ExecuteReader();
        }
    }
}
