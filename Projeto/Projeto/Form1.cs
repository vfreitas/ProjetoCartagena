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

        private void butListarPartidas_Click(object sender, EventArgs e)
        {
            if (rbtAbertas.Checked)
            {
                txbPartidas.Text =  Jogo.ListarPartidas("A");
            }
            else if (rbtFechadas.Checked)
            {
                txbPartidas.Text = Jogo.ListarPartidas("F");
            }
            else if (rbtJogando.Checked)
            {
                txbPartidas.Text = Jogo.ListarPartidas("J");
            }
            else
            {
                txbPartidas.Text = Jogo.ListarPartidas("T");
            }
        }


        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string senha = txbNomePartida.Text;
            string nome = txbSenhaPartida.Text;

            txbIdPartida.Text = Jogo.CriarPartida(nome, senha);

        }



        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            int idPartida = Convert.ToInt32(txbIdPartida.Text);
            txbListarJogadores.Text = Jogo.ListarJogadores(idPartida);
        }



        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIdPartida.Text);
            string senha = txbSenha.Text;
            string nome = txbNomeJogador.Text;

            string[] jogador = Jogo.EntrarPartida(id, nome, senha).Split(',');


            lblIdJogador.Text = jogador[0];
            lblSenhaJogador.Text = jogador[1];
            lblCorJogador.Text = jogador[2];

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Jogo.IniciarPartida(Convert.ToInt32(lblIdJogador.Text), lblSenhaJogador.Text);
        }

       
        private void BtnMostra_Click(object sender, EventArgs e)
        {
            int id =  Convert.ToInt32(lblIdJogador.Text);
            string senha = lblSenhaJogador.Text;
            lblMostraMao.Text = Jogo.ConsultarMao(id, senha);
        }

        private void BtnExibirTab_Click(object sender, EventArgs e)
        {
            lblExibirTabuleiro.Text = Jogo.ExibirTabuleiro(Convert.ToInt32(txbIdPartida.Text));
        }

        private void ButJogar_Click(object sender, EventArgs e)
        {
            timerJogar.Enabled = true;





        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButTemp_Click(object sender, EventArgs e)
        {
            int idPart = Convert.ToInt32(txbIdPartida.Text);

            txbRef.Text = Jogo.VerificarVez(idPart);
        }

        public void RealizarJogada()
        {
            string id = lblIdJogador.Text;
            int idJogador = Convert.ToInt32(id);
            string senha = lblSenhaJogador.Text;
            lblMostraMao.Text = Jogo.ConsultarMao(idJogador, senha);

            string textoMao = lblMostraMao.Text;
            textoMao = textoMao.Replace("\r\n", ",");

            string[] vetMao = textoMao.Split(',');


            int idPart = Convert.ToInt32(txbIdPartida.Text);

            string textoVez = Jogo.VerificarVez(idPart);
            textoVez = textoVez.Replace("\r\n", ",");

            string[] vetVez = textoVez.Split(',');


            if (vetVez[1] == id)
            {
                if (vetMao[0] == "C") Jogo.Jogar(idJogador, senha,0,"C");
                else if (vetMao[0] == "P") Jogo.Jogar(idJogador, senha, 0, "P");
                else if (vetMao[0] == "T") Jogo.Jogar(idJogador, senha, 0, "T");
                else if (vetMao[0] == "F") Jogo.Jogar(idJogador, senha, 0, "F");
                else if (vetMao[0] == "E") Jogo.Jogar(idJogador, senha, 0, "E");
                else if (vetMao[0] == "G") Jogo.Jogar(idJogador, senha, 0, "G");
            }

        }

        private void timerJogar_Tick(object sender, EventArgs e)
        {
            lblMostraMao.Text = Jogo.ConsultarMao(Convert.ToInt32(lblIdJogador.Text), lblSenhaJogador.Text);
            txbRef.Text = Jogo.VerificarVez(Convert.ToInt32(txbIdPartida.Text));

            RealizarJogada();


        }

        private void txbIdPartida_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
