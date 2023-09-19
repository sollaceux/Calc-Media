using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) // Título: Calculadora de Média
        {

        }
        private void label2_Click(object sender, EventArgs e) // Nota da P1
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e) // Textbox da P1
        {

        }
        private void label3_Click(object sender, EventArgs e) // Nota da P2
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e) // Textbox da P2
        {

        }

        private void button1_Click(object sender, EventArgs e) // Calcular
        {
            float soma, media, valor;
            int peso = 7;
            soma = 0;
           


                foreach(Control controle in this.Controls)
            {
                if(controle is TextBox)
                {
                    valor = Convert.ToSingle(((TextBox)controle).Text);
                   
                    soma += valor*peso;
                    peso = 3;
                    
                }
                

                media = soma / 10;

                double mediaRound = Math.Round(media, 2);

                this.Controls["label5"].Text = mediaRound.ToString("F2", CultureInfo.InvariantCulture);
               


            }
        }

        private void button2_Click(object sender, EventArgs e) // Limpar
        {

        }
       
        private void label4_Click_1(object sender, EventArgs e) // Anunciador da Média
        {

        }

        private void label5_Click(object sender, EventArgs e) // Valor da Média
        {

        }
    }
}
