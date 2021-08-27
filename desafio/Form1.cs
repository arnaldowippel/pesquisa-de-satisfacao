using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio
{
    public partial class Form1 : Form
    {

        int contadorSim = 0;
        int contadorNao = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem = "Você deseja confirmar seu voto ? ";
            string title = "Confirmação";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensagem, title, buttons);

            if (result == DialogResult.Yes)
            {
                string mensagemSim = "Você votou SIM";
                string titleSim = "Obrigado";
                MessageBox.Show(mensagemSim, titleSim);
                contadorSim++;
                label1.Text = contadorSim.ToString();
            }
          

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensagem = "Você deseja confirmar seu voto?";
            string title = "Confirmação";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensagem, title, buttons);

            if (result == DialogResult.Yes)
            {
                string mensagemNao = "Você votou NÃO";
                string titleNao = "Que pena";
                MessageBox.Show(mensagemNao, titleNao);
               contadorNao++;
               label3.Text = contadorNao.ToString();
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
