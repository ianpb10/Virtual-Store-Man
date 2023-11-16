using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delas_pra_elas
{
    public partial class Buy : Form
    {
        public Buy()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("A compra foi realizada. Enviamos um comprovante para o seu Email");
            }
            else
            {
                MessageBox.Show("Preencha os campos");
            }

            string Nome = textBox1.Text;
            string email = textBox5.Text;
            string endereco = textBox2.Text;
            string pagamento = comboBox1.Text;
            string banco = textBox4.Text;
            string numero = textBox3.Text;
            if (!string.IsNullOrEmpty(Nome))
            {
                Compra flor = new Compra();
                flor.Nome = Nome;
                flor.email = email;
                flor.endereco = endereco;
                flor.pagamento = pagamento;
                flor.banco = banco;
                flor.numero = numero;
                flor.Salvar();
            }
            else
            {
                MessageBox.Show("Campo Vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Buy_Load(object sender, EventArgs e)
        {

        }
    }
}
    

