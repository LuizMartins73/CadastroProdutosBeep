using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroProdutosBeep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Variáveis a serem usadas:
            string produto = textBox1.Text;
            int qtd = int.Parse(textBox2.Text);
            double valor = double.Parse(textBox3.Text);
            double preco = valor* qtd;
   
            //Lista com as variáveis concatenadas:
            listBox1.Items.Add(produto+" / "+qtd+" / "+"R$"+preco);

            //Limpar os dados preenchidos nas labels:
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();   

   
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
