namespace TabelaFut
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
            this.lblLegenda1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lvClassificacoes = new System.Windows.Forms.ListView();
            this.Spacer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Colocacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.lblLegenda2 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblLegenda4 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblLegenda3 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.materialTabControl1.SuspendLayout();
            this.tabClassificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabGerenciamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.materialTabControl1.Size = new System.Drawing.Size(800, 524);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabClassificacao
            // 
            this.tabClassificacao.Controls.Add(this.lblLegenda4);
            this.tabClassificacao.Controls.Add(this.pictureBox3);
            this.tabClassificacao.Controls.Add(this.lblLegenda3);
            this.tabClassificacao.Controls.Add(this.pictureBox4);
            this.tabClassificacao.Controls.Add(this.lblLegenda2);
            this.tabClassificacao.Controls.Add(this.pictureBox2);
            this.tabClassificacao.Controls.Add(this.lblLegenda1);
            this.tabClassificacao.Controls.Add(this.pictureBox1);
            this.tabClassificacao.Controls.Add(this.lvClassificacoes);
            this.tabClassificacao.Location = new System.Drawing.Point(4, 22);
            this.tabClassificacao.Name = "tabClassificacao";
            this.tabClassificacao.Padding = new System.Windows.Forms.Padding(3);
            this.tabClassificacao.Size = new System.Drawing.Size(792, 498);
            this.tabClassificacao.TabIndex = 0;
            this.tabClassificacao.Text = "Classificação";
            this.tabClassificacao.UseVisualStyleBackColor = true;
            this.tabClassificacao.Click += new System.EventHandler(this.TabClassificacao_Click);
            // 
            // lblLegenda1
            // 
            this.lblLegenda1.AutoSize = true;
            this.lblLegenda1.Depth = 0;
            this.lblLegenda1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLegenda1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLegenda1.Location = new System.Drawing.Point(20, 454);
            this.lblLegenda1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLegenda1.Name = "lblLegenda1";
            this.lblLegenda1.Size = new System.Drawing.Size(248, 17);
            this.lblLegenda1.TabIndex = 2;
            this.lblLegenda1.Text = "Fase de grupos da Copa Libertadores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.pictureBox1.Location = new System.Drawing.Point(6, 456);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lvClassificacoes
            // 
            this.lvClassificacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvClassificacoes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Spacer,
            this.Colocacao,
            this.Clube,
            this.Pontos,
            this.Vitorias,
            this.Empates,
            this.Derrotas,
            this.GolsFeitos,
            this.GolsSofridos,
            this.SaldoDeGols});
            this.lvClassificacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lvClassificacoes.FullRowSelect = true;
            this.lvClassificacoes.HideSelection = false;
            this.lvClassificacoes.Location = new System.Drawing.Point(-4, 6);
            this.lvClassificacoes.MultiSelect = false;
            this.lvClassificacoes.Name = "lvClassificacoes";
            this.lvClassificacoes.Size = new System.Drawing.Size(800, 424);
            this.lvClassificacoes.TabIndex = 0;
            this.lvClassificacoes.TileSize = new System.Drawing.Size(1, 1);
            this.lvClassificacoes.UseCompatibleStateImageBehavior = false;
            this.lvClassificacoes.View = System.Windows.Forms.View.Details;
            // 
            // Spacer
            // 
            this.Spacer.Text = "";
            this.Spacer.Width = 1;
            // 
            // Colocacao
            // 
            this.Colocacao.Text = "";
            this.Colocacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Colocacao.Width = 30;
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
            this.Pontos.Width = 70;
            // 
            // Vitorias
            // 
            this.Vitorias.Text = "Vitórias";
            this.Vitorias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Vitorias.Width = 70;
            // 
            // Empates
            // 
            this.Empates.Text = "Empates";
            this.Empates.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Empates.Width = 70;
            // 
            // Derrotas
            // 
            this.Derrotas.Text = "Derrotas";
            this.Derrotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Derrotas.Width = 70;
            // 
            // GolsFeitos
            // 
            this.GolsFeitos.Text = "Gols Feitos";
            this.GolsFeitos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GolsFeitos.Width = 100;
            // 
            // GolsSofridos
            // 
            this.GolsSofridos.Text = "Gols Sofridos";
            this.GolsSofridos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GolsSofridos.Width = 100;
            // 
            // SaldoDeGols
            // 
            this.SaldoDeGols.Text = "Saldo de Gols";
            this.SaldoDeGols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaldoDeGols.Width = 100;
            // 
            // tabEstatisticas
            // 
            this.tabEstatisticas.Location = new System.Drawing.Point(4, 22);
            this.tabEstatisticas.Name = "tabEstatisticas";
            this.tabEstatisticas.Size = new System.Drawing.Size(792, 498);
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
            this.tabGerenciamento.Size = new System.Drawing.Size(792, 498);
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
            // lblLegenda2
            // 
            this.lblLegenda2.AutoSize = true;
            this.lblLegenda2.Depth = 0;
            this.lblLegenda2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLegenda2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLegenda2.Location = new System.Drawing.Point(20, 477);
            this.lblLegenda2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLegenda2.Name = "lblLegenda2";
            this.lblLegenda2.Size = new System.Drawing.Size(239, 17);
            this.lblLegenda2.TabIndex = 4;
            this.lblLegenda2.Text = "Qualificatórias da Copa Libertadores";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(123)))), ((int)(((byte)(23)))));
            this.pictureBox2.Location = new System.Drawing.Point(6, 479);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblLegenda4
            // 
            this.lblLegenda4.AutoSize = true;
            this.lblLegenda4.Depth = 0;
            this.lblLegenda4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLegenda4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLegenda4.Location = new System.Drawing.Point(335, 477);
            this.lblLegenda4.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLegenda4.Name = "lblLegenda4";
            this.lblLegenda4.Size = new System.Drawing.Size(98, 17);
            this.lblLegenda4.TabIndex = 8;
            this.lblLegenda4.Text = "Rebaixamento";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.pictureBox3.Location = new System.Drawing.Point(321, 479);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // lblLegenda3
            // 
            this.lblLegenda3.AutoSize = true;
            this.lblLegenda3.Depth = 0;
            this.lblLegenda3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLegenda3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLegenda3.Location = new System.Drawing.Point(335, 454);
            this.lblLegenda3.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLegenda3.Name = "lblLegenda3";
            this.lblLegenda3.Size = new System.Drawing.Size(260, 17);
            this.lblLegenda3.TabIndex = 6;
            this.lblLegenda3.Text = "Fase de grupos da Copa Sul-Americana";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(83)))));
            this.pictureBox4.Location = new System.Drawing.Point(321, 456);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 15);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabClassificacao.ResumeLayout(false);
            this.tabClassificacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabGerenciamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.ListView lvClassificacoes;
        private System.Windows.Forms.ColumnHeader Clube;
        private System.Windows.Forms.ColumnHeader Pontos;
        private System.Windows.Forms.ColumnHeader Vitorias;
        private System.Windows.Forms.ColumnHeader Empates;
        private System.Windows.Forms.ColumnHeader Derrotas;
        private System.Windows.Forms.ColumnHeader GolsFeitos;
        private System.Windows.Forms.ColumnHeader GolsSofridos;
        private System.Windows.Forms.ColumnHeader SaldoDeGols;
        private System.Windows.Forms.ColumnHeader Colocacao;
        private System.Windows.Forms.ColumnHeader Spacer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblLegenda1;
        private MaterialSkin.Controls.MaterialLabel lblLegenda2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialLabel lblLegenda4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialLabel lblLegenda3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

