using Microsoft.Win32;
using MySqlX.XDevAPI.Relational;
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
    public partial class Carrinhos : Form
    {
        public Carrinhos()
        {
            InitializeComponent();
        }

        private void Carrinhos_Load(object sender, EventArgs e)
        {
            List<Carrinho> registroContas = Carrinho.ObterRegistroContas();
            dataGridView1.DataSource = registroContas;
            dataGridView1.Columns["idcarrinho"].Visible = false;
         
             double total = Carrinho.Soma();
            label3.Text = new Carrinho { Valor = total }.ValorFormatado;
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Deletar"].Index)
            {
                int idcarrinho = (int)dataGridView1.Rows[e.RowIndex].Cells["idcarrinho"].Value;

                
                Carrinho registro = new Carrinho();
                registro.Deletar(idcarrinho);
                double total = Carrinho.Soma();
                label3.Text = new Carrinho { Valor = total }.ValorFormatado;

                List<Carrinho> registroContas = Carrinho.ObterRegistroContas();
                dataGridView1.DataSource = registroContas;

                dataGridView1.Columns["idcarrinho"].Visible = false;
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Comprar_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy();
            buy.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            


        }
    }
}
