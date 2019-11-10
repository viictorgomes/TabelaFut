﻿namespace TabelaFut
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabClassificacao = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Clube = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pontos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vitorias = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Empates = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Derrotas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GolsFeitos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GolsSofridos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaldoDeGols = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabEstatisticas = new System.Windows.Forms.TabPage();
            this.tabGerenciamento = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.tabClassificacao.SuspendLayout();
            this.tabGerenciamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabClassificacao);
            this.materialTabControl1.Controls.Add(this.tabEstatisticas);
            this.materialTabControl1.Controls.Add(this.tabGerenciamento);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 78);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(800, 522);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabClassificacao
            // 
            this.tabClassificacao.Controls.Add(this.listView1);
            this.tabClassificacao.Location = new System.Drawing.Point(4, 22);
            this.tabClassificacao.Name = "tabClassificacao";
            this.tabClassificacao.Padding = new System.Windows.Forms.Padding(3);
            this.tabClassificacao.Size = new System.Drawing.Size(792, 496);
            this.tabClassificacao.TabIndex = 0;
            this.tabClassificacao.Text = "Classificação";
            this.tabClassificacao.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Clube,
            this.Pontos,
            this.Vitorias,
            this.Empates,
            this.Derrotas,
            this.GolsFeitos,
            this.GolsSofridos,
            this.SaldoDeGols});
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(778, 482);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Clube
            // 
            this.Clube.Text = "Clube";
            this.Clube.Width = 160;
            // 
            // Pontos
            // 
            this.Pontos.Text = "Pontos";
            this.Pontos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Vitorias
            // 
            this.Vitorias.Text = "Vitórias";
            this.Vitorias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Empates
            // 
            this.Empates.Text = "Empates";
            this.Empates.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Derrotas
            // 
            this.Derrotas.Text = "Derrotas";
            this.Derrotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GolsFeitos
            // 
            this.GolsFeitos.Text = "Gols Feitos";
            this.GolsFeitos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GolsFeitos.Width = 80;
            // 
            // GolsSofridos
            // 
            this.GolsSofridos.Text = "Gols Sofridos";
            this.GolsSofridos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GolsSofridos.Width = 80;
            // 
            // SaldoDeGols
            // 
            this.SaldoDeGols.Text = "Saldo de Gols";
            this.SaldoDeGols.Width = 80;
            // 
            // tabEstatisticas
            // 
            this.tabEstatisticas.Location = new System.Drawing.Point(4, 22);
            this.tabEstatisticas.Name = "tabEstatisticas";
            this.tabEstatisticas.Size = new System.Drawing.Size(792, 496);
            this.tabEstatisticas.TabIndex = 2;
            this.tabEstatisticas.Text = "Estatísticas";
            this.tabEstatisticas.UseVisualStyleBackColor = true;
            // 
            // tabGerenciamento
            // 
            this.tabGerenciamento.Controls.Add(this.button5);
            this.tabGerenciamento.Controls.Add(this.button4);
            this.tabGerenciamento.Controls.Add(this.button3);
            this.tabGerenciamento.Controls.Add(this.button2);
            this.tabGerenciamento.Controls.Add(this.button1);
            this.tabGerenciamento.Location = new System.Drawing.Point(4, 22);
            this.tabGerenciamento.Name = "tabGerenciamento";
            this.tabGerenciamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabGerenciamento.Size = new System.Drawing.Size(792, 496);
            this.tabGerenciamento.TabIndex = 1;
            this.tabGerenciamento.Text = "Gerenciamento";
            this.tabGerenciamento.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(275, 205);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 144);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(79, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 144);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(487, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 144);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 144);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 144);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 25);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(800, 50);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Form1";
            this.materialTabControl1.ResumeLayout(false);
            this.tabClassificacao.ResumeLayout(false);
            this.tabGerenciamento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabClassificacao;
        private System.Windows.Forms.TabPage tabGerenciamento;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabEstatisticas;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Clube;
        private System.Windows.Forms.ColumnHeader Pontos;
        private System.Windows.Forms.ColumnHeader Vitorias;
        private System.Windows.Forms.ColumnHeader Empates;
        private System.Windows.Forms.ColumnHeader Derrotas;
        private System.Windows.Forms.ColumnHeader GolsFeitos;
        private System.Windows.Forms.ColumnHeader GolsSofridos;
        private System.Windows.Forms.ColumnHeader SaldoDeGols;
    }
}

