using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo21
{
    public partial class Form1 : Form
    {
        int total, jogadas = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void GerarNumero_Click(object sender, EventArgs e)
        {
            while (jogadas < 2)
            {
                jogadas++;

                Random numeroCarta = new Random();
                int x = numeroCarta.Next(1, 14);

                switch (x)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.asespada;

                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.espada2;

                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.espada3;

                        break;
                    case 4:
                        pictureBox1.Image = Properties.Resources.espada4;

                        break;
                    case 5:
                        pictureBox1.Image = Properties.Resources.espada5;

                        break;
                    case 6:
                        pictureBox1.Image = Properties.Resources.espada6;

                        break;
                    case 7:
                        pictureBox1.Image = Properties.Resources.espada7;

                        break;
                    case 8:
                        pictureBox1.Image = Properties.Resources.espada8;

                        break;
                    case 9:
                        pictureBox1.Image = Properties.Resources.espada9;

                        break;
                    case 10:
                        pictureBox1.Image = Properties.Resources.espada10;

                        break;
                    case 11:
                        pictureBox1.Image = Properties.Resources.valeteespada;

                        break;
                    case 12:
                        pictureBox1.Image = Properties.Resources.damaespada;

                        break;
                    case 13:
                        pictureBox1.Image = Properties.Resources.reiespada;

                        break;
                }



                this.label1.Text = Convert.ToString(x);
                this.listBox1.Items.Add("Carta(" + x + ")");
                total += x;
                this.label3.Text = Convert.ToString(total);

                if (total > 21)
                {
                    this.button1.Enabled = false;
                    MessageBox.Show("Perdeu!!!!" + "\n" + "Fim de Jogo");
                    this.button2.Text = "Reiniciar";
                }
                else if (total == 21)
                {
                    this.button1.Enabled = false;
                    MessageBox.Show("VOCÊ VENCEU!!!!" + "\n" + "PARABÉNS !!!");
                    this.button2.Text = "Reiniciar";

                }
            }
            jogadas = 1;
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            this.button2.Text = "Limpar";
            this.listBox1.Items.Clear();
            total = 0;
            this.label3.Text = "";
            this.label1.Text = "";
            this.button1.Enabled = true;
            pictureBox1.Image = Properties.Resources.branco1;
            jogadas = 0;

        }
    }
}
