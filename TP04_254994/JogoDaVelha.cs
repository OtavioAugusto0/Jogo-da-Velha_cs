using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP04_254994
{
    internal class JogoDaVelha
    {
        private char[,] tabuleiro;
        private char jogadorAtual;

        public JogoDaVelha()
        {
            tabuleiro = new char[3, 3];
            jogadorAtual = 'X';
        }

        public bool FazerJogada(int linha, int coluna)
        {
            if (tabuleiro[linha, coluna] == '\0')
            {
                tabuleiro[linha, coluna] = jogadorAtual;

                if (jogadorAtual == 'X')
                {
                    jogadorAtual = 'O';
                }
                else
                {
                    jogadorAtual = 'X';
                }
                return true;
            }
            return false;
        }

        public char JogadorAtual
        {
            get
            {
                return jogadorAtual;
            }
        }

        public bool VerificarVitoria()
        {
            for (int i = 0; i < 3; i++)
            {
                if (tabuleiro[i, 0] != '\0' &&
                    tabuleiro[i, 0] == tabuleiro[i, 1] &&
                    tabuleiro[i, 1] == tabuleiro[i, 2])
                {
                    return true;
                }

                if (tabuleiro[0, i] != '\0' &&
                    tabuleiro[0, i] == tabuleiro[1, i] &&
                    tabuleiro[1, i] == tabuleiro[2, i])
                {
                    return true;
                }
            }

            if (tabuleiro[0, 0] != '\0' &&
                tabuleiro[0, 0] == tabuleiro[1, 1] &&
                tabuleiro[1, 1] == tabuleiro[2, 2])
            {
                return true;
            }

            if (tabuleiro[0, 2] != '\0' &&
                tabuleiro[0, 2] == tabuleiro[1, 1] &&
                tabuleiro[1, 1] == tabuleiro[2, 0])
            {
                return true;
            }

            return false;
        }

        public char UltimoJogador
        {
            get
            {
                if (jogadorAtual == 'X')
                {
                    return 'O';
                }
                else
                {
                    return 'X';
                }
            }
        }

        public bool VerificarEmpate()
        {
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    if (tabuleiro[linha, coluna] == '\0')
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void Reiniciar()
        {
            tabuleiro = new char[3, 3];
            jogadorAtual = 'X';
        }
    }
}
