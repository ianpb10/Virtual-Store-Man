using delas_pra_elas.conexao;
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
    public partial class Feminino : Form
    {
        public Feminino()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy();
            buy.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy();
            buy.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy();
            buy.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy();
            buy.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy();
            buy.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy();
            buy.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tenis saia = new Tenis();
            saia.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            social viu = new social();
            viu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Estampada estampa = new Estampada();
            estampa.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calca calc = new calca();
            calc.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            termica vist = new termica();
            vist.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Blazer virtus = new Blazer();
            virtus.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
