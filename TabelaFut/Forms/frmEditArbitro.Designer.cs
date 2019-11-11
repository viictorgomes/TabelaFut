namespace TabelaFut.Forms
{
    partial class frmEditArbitro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditArbitro));
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_CancelarEditArbitro = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 146);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(457, 1);
            this.materialDivider1.TabIndex = 14;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // txtNome
            // 
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "Nome";
            this.txtNome.Location = new System.Drawing.Point(12, 88);
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(422, 23);
            this.txtNome.TabIndex = 11;
            this.txtNome.TabStop = false;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Icon = null;
            this.btnSalvar.Location = new System.Drawing.Point(358, 156);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(72, 36);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btn_CancelarEditArbitro
            // 
            this.btn_CancelarEditArbitro.AutoSize = true;
            this.btn_CancelarEditArbitro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CancelarEditArbitro.Depth = 0;
            this.btn_CancelarEditArbitro.Icon = null;
            this.btn_CancelarEditArbitro.Location = new System.Drawing.Point(260, 156);
            this.btn_CancelarEditArbitro.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_CancelarEditArbitro.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_CancelarEditArbitro.Name = "btn_CancelarEditArbitro";
            this.btn_CancelarEditArbitro.Primary = false;
            this.btn_CancelarEditArbitro.Size = new System.Drawing.Size(91, 36);
            this.btn_CancelarEditArbitro.TabIndex = 15;
            this.btn_CancelarEditArbitro.Text = "Cancelar";
            this.btn_CancelarEditArbitro.UseVisualStyleBackColor = true;
            this.btn_CancelarEditArbitro.Click += new System.EventHandler(this.btn_CancelarEditArbitro_Click);
            // 
            // frmEditArbitro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 203);
            this.Controls.Add(this.btn_CancelarEditArbitro);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEditArbitro";
            this.Text = "Gerenciar Árbitro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
        private MaterialSkin.Controls.MaterialFlatButton btn_CancelarEditArbitro;
    }
}