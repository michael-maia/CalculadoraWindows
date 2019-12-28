﻿namespace Calculadora {
    partial class calculadora {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuType = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPadrao = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCientifica = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoOperacoes = new System.Windows.Forms.TextBox();
            this.entradaNumeros = new System.Windows.Forms.TextBox();
            this.btnPercentagem = new System.Windows.Forms.Button();
            this.btnLimparAtual = new System.Windows.Forms.Button();
            this.btnLimparTudo = new System.Windows.Forms.Button();
            this.btnRaizQuad = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnAoQuadrado = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnInverterFracao = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnNegar = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuType});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(340, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuType
            // 
            this.menuType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPadrao,
            this.btnCientifica});
            this.menuType.Font = new System.Drawing.Font("Calibri", 9F);
            this.menuType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuType.Name = "menuType";
            this.menuType.Size = new System.Drawing.Size(43, 20);
            this.menuType.Text = "Tipo";
            this.menuType.Click += new System.EventHandler(this.tipoToolStripMenuItem_Click);
            // 
            // btnPadrao
            // 
            this.btnPadrao.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPadrao.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnPadrao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPadrao.Name = "btnPadrao";
            this.btnPadrao.Size = new System.Drawing.Size(180, 22);
            this.btnPadrao.Text = "Padrão";
            // 
            // btnCientifica
            // 
            this.btnCientifica.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCientifica.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnCientifica.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCientifica.Name = "btnCientifica";
            this.btnCientifica.Size = new System.Drawing.Size(180, 22);
            this.btnCientifica.Text = "Científica";
            // 
            // historicoOperacoes
            // 
            this.historicoOperacoes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.historicoOperacoes.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historicoOperacoes.ForeColor = System.Drawing.SystemColors.Window;
            this.historicoOperacoes.Location = new System.Drawing.Point(12, 27);
            this.historicoOperacoes.Name = "historicoOperacoes";
            this.historicoOperacoes.ReadOnly = true;
            this.historicoOperacoes.Size = new System.Drawing.Size(315, 27);
            this.historicoOperacoes.TabIndex = 1;
            this.historicoOperacoes.Text = "TESTE";
            this.historicoOperacoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.historicoOperacoes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // entradaNumeros
            // 
            this.entradaNumeros.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.entradaNumeros.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradaNumeros.ForeColor = System.Drawing.SystemColors.Window;
            this.entradaNumeros.Location = new System.Drawing.Point(12, 51);
            this.entradaNumeros.Margin = new System.Windows.Forms.Padding(0);
            this.entradaNumeros.Name = "entradaNumeros";
            this.entradaNumeros.Size = new System.Drawing.Size(315, 40);
            this.entradaNumeros.TabIndex = 2;
            this.entradaNumeros.Text = "TESTE";
            this.entradaNumeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPercentagem
            // 
            this.btnPercentagem.BackColor = System.Drawing.Color.Black;
            this.btnPercentagem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercentagem.ForeColor = System.Drawing.Color.White;
            this.btnPercentagem.Location = new System.Drawing.Point(12, 94);
            this.btnPercentagem.Name = "btnPercentagem";
            this.btnPercentagem.Size = new System.Drawing.Size(75, 54);
            this.btnPercentagem.TabIndex = 3;
            this.btnPercentagem.Text = "%";
            this.btnPercentagem.UseVisualStyleBackColor = false;
            // 
            // btnLimparAtual
            // 
            this.btnLimparAtual.BackColor = System.Drawing.Color.Black;
            this.btnLimparAtual.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparAtual.ForeColor = System.Drawing.Color.White;
            this.btnLimparAtual.Location = new System.Drawing.Point(12, 151);
            this.btnLimparAtual.Name = "btnLimparAtual";
            this.btnLimparAtual.Size = new System.Drawing.Size(75, 54);
            this.btnLimparAtual.TabIndex = 4;
            this.btnLimparAtual.Text = "CE";
            this.btnLimparAtual.UseVisualStyleBackColor = false;
            // 
            // btnLimparTudo
            // 
            this.btnLimparTudo.BackColor = System.Drawing.Color.Black;
            this.btnLimparTudo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparTudo.ForeColor = System.Drawing.Color.White;
            this.btnLimparTudo.Location = new System.Drawing.Point(93, 151);
            this.btnLimparTudo.Name = "btnLimparTudo";
            this.btnLimparTudo.Size = new System.Drawing.Size(75, 54);
            this.btnLimparTudo.TabIndex = 6;
            this.btnLimparTudo.Text = "C";
            this.btnLimparTudo.UseVisualStyleBackColor = false;
            // 
            // btnRaizQuad
            // 
            this.btnRaizQuad.BackColor = System.Drawing.Color.Black;
            this.btnRaizQuad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaizQuad.ForeColor = System.Drawing.Color.White;
            this.btnRaizQuad.Location = new System.Drawing.Point(93, 94);
            this.btnRaizQuad.Name = "btnRaizQuad";
            this.btnRaizQuad.Size = new System.Drawing.Size(75, 54);
            this.btnRaizQuad.TabIndex = 5;
            this.btnRaizQuad.Text = "√x";
            this.btnRaizQuad.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(174, 151);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 54);
            this.button5.TabIndex = 8;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnAoQuadrado
            // 
            this.btnAoQuadrado.BackColor = System.Drawing.Color.Black;
            this.btnAoQuadrado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAoQuadrado.ForeColor = System.Drawing.Color.White;
            this.btnAoQuadrado.Location = new System.Drawing.Point(174, 94);
            this.btnAoQuadrado.Name = "btnAoQuadrado";
            this.btnAoQuadrado.Size = new System.Drawing.Size(75, 54);
            this.btnAoQuadrado.TabIndex = 7;
            this.btnAoQuadrado.Text = "x²";
            this.btnAoQuadrado.UseVisualStyleBackColor = false;
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.Black;
            this.btnDividir.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnDividir.ForeColor = System.Drawing.Color.White;
            this.btnDividir.Location = new System.Drawing.Point(255, 151);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 54);
            this.btnDividir.TabIndex = 10;
            this.btnDividir.Text = "÷";
            this.btnDividir.UseVisualStyleBackColor = false;
            // 
            // btnInverterFracao
            // 
            this.btnInverterFracao.BackColor = System.Drawing.Color.Black;
            this.btnInverterFracao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInverterFracao.ForeColor = System.Drawing.Color.White;
            this.btnInverterFracao.Location = new System.Drawing.Point(255, 94);
            this.btnInverterFracao.Name = "btnInverterFracao";
            this.btnInverterFracao.Size = new System.Drawing.Size(75, 54);
            this.btnInverterFracao.TabIndex = 9;
            this.btnInverterFracao.Text = "1/x";
            this.btnInverterFracao.UseVisualStyleBackColor = false;
            // 
            // btnQuatro
            // 
            this.btnQuatro.BackColor = System.Drawing.Color.Black;
            this.btnQuatro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuatro.ForeColor = System.Drawing.Color.White;
            this.btnQuatro.Location = new System.Drawing.Point(12, 266);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(75, 54);
            this.btnQuatro.TabIndex = 12;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = false;
            // 
            // btnSete
            // 
            this.btnSete.BackColor = System.Drawing.Color.Black;
            this.btnSete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSete.ForeColor = System.Drawing.Color.White;
            this.btnSete.Location = new System.Drawing.Point(12, 209);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(75, 54);
            this.btnSete.TabIndex = 11;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = false;
            // 
            // btnNegar
            // 
            this.btnNegar.BackColor = System.Drawing.Color.Black;
            this.btnNegar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegar.ForeColor = System.Drawing.Color.White;
            this.btnNegar.Location = new System.Drawing.Point(12, 380);
            this.btnNegar.Name = "btnNegar";
            this.btnNegar.Size = new System.Drawing.Size(75, 54);
            this.btnNegar.TabIndex = 14;
            this.btnNegar.Text = "+/-";
            this.btnNegar.UseVisualStyleBackColor = false;
            // 
            // btnUm
            // 
            this.btnUm.BackColor = System.Drawing.Color.Black;
            this.btnUm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUm.ForeColor = System.Drawing.Color.White;
            this.btnUm.Location = new System.Drawing.Point(12, 323);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(75, 54);
            this.btnUm.TabIndex = 13;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = false;
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.Black;
            this.btnZero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.Color.White;
            this.btnZero.Location = new System.Drawing.Point(93, 380);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(75, 54);
            this.btnZero.TabIndex = 18;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            // 
            // btnDois
            // 
            this.btnDois.BackColor = System.Drawing.Color.Black;
            this.btnDois.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDois.ForeColor = System.Drawing.Color.White;
            this.btnDois.Location = new System.Drawing.Point(93, 323);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(75, 54);
            this.btnDois.TabIndex = 17;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = false;
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.Color.Black;
            this.btnCinco.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.ForeColor = System.Drawing.Color.White;
            this.btnCinco.Location = new System.Drawing.Point(93, 266);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(75, 54);
            this.btnCinco.TabIndex = 16;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            // 
            // btnOito
            // 
            this.btnOito.BackColor = System.Drawing.Color.Black;
            this.btnOito.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOito.ForeColor = System.Drawing.Color.White;
            this.btnOito.Location = new System.Drawing.Point(93, 209);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(75, 54);
            this.btnOito.TabIndex = 15;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = false;
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.Color.Black;
            this.btnVirgula.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnVirgula.ForeColor = System.Drawing.Color.White;
            this.btnVirgula.Location = new System.Drawing.Point(174, 380);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(75, 54);
            this.btnVirgula.TabIndex = 22;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.Color.Black;
            this.btnTres.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.ForeColor = System.Drawing.Color.White;
            this.btnTres.Location = new System.Drawing.Point(174, 323);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(75, 54);
            this.btnTres.TabIndex = 21;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.Color.Black;
            this.btnSeis.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.ForeColor = System.Drawing.Color.White;
            this.btnSeis.Location = new System.Drawing.Point(174, 266);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(75, 54);
            this.btnSeis.TabIndex = 20;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            // 
            // btnNove
            // 
            this.btnNove.BackColor = System.Drawing.Color.Black;
            this.btnNove.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNove.ForeColor = System.Drawing.Color.White;
            this.btnNove.Location = new System.Drawing.Point(174, 209);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(75, 54);
            this.btnNove.TabIndex = 19;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = false;
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.Black;
            this.btnIgual.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnIgual.ForeColor = System.Drawing.Color.White;
            this.btnIgual.Location = new System.Drawing.Point(255, 380);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(75, 54);
            this.btnIgual.TabIndex = 26;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.Color.Black;
            this.btnSomar.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnSomar.ForeColor = System.Drawing.Color.White;
            this.btnSomar.Location = new System.Drawing.Point(255, 323);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 54);
            this.btnSomar.TabIndex = 25;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = false;
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.Color.Black;
            this.btnSubtrair.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnSubtrair.ForeColor = System.Drawing.Color.White;
            this.btnSubtrair.Location = new System.Drawing.Point(255, 266);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(75, 54);
            this.btnSubtrair.TabIndex = 24;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.Black;
            this.btnMultiplicar.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnMultiplicar.ForeColor = System.Drawing.Color.White;
            this.btnMultiplicar.Location = new System.Drawing.Point(255, 209);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 54);
            this.btnMultiplicar.TabIndex = 23;
            this.btnMultiplicar.Text = "x";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            // 
            // calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(340, 442);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnNegar);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnInverterFracao);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnAoQuadrado);
            this.Controls.Add(this.btnLimparTudo);
            this.Controls.Add(this.btnRaizQuad);
            this.Controls.Add(this.btnLimparAtual);
            this.Controls.Add(this.btnPercentagem);
            this.Controls.Add(this.entradaNumeros);
            this.Controls.Add(this.historicoOperacoes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "calculadora";
            this.Text = "Calculadora";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuType;
        private System.Windows.Forms.ToolStripMenuItem btnPadrao;
        private System.Windows.Forms.ToolStripMenuItem btnCientifica;
        private System.Windows.Forms.TextBox historicoOperacoes;
        private System.Windows.Forms.TextBox entradaNumeros;
        private System.Windows.Forms.Button btnPercentagem;
        private System.Windows.Forms.Button btnLimparAtual;
        private System.Windows.Forms.Button btnLimparTudo;
        private System.Windows.Forms.Button btnRaizQuad;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnAoQuadrado;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnInverterFracao;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnNegar;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
    }
}

