using AgendaWithADONET.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace AgendaWithADONET.DAO
{
    public class ContatosDAO
    {
        public DataSet GetContatos()
        {
            DbConnection conexao = DAOUtils.GetConnection();
            DbCommand comando = DAOUtils.GetCommand(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Contatos";

            //Utilizando DataSet e DataAdaptader
            DbDataAdapter adapdater = new SqlDataAdapter((SqlCommand)comando);
            DataSet ds = new DataSet();
            adapdater.Fill(ds,"Contatos");
            return ds;
            
            //Utilizando DataReader e DataTable para obter dados do banco SQL Server
            //DbDataReader reader = DAOUtils.GetDataReader(comando);
            //DataTable dataTable = new DataTable();
            //dataTable.Load(reader);
            //return dataTable;
        }

        public void Inserir(Contato contato)
        {
            DbConnection conexao = DAOUtils.GetConnection();
            DbCommand comando = DAOUtils.GetCommand(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Contatos (Nome, Email, Telefone) VALUES(@nome, @email, @telefone)";
            comando.Parameters.Add(new SqlParameter( "@nome", contato.nome));
            comando.Parameters.Add(new SqlParameter("@email", contato.email));
            comando.Parameters.Add(new SqlParameter("@telefone", contato.telefone));
            comando.ExecuteNonQuery();

        }

        public void Editar(Contato contato)
        {
            DbConnection conexao = DAOUtils.GetConnection();
            DbCommand comando = DAOUtils.GetCommand(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Contatos SET Nome = @nome, Email = @email, Telefone = @telefone WHERE ID = @id";
            comando.Parameters.Add(new SqlParameter("@id", contato.id));
            comando.Parameters.Add(new SqlParameter("@nome", contato.nome));
            comando.Parameters.Add(new SqlParameter("@email", contato.email));
            comando.Parameters.Add(new SqlParameter("@telefone", contato.telefone));
            comando.ExecuteNonQuery();
        }

        public void Excluir(int ID)
        {
            //Lmebre-se o DAOUtils serve para chamar os principais comandos de Conexão, Comando e Execução de leitura;
            //Assim não sendo mais necessário ficar instanciando várias vezes classes de Conexão, Comando e Leitura;
            DbConnection conexao = DAOUtils.GetConnection();
            DbCommand comando = DAOUtils.GetCommand(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM Contatos WHERE ID = @ID";

            //Utiliza-se o Parameters + o parâmetro do tipo Int para evitar SQL Injection
            comando.Parameters.Add(new SqlParameter("@ID", ID));
            comando.ExecuteNonQuery();

        }
    }
}
