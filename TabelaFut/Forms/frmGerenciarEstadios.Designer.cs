namespace TabelaFut.Forms
{
    partial class frmGerenciarEstadios
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
            this.btn_FecharGerenciarEstadios = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.btn_EditEstadio = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_ExcluirEstadio = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_AddEstadio = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblEstadios = new MaterialSkin.Controls.MaterialLabel();
            this.lbEstadios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_FecharGerenciarEstadios
            // 
            this.btn_FecharGerenciarEstadios.AutoSize = true;
            this.btn_FecharGerenciarEstadios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_FecharGerenciarEstadios.Depth = 0;
            this.btn_FecharGerenciarEstadios.Icon = null;
            this.btn_FecharGerenciarEstadios.Location = new System.Drawing.Point(229, 369);
            this.btn_FecharGerenciarEstadios.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_FecharGerenciarEstadios.Name = "btn_FecharGerenciarEstadios";
            this.btn_FecharGerenciarEstadios.Primary = true;
            this.btn_FecharGerenciarEstadios.Size = new System.Drawing.Size(73, 36);
            this.btn_FecharGerenciarEstadios.TabIndex = 25;
            this.btn_FecharGerenciarEstadios.Text = "Fechar";
            this.btn_FecharGerenciarEstadios.UseVisualStyleBackColor = true;
            this.btn_FecharGerenciarEstadios.Click += new System.EventHandler(this.btn_FecharGerenciarEstadios_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(0, 359);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(320, 1);
            this.materialDivider2.TabIndex = 24;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // btn_EditEstadio
            // 
            this.btn_EditEstadio.AutoSize = true;
            this.btn_EditEstadio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_EditEstadio.Depth = 0;
            this.btn_EditEstadio.Icon = null;
            this.btn_EditEstadio.Location = new System.Drawing.Point(121, 301);
            this.btn_EditEstadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_EditEstadio.Name = "btn_EditEstadio";
            this.btn_EditEstadio.Primary = true;
            this.btn_EditEstadio.Size = new System.Drawing.Size(82, 36);
            this.btn_EditEstadio.TabIndex = 23;
            this.btn_EditEstadio.Text = "⚙ Editar";
            this.btn_EditEstadio.UseVisualStyleBackColor = true;
            this.btn_EditEstadio.Click += new System.EventHandler(this.btn_EditEstadio_Click);
            // 
            // btn_ExcluirEstadio
            // 
            this.btn_ExcluirEstadio.AutoSize = true;
            this.btn_ExcluirEstadio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ExcluirEstadio.Depth = 0;
            this.btn_ExcluirEstadio.Icon = null;
            this.btn_ExcluirEstadio.Location = new System.Drawing.Point(208, 301);
            this.btn_ExcluirEstadio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ExcluirEstadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ExcluirEstadio.Name = "btn_ExcluirEstadio";
            this.btn_ExcluirEstadio.Primary = false;
            this.btn_ExcluirEstadio.Size = new System.Drawing.Size(92, 36);
            this.btn_ExcluirEstadio.TabIndex = 22;
            this.btn_ExcluirEstadio.Text = "- Remover";
            this.btn_ExcluirEstadio.UseVisualStyleBackColor = true;
            this.btn_ExcluirEstadio.Click += new System.EventHandler(this.btn_ExcluirEstadio_Click);
            // 
            // btn_AddEstadio
            // 
            this.btn_AddEstadio.AutoSize = true;
            this.btn_AddEstadio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_AddEstadio.Depth = 0;
            this.btn_AddEstadio.Icon = null;
            this.btn_AddEstadio.Location = new System.Drawing.Point(12, 301);
            this.btn_AddEstadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_AddEstadio.Name = "btn_AddEstadio";
            this.btn_AddEstadio.Primary = true;
            this.btn_AddEstadio.Size = new System.Drawing.Size(104, 36);
            this.btn_AddEstadio.TabIndex = 21;
            this.btn_AddEstadio.Text = "+ Adicionar";
            this.btn_AddEstadio.UseVisualStyleBackColor = true;
            this.btn_AddEstadio.Click += new System.EventHandler(this.btn_AddEstadio_Click);
            // 
            // lblEstadios
            // 
            this.lblEstadios.AutoSize = true;
            this.lblEstadios.Depth = 0;
            this.lblEstadios.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadios.Location = new System.Drawing.Point(12, 71);
            this.lblEstadios.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadios.Name = "lblEstadios";
            this.lblEstadios.Size = new System.Drawing.Size(90, 19);
            this.lblEstadios.TabIndex = 20;
            this.lblEstadios.Text = "Estádios (0)";
            // 
            // lbEstadios
            // 
            this.lbEstadios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEstadios.FormattingEnabled = true;
            this.lbEstadios.Location = new System.Drawing.Point(12, 95);
            this.lbEstadios.Name = "lbEstadios";
            this.lbEstadios.Size = new System.Drawing.Size(288, 197);
            this.lbEstadios.TabIndex = 19;
            this.lbEstadios.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lbEstadios_Format);
            // 
            // frmGerenciarEstadios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 415);
            this.Controls.Add(this.btn_FecharGerenciarEstadios);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.btn_EditEstadio);
            this.Controls.Add(this.btn_ExcluirEstadio);
            this.Controls.Add(this.btn_AddEstadio);
            this.Controls.Add(this.lblEstadios);
            this.Controls.Add(this.lbEstadios);
            this.MaximizeBox = false;
            this.Name = "frmGerenciarEstadios";
            this.Text = "Gerenciar Estádios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btn_FecharGerenciarEstadios;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialRaisedButton btn_EditEstadio;
        private MaterialSkin.Controls.MaterialFlatButton btn_ExcluirEstadio;
        private MaterialSkin.Controls.MaterialRaisedButton btn_AddEstadio;
        private MaterialSkin.Controls.MaterialLabel lblEstadios;
        private System.Windows.Forms.ListBox lbEstadios;
    }
}