namespace Projeto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.butListarPartidas = new System.Windows.Forms.Button();
            this.txbPartidas = new System.Windows.Forms.TextBox();
            this.rbtTodas = new System.Windows.Forms.RadioButton();
            this.rbtAbertas = new System.Windows.Forms.RadioButton();
            this.rbtFechadas = new System.Windows.Forms.RadioButton();
            this.rbtJogando = new System.Windows.Forms.RadioButton();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.txbSenhaPartida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNomePartida = new System.Windows.Forms.TextBox();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.txbIdPartida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbListarJogadores = new System.Windows.Forms.TextBox();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.txbVez = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbNomeJogador = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.butIniciaPartida = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCorJogador = new System.Windows.Forms.Label();
            this.btnExibirMao = new System.Windows.Forms.Button();
            this.lblMostraMao = new System.Windows.Forms.Label();
            this.lblTabuleiro = new System.Windows.Forms.Label();
            this.butIniciarTimerJogo = new System.Windows.Forms.Button();
            this.timerJogar = new System.Windows.Forms.Timer(this.components);
            this.lblVersao = new System.Windows.Forms.Label();
            this.btnVerificarVez = new System.Windows.Forms.Button();
            this.txbIdJogador = new System.Windows.Forms.TextBox();
            this.txbSenhaJogador = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTmp = new System.Windows.Forms.Label();
            this.btnTemp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butListarPartidas
            // 
            this.butListarPartidas.Location = new System.Drawing.Point(12, 12);
            this.butListarPartidas.Name = "butListarPartidas";
            this.butListarPartidas.Size = new System.Drawing.Size(132, 26);
            this.butListarPartidas.TabIndex = 0;
            this.butListarPartidas.Text = "Listar Partidas";
            this.butListarPartidas.UseVisualStyleBackColor = true;
            this.butListarPartidas.Click += new System.EventHandler(this.butListarPartidas_Click);
            // 
            // txbPartidas
            // 
            this.txbPartidas.Location = new System.Drawing.Point(12, 67);
            this.txbPartidas.Multiline = true;
            this.txbPartidas.Name = "txbPartidas";
            this.txbPartidas.ReadOnly = true;
            this.txbPartidas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbPartidas.Size = new System.Drawing.Size(210, 303);
            this.txbPartidas.TabIndex = 1;
            // 
            // rbtTodas
            // 
            this.rbtTodas.AutoSize = true;
            this.rbtTodas.Checked = true;
            this.rbtTodas.Location = new System.Drawing.Point(13, 44);
            this.rbtTodas.Name = "rbtTodas";
            this.rbtTodas.Size = new System.Drawing.Size(55, 17);
            this.rbtTodas.TabIndex = 6;
            this.rbtTodas.TabStop = true;
            this.rbtTodas.Text = "Todas";
            this.rbtTodas.UseVisualStyleBackColor = true;
            // 
            // rbtAbertas
            // 
            this.rbtAbertas.AutoSize = true;
            this.rbtAbertas.Location = new System.Drawing.Point(156, 44);
            this.rbtAbertas.Name = "rbtAbertas";
            this.rbtAbertas.Size = new System.Drawing.Size(61, 17);
            this.rbtAbertas.TabIndex = 7;
            this.rbtAbertas.Text = "Abertas";
            this.rbtAbertas.UseVisualStyleBackColor = true;
            // 
            // rbtFechadas
            // 
            this.rbtFechadas.AutoSize = true;
            this.rbtFechadas.Location = new System.Drawing.Point(78, 44);
            this.rbtFechadas.Name = "rbtFechadas";
            this.rbtFechadas.Size = new System.Drawing.Size(72, 17);
            this.rbtFechadas.TabIndex = 8;
            this.rbtFechadas.Text = "Fechadas";
            this.rbtFechadas.UseVisualStyleBackColor = true;
            // 
            // rbtJogando
            // 
            this.rbtJogando.AutoSize = true;
            this.rbtJogando.Location = new System.Drawing.Point(156, 17);
            this.rbtJogando.Name = "rbtJogando";
            this.rbtJogando.Size = new System.Drawing.Size(66, 17);
            this.rbtJogando.TabIndex = 9;
            this.rbtJogando.Text = "Jogando";
            this.rbtJogando.UseVisualStyleBackColor = true;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(228, 12);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(100, 26);
            this.btnCriarPartida.TabIndex = 10;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // txbSenhaPartida
            // 
            this.txbSenhaPartida.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbSenhaPartida.Location = new System.Drawing.Point(337, 35);
            this.txbSenhaPartida.Name = "txbSenhaPartida";
            this.txbSenhaPartida.Size = new System.Drawing.Size(86, 20);
            this.txbSenhaPartida.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome da Partida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Senha da Partida";
            // 
            // txbNomePartida
            // 
            this.txbNomePartida.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbNomePartida.Location = new System.Drawing.Point(231, 62);
            this.txbNomePartida.Name = "txbNomePartida";
            this.txbNomePartida.Size = new System.Drawing.Size(97, 20);
            this.txbNomePartida.TabIndex = 14;
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Location = new System.Drawing.Point(323, 88);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(97, 26);
            this.btnListarJogadores.TabIndex = 17;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = true;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // txbIdPartida
            // 
            this.txbIdPartida.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbIdPartida.Location = new System.Drawing.Point(285, 92);
            this.txbIdPartida.Name = "txbIdPartida";
            this.txbIdPartida.Size = new System.Drawing.Size(31, 20);
            this.txbIdPartida.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "ID Partida";
            // 
            // txbListarJogadores
            // 
            this.txbListarJogadores.Location = new System.Drawing.Point(231, 118);
            this.txbListarJogadores.Multiline = true;
            this.txbListarJogadores.Name = "txbListarJogadores";
            this.txbListarJogadores.Size = new System.Drawing.Size(189, 100);
            this.txbListarJogadores.TabIndex = 20;
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(450, 12);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(97, 26);
            this.btnEntrarPartida.TabIndex = 21;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // txbVez
            // 
            this.txbVez.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbVez.Location = new System.Drawing.Point(231, 253);
            this.txbVez.Multiline = true;
            this.txbVez.Name = "txbVez";
            this.txbVez.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbVez.Size = new System.Drawing.Size(75, 117);
            this.txbVez.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(557, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Nome Jogador";
            // 
            // txbNomeJogador
            // 
            this.txbNomeJogador.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbNomeJogador.Location = new System.Drawing.Point(550, 19);
            this.txbNomeJogador.Name = "txbNomeJogador";
            this.txbNomeJogador.Size = new System.Drawing.Size(96, 20);
            this.txbNomeJogador.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Seu ID";
            // 
            // butIniciaPartida
            // 
            this.butIniciaPartida.Location = new System.Drawing.Point(452, 209);
            this.butIniciaPartida.Name = "butIniciaPartida";
            this.butIniciaPartida.Size = new System.Drawing.Size(102, 23);
            this.butIniciaPartida.TabIndex = 31;
            this.butIniciaPartida.Text = "Iniciar Partida";
            this.butIniciaPartida.UseVisualStyleBackColor = true;
            this.butIniciaPartida.Click += new System.EventHandler(this.butIniciaPartida_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Sua Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Sua Mão";
            // 
            // lblCorJogador
            // 
            this.lblCorJogador.AutoSize = true;
            this.lblCorJogador.Location = new System.Drawing.Point(596, 110);
            this.lblCorJogador.Name = "lblCorJogador";
            this.lblCorJogador.Size = new System.Drawing.Size(10, 13);
            this.lblCorJogador.TabIndex = 40;
            this.lblCorJogador.Text = "-";
            // 
            // btnExibirMao
            // 
            this.btnExibirMao.Location = new System.Drawing.Point(466, 177);
            this.btnExibirMao.Name = "btnExibirMao";
            this.btnExibirMao.Size = new System.Drawing.Size(96, 26);
            this.btnExibirMao.TabIndex = 41;
            this.btnExibirMao.Text = "Exibir Mao";
            this.btnExibirMao.UseVisualStyleBackColor = true;
            this.btnExibirMao.Click += new System.EventHandler(this.btnExibirMao_Click);
            // 
            // lblMostraMao
            // 
            this.lblMostraMao.AutoSize = true;
            this.lblMostraMao.Location = new System.Drawing.Point(596, 136);
            this.lblMostraMao.Name = "lblMostraMao";
            this.lblMostraMao.Size = new System.Drawing.Size(10, 13);
            this.lblMostraMao.TabIndex = 42;
            this.lblMostraMao.Text = "-";
            // 
            // lblTabuleiro
            // 
            this.lblTabuleiro.AutoSize = true;
            this.lblTabuleiro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblTabuleiro.Location = new System.Drawing.Point(670, 38);
            this.lblTabuleiro.Name = "lblTabuleiro";
            this.lblTabuleiro.Size = new System.Drawing.Size(51, 13);
            this.lblTabuleiro.TabIndex = 44;
            this.lblTabuleiro.Text = "Tabuleiro";
            this.lblTabuleiro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // butIniciarTimerJogo
            // 
            this.butIniciarTimerJogo.Location = new System.Drawing.Point(560, 209);
            this.butIniciarTimerJogo.Name = "butIniciarTimerJogo";
            this.butIniciarTimerJogo.Size = new System.Drawing.Size(102, 23);
            this.butIniciarTimerJogo.TabIndex = 45;
            this.butIniciarTimerJogo.Text = "Iniciar Timer Jogo";
            this.butIniciarTimerJogo.UseVisualStyleBackColor = true;
            this.butIniciarTimerJogo.Click += new System.EventHandler(this.butIniciarTimerJogo_Click);
            // 
            // timerJogar
            // 
            this.timerJogar.Interval = 2000;
            this.timerJogar.Tick += new System.EventHandler(this.timerJogar_Tick);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(12, 373);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(40, 13);
            this.lblVersao.TabIndex = 53;
            this.lblVersao.Text = "Versão";
            // 
            // btnVerificarVez
            // 
            this.btnVerificarVez.Location = new System.Drawing.Point(231, 224);
            this.btnVerificarVez.Name = "btnVerificarVez";
            this.btnVerificarVez.Size = new System.Drawing.Size(75, 23);
            this.btnVerificarVez.TabIndex = 54;
            this.btnVerificarVez.Text = "Verificar vez";
            this.btnVerificarVez.UseVisualStyleBackColor = true;
            this.btnVerificarVez.Click += new System.EventHandler(this.btnVerificarVez_Click);
            // 
            // txbIdJogador
            // 
            this.txbIdJogador.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbIdJogador.Location = new System.Drawing.Point(548, 59);
            this.txbIdJogador.Name = "txbIdJogador";
            this.txbIdJogador.Size = new System.Drawing.Size(96, 20);
            this.txbIdJogador.TabIndex = 55;
            // 
            // txbSenhaJogador
            // 
            this.txbSenhaJogador.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbSenhaJogador.Location = new System.Drawing.Point(548, 81);
            this.txbSenhaJogador.Name = "txbSenhaJogador";
            this.txbSenhaJogador.Size = new System.Drawing.Size(96, 20);
            this.txbSenhaJogador.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label9.Location = new System.Drawing.Point(670, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Tabuleiro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Sua Cor";
            // 
            // lblTmp
            // 
            this.lblTmp.AutoSize = true;
            this.lblTmp.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblTmp.Location = new System.Drawing.Point(784, 26);
            this.lblTmp.Name = "lblTmp";
            this.lblTmp.Size = new System.Drawing.Size(22, 13);
            this.lblTmp.TabIndex = 59;
            this.lblTmp.Text = "-----";
            this.lblTmp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTemp
            // 
            this.btnTemp.Location = new System.Drawing.Point(758, 4);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(75, 23);
            this.btnTemp.TabIndex = 60;
            this.btnTemp.Text = "Temp";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 578);
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.lblTmp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbSenhaJogador);
            this.Controls.Add(this.txbIdJogador);
            this.Controls.Add(this.btnVerificarVez);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.butIniciarTimerJogo);
            this.Controls.Add(this.lblTabuleiro);
            this.Controls.Add(this.lblMostraMao);
            this.Controls.Add(this.btnExibirMao);
            this.Controls.Add(this.lblCorJogador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butIniciaPartida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbNomeJogador);
            this.Controls.Add(this.txbVez);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.txbListarJogadores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbIdPartida);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.txbNomePartida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSenhaPartida);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.rbtJogando);
            this.Controls.Add(this.rbtFechadas);
            this.Controls.Add(this.rbtAbertas);
            this.Controls.Add(this.rbtTodas);
            this.Controls.Add(this.txbPartidas);
            this.Controls.Add(this.butListarPartidas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butListarPartidas;
        private System.Windows.Forms.TextBox txbPartidas;
        private System.Windows.Forms.RadioButton rbtTodas;
        private System.Windows.Forms.RadioButton rbtAbertas;
        private System.Windows.Forms.RadioButton rbtFechadas;
        private System.Windows.Forms.RadioButton rbtJogando;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.TextBox txbSenhaPartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNomePartida;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.TextBox txbIdPartida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbListarJogadores;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.TextBox txbVez;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbNomeJogador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button butIniciaPartida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCorJogador;
        private System.Windows.Forms.Button btnExibirMao;
        private System.Windows.Forms.Label lblMostraMao;
        private System.Windows.Forms.Label lblTabuleiro;
        private System.Windows.Forms.Button butIniciarTimerJogo;
        private System.Windows.Forms.Timer timerJogar;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Button btnVerificarVez;
        private System.Windows.Forms.TextBox txbIdJogador;
        private System.Windows.Forms.TextBox txbSenhaJogador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTmp;
        private System.Windows.Forms.Button btnTemp;
    }
}

