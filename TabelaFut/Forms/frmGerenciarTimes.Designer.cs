namespace TabelaFut
{
    partial class frmGerenciarTimes
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
            this.lbAtletas = new System.Windows.Forms.ListBox();
            this.lblJogadoresNoTime = new MaterialSkin.Controls.MaterialLabel();
            this.btn_AddTime = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_ExcluirTime = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_EditTime = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbTimes = new System.Windows.Forms.ListBox();
            this.lblTimes = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.btn_FecharGerenciarTimes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lbAtletas
            // 
            this.lbAtletas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAtletas.FormattingEnabled = true;
            this.lbAtletas.Location = new System.Drawing.Point(357, 103);
            this.lbAtletas.Name = "lbAtletas";
            this.lbAtletas.Size = new System.Drawing.Size(203, 197);
            this.lbAtletas.TabIndex = 11;
            this.lbAtletas.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.LbAtletas_Format);
            // 
            // lblJogadoresNoTime
            // 
            this.lblJogadoresNoTime.AutoSize = true;
            this.lblJogadoresNoTime.Depth = 0;
            this.lblJogadoresNoTime.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblJogadoresNoTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblJogadoresNoTime.Location = new System.Drawing.Point(353, 75);
            this.lblJogadoresNoTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblJogadoresNoTime.Name = "lblJogadoresNoTime";
            this.lblJogadoresNoTime.Size = new System.Drawing.Size(161, 19);
            this.lblJogadoresNoTime.TabIndex = 12;
            this.lblJogadoresNoTime.Text = "Jogadores do Time (0)";
            // 
            // btn_AddTime
            // 
            this.btn_AddTime.AutoSize = true;
            this.btn_AddTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_AddTime.Depth = 0;
            this.btn_AddTime.Icon = null;
            this.btn_AddTime.Location = new System.Drawing.Point(22, 311);
            this.btn_AddTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_AddTime.Name = "btn_AddTime";
            this.btn_AddTime.Primary = true;
            this.btn_AddTime.Size = new System.Drawing.Size(104, 36);
            this.btn_AddTime.TabIndex = 0;
            this.btn_AddTime.Text = "+ Adicionar";
            this.btn_AddTime.UseVisualStyleBackColor = true;
            this.btn_AddTime.Click += new System.EventHandler(this.Btn_AddTime_Click);
            // 
            // btn_ExcluirTime
            // 
            this.btn_ExcluirTime.AutoSize = true;
            this.btn_ExcluirTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ExcluirTime.Depth = 0;
            this.btn_ExcluirTime.Icon = null;
            this.btn_ExcluirTime.Location = new System.Drawing.Point(218, 311);
            this.btn_ExcluirTime.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ExcluirTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ExcluirTime.Name = "btn_ExcluirTime";
            this.btn_ExcluirTime.Primary = false;
            this.btn_ExcluirTime.Size = new System.Drawing.Size(92, 36);
            this.btn_ExcluirTime.TabIndex = 1;
            this.btn_ExcluirTime.Text = "- Remover";
            this.btn_ExcluirTime.UseVisualStyleBackColor = true;
            this.btn_ExcluirTime.Click += new System.EventHandler(this.btn_ExcluirTime_Click);
            // 
            // btn_EditTime
            // 
            this.btn_EditTime.AutoSize = true;
            this.btn_EditTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_EditTime.Depth = 0;
            this.btn_EditTime.Icon = null;
            this.btn_EditTime.Location = new System.Drawing.Point(131, 311);
            this.btn_EditTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_EditTime.Name = "btn_EditTime";
            this.btn_EditTime.Primary = true;
            this.btn_EditTime.Size = new System.Drawing.Size(82, 36);
            this.btn_EditTime.TabIndex = 2;
            this.btn_EditTime.Text = "⚙ Editar";
            this.btn_EditTime.UseVisualStyleBackColor = true;
            this.btn_EditTime.Click += new System.EventHandler(this.Btn_EditTime_Click);
            // 
            // lbTimes
            // 
            this.lbTimes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTimes.FormattingEnabled = true;
            this.lbTimes.Location = new System.Drawing.Point(22, 103);
            this.lbTimes.Name = "lbTimes";
            this.lbTimes.Size = new System.Drawing.Size(288, 197);
            this.lbTimes.TabIndex = 7;
            this.lbTimes.SelectedIndexChanged += new System.EventHandler(this.LbTimes_SelectedIndexChanged);
            this.lbTimes.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.LbTimes_Format);
            // 
            // lblTimes
            // 
            this.lblTimes.AutoSize = true;
            this.lblTimes.Depth = 0;
            this.lblTimes.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTimes.Location = new System.Drawing.Point(18, 75);
            this.lblTimes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(73, 19);
            this.lblTimes.TabIndex = 12;
            this.lblTimes.Text = "Times (0)";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(75, 23);
            this.materialDivider1.TabIndex = 13;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(0, 359);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(600, 1);
            this.materialDivider2.TabIndex = 14;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // btn_FecharGerenciarTimes
            // 
            this.btn_FecharGerenciarTimes.AutoSize = true;
            this.btn_FecharGerenciarTimes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_FecharGerenciarTimes.Depth = 0;
            this.btn_FecharGerenciarTimes.Icon = null;
            this.btn_FecharGerenciarTimes.Location = new System.Drawing.Point(514, 372);
            this.btn_FecharGerenciarTimes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_FecharGerenciarTimes.Name = "btn_FecharGerenciarTimes";
            this.btn_FecharGerenciarTimes.Primary = true;
            this.btn_FecharGerenciarTimes.Size = new System.Drawing.Size(73, 36);
            this.btn_FecharGerenciarTimes.TabIndex = 15;
            this.btn_FecharGerenciarTimes.Text = "Fechar";
            this.btn_FecharGerenciarTimes.UseVisualStyleBackColor = true;
            this.btn_FecharGerenciarTimes.Click += new System.EventHandler(this.btn_FecharGerenciarTimes_Click);
            // 
            // frmGerenciarTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 423);
            this.Controls.Add(this.btn_FecharGerenciarTimes);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.lblJogadoresNoTime);
            this.Controls.Add(this.lblTimes);
            this.Controls.Add(this.lbAtletas);
            this.Controls.Add(this.lbTimes);
            this.Controls.Add(this.btn_EditTime);
            this.Controls.Add(this.btn_ExcluirTime);
            this.Controls.Add(this.btn_AddTime);
            this.MaximizeBox = false;
            this.Name = "frmGerenciarTimes";
            this.Text = "Gerenciar Times";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGerenciarTimes_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAtletas;
        private MaterialSkin.Controls.MaterialLabel lblJogadoresNoTime;
        private MaterialSkin.Controls.MaterialRaisedButton btn_AddTime;
        private MaterialSkin.Controls.MaterialFlatButton btn_ExcluirTime;
        private MaterialSkin.Controls.MaterialRaisedButton btn_EditTime;
        private System.Windows.Forms.ListBox lbTimes;
        private MaterialSkin.Controls.MaterialLabel lblTimes;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialRaisedButton btn_FecharGerenciarTimes;
    }
}