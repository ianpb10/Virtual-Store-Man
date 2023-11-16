using delas_pra_elas.conexao;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delas_pra_elas
{
    public class Compra
    {
        public int idloloja { get; set; }
        public string Nome { get; set; }
        public string email { get; set; }
        public string endereco { get; set; }
        public string pagamento { get; set; }
        public string banco { get; set; }
        public string numero { get; set; }

        public void Salvar()
        {
            MySqlConnectionManager connectionManager = new MySqlConnectionManager();
            MySqlConnection connection = connectionManager.GetConnection();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "INSERT INTO `lolja`(`nome`,`email`,`endereco`,`telefone`,`pagamento`,`banco`)VALUES(@nome,@email,@endereco,@telefone,@pagamento,@banco);";
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@pagamento", pagamento);
            cmd.Parameters.AddWithValue("@banco", banco);
            cmd.Parameters.AddWithValue("@telefone", numero);
            cmd.ExecuteNonQuery();
            connection.Close();
    
        }
        public List<Compra> ListaCliente()
        {
            List<Compra> produtos = new List<Compra>();
            try

            {
                MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                MySqlConnection connection = connectionManager.GetConnection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM lolja";
                MySqlDataReader leitura = cmd.ExecuteReader();
                while (leitura.Read())
                {
                    Compra produto = new Compra();
                    produto.Nome = leitura["Nome"].ToString();
                    produto.numero = leitura["telefone"].ToString();
                    produto.email = leitura["email"].ToString();
                    produto.endereco = leitura["endereco"].ToString();
                    produto.pagamento = leitura["pagamento"].ToString();
                    produto.banco = leitura["banco"].ToString();
                    
                    produtos.Add(produto);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Banco vazio", ex.Message);


            }


            return produtos;

        }

      

    }
}
