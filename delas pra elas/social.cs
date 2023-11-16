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
    public partial class social : Form
    {
        public social()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Agradecemos pela sua preferência. Você será redirecionado ao seu carrinho");
            }

            else
            {
                MessageBox.Show("Preencha os campos");
            }

            string tamanho = comboBox1.Text;
            string color = comboBox2.Text;
            string produto = label2.Text;
            double valor = Convert.ToDouble(label4.Text);

            if (!string.IsNullOrEmpty(tamanho))
            {
                Carrinho flor = new Carrinho();
                flor.Tamanho = tamanho;
                flor.Color = color;
                flor.Valor = valor;
                flor.Produto = produto;
                flor.Salvar();
            }
            else
            {
                MessageBox.Show("Campo Vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Carrinhos carrinhos = new Carrinhos();
            carrinhos.ShowDialog();
        }

        private void view_Load(object sender, EventArgs e)
        {

        }
    }
}
