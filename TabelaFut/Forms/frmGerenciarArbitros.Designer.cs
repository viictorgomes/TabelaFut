namespace TabelaFut.Forms
{
    partial class frmGerenciarArbitros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarArbitros));
            this.lbArbitros = new System.Windows.Forms.ListBox();
            this.lblArbitros = new MaterialSkin.Controls.MaterialLabel();
            this.btn_EditArbitro = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_ExcluirArbitro = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_AddArbitro = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.btn_FecharGerenciarTimes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lbArbitros
            // 
            this.lbArbitros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbArbitros.FormattingEnabled = true;
            this.lbArbitros.Location = new System.Drawing.Point(12, 100);
            this.lbArbitros.Name = "lbArbitros";
            this.lbArbitros.Size = new System.Drawing.Size(288, 197);
            this.lbArbitros.TabIndex = 8;
            this.lbArbitros.SelectedIndexChanged += new System.EventHandler(this.lbArbitros_SelectedIndexChanged);
            this.lbArbitros.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lbArbitros_Format);
            // 
            // lblArbitros
            // 
            this.lblArbitros.AutoSize = true;
            this.lblArbitros.Depth = 0;
            this.lblArbitros.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblArbitros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblArbitros.Location = new System.Drawing.Point(12, 76);
            this.lblArbitros.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblArbitros.Name = "lblArbitros";
            this.lblArbitros.Size = new System.Drawing.Size(85, 19);
            this.lblArbitros.TabIndex = 13;
            this.lblArbitros.Text = "Árbitros (0)";
            // 
            // btn_EditArbitro
            // 
            this.btn_EditArbitro.AutoSize = true;
            this.btn_EditArbitro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_EditArbitro.Depth = 0;
            this.btn_EditArbitro.Icon = null;
            this.btn_EditArbitro.Location = new System.Drawing.Point(121, 306);
            this.btn_EditArbitro.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_EditArbitro.Name = "btn_EditArbitro";
            this.btn_EditArbitro.Primary = true;
            this.btn_EditArbitro.Size = new System.Drawing.Size(82, 36);
            this.btn_EditArbitro.TabIndex = 16;
            this.btn_EditArbitro.Text = "⚙ Editar";
            this.btn_EditArbitro.UseVisualStyleBackColor = true;
            this.btn_EditArbitro.Click += new System.EventHandler(this.btn_EditArbitro_Click);
            // 
            // btn_ExcluirArbitro
            // 
            this.btn_ExcluirArbitro.AutoSize = true;
            this.btn_ExcluirArbitro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ExcluirArbitro.Depth = 0;
            this.btn_ExcluirArbitro.Icon = null;
            this.btn_ExcluirArbitro.Location = new System.Drawing.Point(208, 306);
            this.btn_ExcluirArbitro.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ExcluirArbitro.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ExcluirArbitro.Name = "btn_ExcluirArbitro";
            this.btn_ExcluirArbitro.Primary = false;
            this.btn_ExcluirArbitro.Size = new System.Drawing.Size(92, 36);
            this.btn_ExcluirArbitro.TabIndex = 15;
            this.btn_ExcluirArbitro.Text = "- Remover";
            this.btn_ExcluirArbitro.UseVisualStyleBackColor = true;
            this.btn_ExcluirArbitro.Click += new System.EventHandler(this.btn_ExcluirArbitro_Click);
            // 
            // btn_AddArbitro
            // 
            this.btn_AddArbitro.AutoSize = true;
            this.btn_AddArbitro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_AddArbitro.Depth = 0;
            this.btn_AddArbitro.Icon = null;
            this.btn_AddArbitro.Location = new System.Drawing.Point(12, 306);
            this.btn_AddArbitro.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_AddArbitro.Name = "btn_AddArbitro";
            this.btn_AddArbitro.Primary = true;
            this.btn_AddArbitro.Size = new System.Drawing.Size(104, 36);
            this.btn_AddArbitro.TabIndex = 14;
            this.btn_AddArbitro.Text = "+ Adicionar";
            this.btn_AddArbitro.UseVisualStyleBackColor = true;
            this.btn_AddArbitro.Click += new System.EventHandler(this.btn_AddArbitro_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(0, 364);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(320, 1);
            this.materialDivider2.TabIndex = 17;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // btn_FecharGerenciarTimes
            // 
            this.btn_FecharGerenciarTimes.AutoSize = true;
            this.btn_FecharGerenciarTimes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_FecharGerenciarTimes.Depth = 0;
            this.btn_FecharGerenciarTimes.Icon = null;
            this.btn_FecharGerenciarTimes.Location = new System.Drawing.Point(237, 374);
            this.btn_FecharGerenciarTimes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_FecharGerenciarTimes.Name = "btn_FecharGerenciarTimes";
            this.btn_FecharGerenciarTimes.Primary = true;
            this.btn_FecharGerenciarTimes.Size = new System.Drawing.Size(73, 36);
            this.btn_FecharGerenciarTimes.TabIndex = 18;
            this.btn_FecharGerenciarTimes.Text = "Fechar";
            this.btn_FecharGerenciarTimes.UseVisualStyleBackColor = true;
            this.btn_FecharGerenciarTimes.Click += new System.EventHandler(this.btn_FecharGerenciarTimes_Click);
            // 
            // frmGerenciarArbitros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 420);
            this.Controls.Add(this.btn_FecharGerenciarTimes);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.btn_EditArbitro);
            this.Controls.Add(this.btn_ExcluirArbitro);
            this.Controls.Add(this.btn_AddArbitro);
            this.Controls.Add(this.lblArbitros);
            this.Controls.Add(this.lbArbitros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGerenciarArbitros";
            this.Text = "Gerenciar Árbitros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbArbitros;
        private MaterialSkin.Controls.MaterialLabel lblArbitros;
        private MaterialSkin.Controls.MaterialRaisedButton btn_EditArbitro;
        private MaterialSkin.Controls.MaterialFlatButton btn_ExcluirArbitro;
        private MaterialSkin.Controls.MaterialRaisedButton btn_AddArbitro;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialRaisedButton btn_FecharGerenciarTimes;
    }
}