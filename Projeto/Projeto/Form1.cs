using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblVersao.Text = "Versão" + Jogo.Versao;
        }

        //METODOS CRIADOS - ---------------------------------------------------------------------------------------------------------------------------------------------
        public void RealizarJogada()
        {
            //Adiciona cartas da mão ao array
            string textoMao = lblMostraMao.Text;
            textoMao = textoMao.Replace("\r\n", ",");
            string[] vetMao = textoMao.Split(',');

            ConsultarMao();
            ExibirTabuleiro();

            string jogada = null;
            //Se tiver a carta na mão, jogue-a (Posição setada como 0)
            if (vetMao[0] == "C") jogada = "C";
            else if (vetMao[0] == "P") jogada = "P";
            else if (vetMao[0] == "T") jogada = "T";
            else if (vetMao[0] == "F") jogada = "F";
            else if (vetMao[0] == "E") jogada = "E";
            else if (vetMao[0] == "G") jogada = "G";

            Jogo.Jogar(Convert.ToInt32(txbIdJogador.Text), txbSenhaJogador.Text, 0, jogada);
        }

        private void ExibirTabuleiro()
        {
            lblTabuleiro.Text = Jogo.ExibirTabuleiro(Convert.ToInt32(txbIdPartida.Text));
        }

        public bool VerificaVez()
        {
            ConsultarMao();
            txbVez.Text = Jogo.VerificarVez(Convert.ToInt32(txbIdPartida.Text));

            string id = txbIdJogador.Text;
            int idPart = Convert.ToInt32(txbIdPartida.Text);
            string textoVez = Jogo.VerificarVez(idPart);
            textoVez = textoVez.Replace("\r\n", ",");
            string[] vetVez = textoVez.Split(',');

            if (vetVez[1] == id) return true;
            else return false;
        }

        private void ConsultarMao()
        {
            int idJogador = Convert.ToInt32(txbIdJogador.Text);
            string senhaJogador = txbSenhaJogador.Text;
            lblMostraMao.Text = Jogo.ConsultarMao(idJogador, senhaJogador);
        }

        public void ListarJogadores()
        {
            int idPart = Convert.ToInt32(txbIdPartida.Text);
            txbListarJogadores.Text = Jogo.ListarJogadores(idPart);
        }

        public string Tabuleiro(int posicao)
        {
            int idPartida = Convert.ToInt32(txbIdPartida.Text);
            string textoTabuleiro = Jogo.ExibirTabuleiro(idPartida).Replace("\r\n", "!");

            string[] vetTabuleiro = textoTabuleiro.Split('!');

            //Elimina numeros da String, mantendo a carta em cada posição, dada pelo indice
            for (int i = 0; i <= 37; i++)
            {
                string j = (i.ToString()) + ',';
                vetTabuleiro[i] = vetTabuleiro[i].Replace(j, "");                
            }

            return vetTabuleiro[posicao];

        }

        //OUTROS  ---------------------------------------------------------------------------------------------------------------------------------------------
        private void butListarPartidas_Click(object sender, EventArgs e)
        {
            //Lista Partidas de acordo com RadioButton.
            if (rbtAbertas.Checked) txbPartidas.Text = Jogo.ListarPartidas("A");
            else if (rbtFechadas.Checked) txbPartidas.Text = Jogo.ListarPartidas("F");
            else if (rbtJogando.Checked) txbPartidas.Text = Jogo.ListarPartidas("J");
            else txbPartidas.Text = Jogo.ListarPartidas("T");
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string senha = txbSenhaPartida.Text;
            string nome = txbNomePartida.Text;

            //Cria Uma Nova Partida
            txbIdPartida.Text = Jogo.CriarPartida(nome, senha);
        }
        
        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            //Lista Os Jogadores Na Partida Atual
            ListarJogadores();
        }
        
        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            int idPartida = Convert.ToInt32(txbIdPartida.Text);
            string senhaPartida = txbSenhaPartida.Text;
            string nomeJogador = txbNomeJogador.Text;

            //Adiciona a string retornada por "EntrarPartida" ao vetor
            string[] jogador = Jogo.EntrarPartida(idPartida, nomeJogador, senhaPartida).Split(',');

            //Define as TextBox relacionada ao jogador
            txbIdJogador.Text = jogador[0];
            txbSenhaJogador.Text = jogador[1];
            lblCorJogador.Text = jogador[2];

            //Lisat Jogadores ao entrar na partida
            ListarJogadores();
        }
    
        private void butIniciaPartida_Click(object sender, EventArgs e)
        {
            //Inicia A partida
            Jogo.IniciarPartida(Convert.ToInt32(txbIdJogador.Text), txbSenhaJogador.Text);

            ListarJogadores();
            ConsultarMao();
            ExibirTabuleiro();

            int idPartida = Convert.ToInt32(txbIdPartida.Text);
            txbVez.Text = Jogo.VerificarVez(idPartida);
        }

        private void btnExibirMao_Click(object sender, EventArgs e)
        {
            ConsultarMao();
        }

        private void butIniciarTimerJogo_Click(object sender, EventArgs e)
        {
            timerJogar.Enabled = true;

        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            int idPart = Convert.ToInt32(txbIdPartida.Text);
            txbVez.Text = Jogo.VerificarVez(idPart);
        }

        private void timerJogar_Tick(object sender, EventArgs e)
        {

            if (VerificaVez()) RealizarJogada();
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            lblTmp.Text = Tabuleiro(1);
        }


    }
}
