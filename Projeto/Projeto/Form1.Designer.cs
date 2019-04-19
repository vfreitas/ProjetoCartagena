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
            this.txbNomePartida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSenhaPartida = new System.Windows.Forms.TextBox();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.txbIdPartida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbListarJogadores = new System.Windows.Forms.TextBox();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbRef = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbNomeJogador = new System.Windows.Forms.TextBox();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txbIdJogadorInit = new System.Windows.Forms.TextBox();
            this.txbSenhaJogadorInit = new System.Windows.Forms.TextBox();
            this.butTemp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.lblCorJogador = new System.Windows.Forms.Label();
            this.btnExibirMao = new System.Windows.Forms.Button();
            this.lblMostraMao = new System.Windows.Forms.Label();
            this.btnExibirTab = new System.Windows.Forms.Button();
            this.lblExibirTabuleiro = new System.Windows.Forms.Label();
            this.butJogar = new System.Windows.Forms.Button();
            this.rbtVolta = new System.Windows.Forms.RadioButton();
            this.rbtPassa = new System.Windows.Forms.RadioButton();
            this.rbtFrente = new System.Windows.Forms.RadioButton();
            this.txbCarta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txbPosicao = new System.Windows.Forms.TextBox();
            this.timerJogar = new System.Windows.Forms.Timer(this.components);
            this.lblVersao = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.txbPartidas.Size = new System.Drawing.Size(210, 475);
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
            // txbNomePartida
            // 
            this.txbNomePartida.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbNomePartida.Location = new System.Drawing.Point(337, 35);
            this.txbNomePartida.Name = "txbNomePartida";
            this.txbNomePartida.Size = new System.Drawing.Size(86, 20);
            this.txbNomePartida.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 46);
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
            // txbSenhaPartida
            // 
            this.txbSenhaPartida.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbSenhaPartida.Location = new System.Drawing.Point(231, 62);
            this.txbSenhaPartida.Name = "txbSenhaPartida";
            this.txbSenhaPartida.Size = new System.Drawing.Size(126, 20);
            this.txbSenhaPartida.TabIndex = 14;
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
            this.txbIdPartida.TextChanged += new System.EventHandler(this.txbIdPartida_TextChanged);
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
            this.txbListarJogadores.Size = new System.Drawing.Size(187, 100);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Senha";
            // 
            // txbSenha
            // 
            this.txbSenha.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbSenha.Location = new System.Drawing.Point(451, 62);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(96, 20);
            this.txbSenha.TabIndex = 24;
            // 
            // txbRef
            // 
            this.txbRef.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbRef.Location = new System.Drawing.Point(456, 361);
            this.txbRef.Multiline = true;
            this.txbRef.Name = "txbRef";
            this.txbRef.Size = new System.Drawing.Size(212, 73);
            this.txbRef.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(557, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Nome Jogador";
            // 
            // txbNomeJogador
            // 
            this.txbNomeJogador.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbNomeJogador.Location = new System.Drawing.Point(550, 62);
            this.txbNomeJogador.Name = "txbNomeJogador";
            this.txbNomeJogador.Size = new System.Drawing.Size(96, 20);
            this.txbNomeJogador.TabIndex = 27;
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Location = new System.Drawing.Point(594, 92);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(10, 13);
            this.lblIdJogador.TabIndex = 29;
            this.lblIdJogador.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(465, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Seu ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Iniciar Partida";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Id Jogador";
            // 
            // txbIdJogadorInit
            // 
            this.txbIdJogadorInit.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbIdJogadorInit.Location = new System.Drawing.Point(232, 276);
            this.txbIdJogadorInit.Name = "txbIdJogadorInit";
            this.txbIdJogadorInit.Size = new System.Drawing.Size(96, 20);
            this.txbIdJogadorInit.TabIndex = 32;
            // 
            // txbSenhaJogadorInit
            // 
            this.txbSenhaJogadorInit.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbSenhaJogadorInit.Location = new System.Drawing.Point(337, 276);
            this.txbSenhaJogadorInit.Name = "txbSenhaJogadorInit";
            this.txbSenhaJogadorInit.Size = new System.Drawing.Size(96, 20);
            this.txbSenhaJogadorInit.TabIndex = 34;
            // 
            // butTemp
            // 
            this.butTemp.Location = new System.Drawing.Point(566, 332);
            this.butTemp.Name = "butTemp";
            this.butTemp.Size = new System.Drawing.Size(102, 23);
            this.butTemp.TabIndex = 36;
            this.butTemp.Text = "Temp";
            this.butTemp.UseVisualStyleBackColor = true;
            this.butTemp.Click += new System.EventHandler(this.ButTemp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Sua Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Sua Cor";
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Location = new System.Drawing.Point(594, 121);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(10, 13);
            this.lblSenhaJogador.TabIndex = 39;
            this.lblSenhaJogador.Text = "-";
            // 
            // lblCorJogador
            // 
            this.lblCorJogador.AutoSize = true;
            this.lblCorJogador.Location = new System.Drawing.Point(594, 143);
            this.lblCorJogador.Name = "lblCorJogador";
            this.lblCorJogador.Size = new System.Drawing.Size(10, 13);
            this.lblCorJogador.TabIndex = 40;
            this.lblCorJogador.Text = "-";
            // 
            // btnExibirMao
            // 
            this.btnExibirMao.Location = new System.Drawing.Point(653, 12);
            this.btnExibirMao.Name = "btnExibirMao";
            this.btnExibirMao.Size = new System.Drawing.Size(97, 26);
            this.btnExibirMao.TabIndex = 41;
            this.btnExibirMao.Text = "Exibir Mao";
            this.btnExibirMao.UseVisualStyleBackColor = true;
            this.btnExibirMao.Click += new System.EventHandler(this.BtnMostra_Click);
            // 
            // lblMostraMao
            // 
            this.lblMostraMao.AutoSize = true;
            this.lblMostraMao.Location = new System.Drawing.Point(699, 41);
            this.lblMostraMao.Name = "lblMostraMao";
            this.lblMostraMao.Size = new System.Drawing.Size(10, 13);
            this.lblMostraMao.TabIndex = 42;
            this.lblMostraMao.Text = "-";
            // 
            // btnExibirTab
            // 
            this.btnExibirTab.Location = new System.Drawing.Point(770, 12);
            this.btnExibirTab.Name = "btnExibirTab";
            this.btnExibirTab.Size = new System.Drawing.Size(97, 26);
            this.btnExibirTab.TabIndex = 43;
            this.btnExibirTab.Text = "Exibir Tabuleiro";
            this.btnExibirTab.UseVisualStyleBackColor = true;
            this.btnExibirTab.Click += new System.EventHandler(this.BtnExibirTab_Click);
            // 
            // lblExibirTabuleiro
            // 
            this.lblExibirTabuleiro.AutoSize = true;
            this.lblExibirTabuleiro.Location = new System.Drawing.Point(823, 44);
            this.lblExibirTabuleiro.Name = "lblExibirTabuleiro";
            this.lblExibirTabuleiro.Size = new System.Drawing.Size(10, 13);
            this.lblExibirTabuleiro.TabIndex = 44;
            this.lblExibirTabuleiro.Text = "-";
            // 
            // butJogar
            // 
            this.butJogar.Location = new System.Drawing.Point(502, 176);
            this.butJogar.Name = "butJogar";
            this.butJogar.Size = new System.Drawing.Size(102, 23);
            this.butJogar.TabIndex = 45;
            this.butJogar.Text = "Iniciar Timer";
            this.butJogar.UseVisualStyleBackColor = true;
            this.butJogar.Click += new System.EventHandler(this.ButJogar_Click);
            // 
            // rbtVolta
            // 
            this.rbtVolta.AutoSize = true;
            this.rbtVolta.Location = new System.Drawing.Point(528, 205);
            this.rbtVolta.Name = "rbtVolta";
            this.rbtVolta.Size = new System.Drawing.Size(49, 17);
            this.rbtVolta.TabIndex = 48;
            this.rbtVolta.Text = "Volta";
            this.rbtVolta.UseVisualStyleBackColor = true;
            // 
            // rbtPassa
            // 
            this.rbtPassa.AutoSize = true;
            this.rbtPassa.Location = new System.Drawing.Point(579, 205);
            this.rbtPassa.Name = "rbtPassa";
            this.rbtPassa.Size = new System.Drawing.Size(54, 17);
            this.rbtPassa.TabIndex = 47;
            this.rbtPassa.Text = "Passa";
            this.rbtPassa.UseVisualStyleBackColor = true;
            // 
            // rbtFrente
            // 
            this.rbtFrente.AutoSize = true;
            this.rbtFrente.Checked = true;
            this.rbtFrente.Location = new System.Drawing.Point(470, 205);
            this.rbtFrente.Name = "rbtFrente";
            this.rbtFrente.Size = new System.Drawing.Size(55, 17);
            this.rbtFrente.TabIndex = 46;
            this.rbtFrente.TabStop = true;
            this.rbtFrente.Text = "Frente";
            this.rbtFrente.UseVisualStyleBackColor = true;
            // 
            // txbCarta
            // 
            this.txbCarta.Location = new System.Drawing.Point(533, 235);
            this.txbCarta.Name = "txbCarta";
            this.txbCarta.Size = new System.Drawing.Size(52, 20);
            this.txbCarta.TabIndex = 49;
            this.txbCarta.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(476, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Carta: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(476, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "Posição: ";
            // 
            // txbPosicao
            // 
            this.txbPosicao.Location = new System.Drawing.Point(533, 261);
            this.txbPosicao.Name = "txbPosicao";
            this.txbPosicao.Size = new System.Drawing.Size(52, 20);
            this.txbPosicao.TabIndex = 51;
            // 
            // timerJogar
            // 
            this.timerJogar.Interval = 3500;
            this.timerJogar.Tick += new System.EventHandler(this.timerJogar_Tick);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(536, 486);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(0, 13);
            this.lblVersao.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(362, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Senha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 554);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txbPosicao);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbCarta);
            this.Controls.Add(this.rbtVolta);
            this.Controls.Add(this.rbtPassa);
            this.Controls.Add(this.rbtFrente);
            this.Controls.Add(this.butJogar);
            this.Controls.Add(this.lblExibirTabuleiro);
            this.Controls.Add(this.btnExibirTab);
            this.Controls.Add(this.lblMostraMao);
            this.Controls.Add(this.btnExibirMao);
            this.Controls.Add(this.lblCorJogador);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butTemp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbSenhaJogadorInit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbIdJogadorInit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblIdJogador);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbNomeJogador);
            this.Controls.Add(this.txbRef);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.txbListarJogadores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbIdPartida);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.txbSenhaPartida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNomePartida);
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
        private System.Windows.Forms.TextBox txbNomePartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSenhaPartida;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.TextBox txbIdPartida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbListarJogadores;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbRef;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbNomeJogador;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbIdJogadorInit;
        private System.Windows.Forms.TextBox txbSenhaJogadorInit;
        private System.Windows.Forms.Button butTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.Label lblCorJogador;
        private System.Windows.Forms.Button btnExibirMao;
        private System.Windows.Forms.Label lblMostraMao;
        private System.Windows.Forms.Button btnExibirTab;
        private System.Windows.Forms.Label lblExibirTabuleiro;
        private System.Windows.Forms.Button butJogar;
        private System.Windows.Forms.RadioButton rbtVolta;
        private System.Windows.Forms.RadioButton rbtPassa;
        private System.Windows.Forms.RadioButton rbtFrente;
        private System.Windows.Forms.TextBox txbCarta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbPosicao;
        private System.Windows.Forms.Timer timerJogar;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label label10;
    }
}

