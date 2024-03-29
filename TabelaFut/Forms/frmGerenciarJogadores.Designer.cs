﻿namespace TabelaFut.Forms
{
    partial class frmGerenciarJogadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarJogadores));
            this.btn_FecharGerenciarTimes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.btn_EditJogador = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_ExcluirJogador = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_AddJogador = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblJogadores = new MaterialSkin.Controls.MaterialLabel();
            this.lbJogadores = new System.Windows.Forms.ListBox();
            this.lbl_ID = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Idade = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Altura = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Nome = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_TimeAtual = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_FecharGerenciarTimes
            // 
            this.btn_FecharGerenciarTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FecharGerenciarTimes.AutoSize = true;
            this.btn_FecharGerenciarTimes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_FecharGerenciarTimes.Depth = 0;
            this.btn_FecharGerenciarTimes.Icon = null;
            this.btn_FecharGerenciarTimes.Location = new System.Drawing.Point(617, 464);
            this.btn_FecharGerenciarTimes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_FecharGerenciarTimes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_FecharGerenciarTimes.Name = "btn_FecharGerenciarTimes";
            this.btn_FecharGerenciarTimes.Primary = true;
            this.btn_FecharGerenciarTimes.Size = new System.Drawing.Size(87, 36);
            this.btn_FecharGerenciarTimes.TabIndex = 25;
            this.btn_FecharGerenciarTimes.Text = "Fechar";
            this.btn_FecharGerenciarTimes.UseVisualStyleBackColor = true;
            this.btn_FecharGerenciarTimes.Click += new System.EventHandler(this.btn_FecharGerenciarTimes_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(0, 449);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(729, 1);
            this.materialDivider2.TabIndex = 24;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // btn_EditJogador
            // 
            this.btn_EditJogador.AutoSize = true;
            this.btn_EditJogador.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_EditJogador.Depth = 0;
            this.btn_EditJogador.Icon = null;
            this.btn_EditJogador.Location = new System.Drawing.Point(161, 378);
            this.btn_EditJogador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_EditJogador.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_EditJogador.Name = "btn_EditJogador";
            this.btn_EditJogador.Primary = true;
            this.btn_EditJogador.Size = new System.Drawing.Size(98, 36);
            this.btn_EditJogador.TabIndex = 23;
            this.btn_EditJogador.Text = "⚙ Editar";
            this.btn_EditJogador.UseVisualStyleBackColor = true;
            this.btn_EditJogador.Click += new System.EventHandler(this.btn_EditJogador_Click);
            // 
            // btn_ExcluirJogador
            // 
            this.btn_ExcluirJogador.AutoSize = true;
            this.btn_ExcluirJogador.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ExcluirJogador.Depth = 0;
            this.btn_ExcluirJogador.Icon = null;
            this.btn_ExcluirJogador.Location = new System.Drawing.Point(277, 378);
            this.btn_ExcluirJogador.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_ExcluirJogador.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ExcluirJogador.Name = "btn_ExcluirJogador";
            this.btn_ExcluirJogador.Primary = false;
            this.btn_ExcluirJogador.Size = new System.Drawing.Size(111, 36);
            this.btn_ExcluirJogador.TabIndex = 22;
            this.btn_ExcluirJogador.Text = "- Remover";
            this.btn_ExcluirJogador.UseVisualStyleBackColor = true;
            this.btn_ExcluirJogador.Click += new System.EventHandler(this.btn_ExcluirJogador_Click);
            // 
            // btn_AddJogador
            // 
            this.btn_AddJogador.AutoSize = true;
            this.btn_AddJogador.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_AddJogador.Depth = 0;
            this.btn_AddJogador.Icon = null;
            this.btn_AddJogador.Location = new System.Drawing.Point(16, 378);
            this.btn_AddJogador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AddJogador.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_AddJogador.Name = "btn_AddJogador";
            this.btn_AddJogador.Primary = true;
            this.btn_AddJogador.Size = new System.Drawing.Size(126, 36);
            this.btn_AddJogador.TabIndex = 21;
            this.btn_AddJogador.Text = "+ Adicionar";
            this.btn_AddJogador.UseVisualStyleBackColor = true;
            this.btn_AddJogador.Click += new System.EventHandler(this.btn_AddJogador_Click);
            // 
            // lblJogadores
            // 
            this.lblJogadores.AutoSize = true;
            this.lblJogadores.Depth = 0;
            this.lblJogadores.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblJogadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblJogadores.Location = new System.Drawing.Point(16, 95);
            this.lblJogadores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJogadores.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblJogadores.Name = "lblJogadores";
            this.lblJogadores.Size = new System.Drawing.Size(129, 24);
            this.lblJogadores.TabIndex = 20;
            this.lblJogadores.Text = "Jogadores (0)";
            // 
            // lbJogadores
            // 
            this.lbJogadores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbJogadores.FormattingEnabled = true;
            this.lbJogadores.ItemHeight = 16;
            this.lbJogadores.Location = new System.Drawing.Point(16, 124);
            this.lbJogadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbJogadores.Name = "lbJogadores";
            this.lbJogadores.Size = new System.Drawing.Size(383, 242);
            this.lbJogadores.TabIndex = 19;
            this.lbJogadores.SelectedIndexChanged += new System.EventHandler(this.lbJogadores_SelectedIndexChanged);
            this.lbJogadores.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lbJogadores_Format);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Depth = 0;
            this.lbl_ID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_ID.Location = new System.Drawing.Point(408, 193);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(61, 24);
            this.lbl_ID.TabIndex = 26;
            this.lbl_ID.Text = "ID: (0)";
            // 
            // lbl_Idade
            // 
            this.lbl_Idade.AutoSize = true;
            this.lbl_Idade.Depth = 0;
            this.lbl_Idade.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Idade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Idade.Location = new System.Drawing.Point(408, 229);
            this.lbl_Idade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Idade.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Idade.Name = "lbl_Idade";
            this.lbl_Idade.Size = new System.Drawing.Size(91, 24);
            this.lbl_Idade.TabIndex = 27;
            this.lbl_Idade.Text = "Idade: (0)";
            // 
            // lbl_Altura
            // 
            this.lbl_Altura.AutoSize = true;
            this.lbl_Altura.Depth = 0;
            this.lbl_Altura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Altura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Altura.Location = new System.Drawing.Point(408, 265);
            this.lbl_Altura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Altura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Altura.Name = "lbl_Altura";
            this.lbl_Altura.Size = new System.Drawing.Size(93, 24);
            this.lbl_Altura.TabIndex = 28;
            this.lbl_Altura.Text = "Altura: (0)";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Depth = 0;
            this.lbl_Nome.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Nome.Location = new System.Drawing.Point(408, 124);
            this.lbl_Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(62, 24);
            this.lbl_Nome.TabIndex = 30;
            this.lbl_Nome.Text = "Nome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TabelaFut.Properties.Resources.atleta100px;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(548, 161);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 123);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_TimeAtual
            // 
            this.lbl_TimeAtual.AutoSize = true;
            this.lbl_TimeAtual.Depth = 0;
            this.lbl_TimeAtual.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_TimeAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_TimeAtual.Location = new System.Drawing.Point(408, 336);
            this.lbl_TimeAtual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TimeAtual.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_TimeAtual.Name = "lbl_TimeAtual";
            this.lbl_TimeAtual.Size = new System.Drawing.Size(135, 24);
            this.lbl_TimeAtual.TabIndex = 32;
            this.lbl_TimeAtual.Text = "Time Atual: (0)";
            // 
            // frmGerenciarJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 523);
            this.Controls.Add(this.lbl_TimeAtual);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.lbl_Altura);
            this.Controls.Add(this.lbl_Idade);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btn_FecharGerenciarTimes);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.btn_EditJogador);
            this.Controls.Add(this.btn_ExcluirJogador);
            this.Controls.Add(this.btn_AddJogador);
            this.Controls.Add(this.lblJogadores);
            this.Controls.Add(this.lbJogadores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmGerenciarJogadores";
            this.Text = "Gerenciar Jogadores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btn_FecharGerenciarTimes;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialRaisedButton btn_EditJogador;
        private MaterialSkin.Controls.MaterialFlatButton btn_ExcluirJogador;
        private MaterialSkin.Controls.MaterialRaisedButton btn_AddJogador;
        private MaterialSkin.Controls.MaterialLabel lblJogadores;
        private System.Windows.Forms.ListBox lbJogadores;
        private MaterialSkin.Controls.MaterialLabel lbl_ID;
        private MaterialSkin.Controls.MaterialLabel lbl_Idade;
        private MaterialSkin.Controls.MaterialLabel lbl_Altura;
        private MaterialSkin.Controls.MaterialLabel lbl_Nome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lbl_TimeAtual;
    }
}