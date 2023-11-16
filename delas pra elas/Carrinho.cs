using delas_pra_elas.conexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using delas_pra_elas.conexao;

namespace delas_pra_elas
{
    internal class Carrinho
    {
        public int idcarrinho { get; set; }
        public string Tamanho { get; set; }
        public string Color { get; set; }
        public double Valor { get; set; }
        public string Produto { get; set; }
        public string ValorFormatado
        {
            get
            {
                return string.Format("R$ {0:0.00}", Valor);
            }
        }



        public void Salvar()
        {
            MySqlConnectionManager connectionManager = new MySqlConnectionManager();
            MySqlConnection connection = connectionManager.GetConnection();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "INSERT INTO `carrinho`(`tamanho`,`color`,`valor`,`produto`)VALUES(@tamanho,@color,@valor,@produto);";
            cmd.Parameters.AddWithValue("@tamanho", Tamanho);
            cmd.Parameters.AddWithValue("@color", Color);
            cmd.Parameters.AddWithValue("@valor", Valor);
            cmd.Parameters.AddWithValue("@produto", Produto);
            cmd.ExecuteNonQuery();
            connection.Close();

        }
        public List<Carrinho> ListaCliente()
        {
            List<Carrinho> itens = new List<Carrinho>();
            try

            {
                MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                MySqlConnection connection = connectionManager.GetConnection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM carrinho";
                MySqlDataReader leitura = cmd.ExecuteReader();
                while (leitura.Read())
                {
                    Carrinho iten = new Carrinho();
                    iten.Tamanho = leitura["tamanho"].ToString();
                    iten.Valor = leitura.GetDouble("valor");
                    iten.Color = leitura["color"].ToString();
                    iten.Produto = leitura["produto"].ToString();
                    itens.Add(iten);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Banco vazio", ex.Message);


            }


            return itens;

        }


        public static List<Carrinho> ObterRegistroContas()
        {
            List<Carrinho> creditos = new List<Carrinho>();
            try
            {
                MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                MySqlConnection connection = connectionManager.GetConnection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM carrinho";
                MySqlDataReader leitura = cmd.ExecuteReader();
                while (leitura.Read())
                {
                    Carrinho reg = new Carrinho();
                    reg.Tamanho = leitura.GetString("tamanho");
                    reg.Valor = leitura.GetDouble("valor");
                    reg.Color = leitura.GetString("color");
                    reg.Produto = leitura.GetString("produto");
                    reg.idcarrinho = leitura.GetInt32("idcarrinho");
                    creditos.Add(reg);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Banco vazio", ex.Message);
            }

            return creditos;



        }

        public void Deletar(int idcarrinho)
        {
            try
            {
                MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                MySqlConnection connection = connectionManager.GetConnection();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM `carrinho` WHERE `idcarrinho` = @idcarrinho";
                cmd.Parameters.AddWithValue("@idcarrinho", idcarrinho);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Deletado com sucesso", "Apagado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static double Soma()
        {
            double total = 0;
            try
            {
                MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                MySqlConnection connection = connectionManager.GetConnection();
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT (SUM(valor)) FROM carrinho;";

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            total = reader.GetDouble(0);
                        }
                    }
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return total;

        }
    }
}
