using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP04_254994
{
    public partial class Form1 : Form
    {
        private JogoDaVelha jogo;
        private int placarX = 0;
        private int placarO = 0;
        private bool partidaFinalizada = false;
        public Form1()
        {
            InitializeComponent();
            jogo = new JogoDaVelha();
        }

        private void BotaoJogo_Click(object sender, EventArgs e)
        {
            if (partidaFinalizada)
            {
                return;
            }

            Button botao = (Button)sender;

            int linha = 0;
            int coluna = 0;

            if (botao.Name == "btn1")
            {
                linha = 0;
                coluna = 0;
            }
            else if (botao.Name == "btn2")
            {
                linha = 0;
                coluna = 1;
            }
            else if (botao.Name == "btn3")
            {
                linha = 0;
                coluna = 2;
            }
            else if (botao.Name == "btn4")
            {
                linha = 1;
                coluna = 0;
            }
            else if (botao.Name == "btn5")
            {
                linha = 1;
                coluna = 1;
            }
            else if (botao.Name == "btn6")
            {
                linha = 1;
                coluna = 2;
            }
            else if (botao.Name == "btn7")
            {
                linha = 2;
                coluna = 0;
            }
            else if (botao.Name == "btn8")
            {
                linha = 2;
                coluna = 1;
            }
            else if (botao.Name == "btn9")
            {
                linha = 2;
                coluna = 2;
            }

            bool jogadaRealizada = jogo.FazerJogada(linha, coluna);

            if (jogadaRealizada)
            {
                botao.Text = jogo.UltimoJogador.ToString();

                if (jogo.VerificarVitoria())
                {
                    if (jogo.UltimoJogador == 'X')
                    {
                        placarX++;
                        lblPlacarX.Text = "Jogador X: " + placarX;
                    }
                    else
                    {
                        placarO++;
                        lblPlacarO.Text = "Jogador O: " + placarO;
                    }

                    MessageBox.Show("Jogador " + jogo.UltimoJogador + " venceu!");
                    partidaFinalizada = true;
                    lblJogador.Text = "Fim de jogo!";
                }
                else if (jogo.VerificarEmpate())
                {
                    MessageBox.Show("Empate!");
                    lblJogador.Text = "Empate!";
                    partidaFinalizada = true;
                }
                else
                {
                    lblJogador.Text = "Vez do jogador: " + jogo.JogadorAtual;
                }
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            jogo.Reiniciar();

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            partidaFinalizada = false;

            lblJogador.Text = "Vez do jogador: X";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }

}
