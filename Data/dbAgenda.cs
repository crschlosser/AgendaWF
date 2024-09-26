using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// adicionar a chamada para biblioteca
using System.Data.SQLite;
using System.Data;
using AgendaWF.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgendaWF.Data
{
      // colocar a classe como plública
    public class dbAgenda
    {
        //Adicionar a chamada para o banco;
        public static string path = Directory.GetCurrentDirectory() + "\\AgendaContatos.db";
        private static SQLiteConnection sqliteConnection;

        // Acicionar chamada para implementar a Agenda
        private static SQLiteConnection DbConnection()
        {
            // dbconnection fica vermelho até implementar o return pois a chamada não é void	
            sqliteConnection = new SQLiteConnection("Data Source=" + path);
            sqliteConnection.Open();
            return sqliteConnection;
        }

        // criar o metodo para criar o banco de dados
        public static void CriarBancoSQLite()
        {
            try
            {
                if (File.Exists(path) == false)
                {
                    SQLiteConnection.CreateFile(path);
                }
            }
            catch
            {
                throw;
            }

        }

        // criar o metodo para criar oa tabela no SQLite
        public static void CriarTabelaSQLite()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Contatos(id int UNIQUE, nome Varchar(50), email VarChar(80))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

            // implementar PARA PEGAR TODOS OS CONTATOS
        public static DataTable GetContatos()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable(); 
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Contatos";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static DataTable GetContatos(String nome)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                
                {
                    cmd.CommandText = "SELECT * FROM Contatos where nome like '%"+nome+"%'";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        // implementar para pegar UM CONTATO APENAS POR ID
        public static DataTable GetContato(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Contatos WHERE Id= " + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // IMPLEMENTAR METODO PARA ADICIONAR CONTATO
        public static void Add(Contato contato)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Contatos(id, nome, email) values (@id, @nome, @email)";
                    cmd.Parameters.AddWithValue("@id",      contato.Id);
                    cmd.Parameters.AddWithValue("@nome",    contato.Nome);
                    cmd.Parameters.AddWithValue("@email",   contato.Email);
                    // observar que os campos e parametros com @ na linha commandtext
                    // tenham o seu withvalue correspondente
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

	    // IMPLEMENTAR METODO PARA alterar CONTATO
        public static void Update(Contato contato)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "UPDATE Contatos SET nome=@nome, email=@email WHERE Id=@id";
                    cmd.Parameters.AddWithValue("@id",      contato.Id);
                    cmd.Parameters.AddWithValue("@nome",    contato.Nome);
                    cmd.Parameters.AddWithValue("@email",   contato.Email);
                    // observar que os campos e parametros com @ na linha commandtext
                    // tenham o seu withvalue correspondente
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // IMPLEMENTAR METODO PARA DELETAR CONTATO
        public static void Delete(int id)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Contatos WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    // observar que os campos e parametros com @ na linha commandtext
                    // tenham o seu withvalue correspondente
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
