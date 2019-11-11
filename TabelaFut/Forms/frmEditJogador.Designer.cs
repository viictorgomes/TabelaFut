namespace TabelaFut.Forms
{
    partial class frmEditJogador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditJogador));
            this.btn_CancelarEditArbitro = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txtIdade = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAltura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // btn_CancelarEditArbitro
            // 
            this.btn_CancelarEditArbitro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CancelarEditArbitro.AutoSize = true;
            this.btn_CancelarEditArbitro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CancelarEditArbitro.Depth = 0;
            this.btn_CancelarEditArbitro.Icon = null;
            this.btn_CancelarEditArbitro.Location = new System.Drawing.Point(266, 288);
            this.btn_CancelarEditArbitro.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_CancelarEditArbitro.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_CancelarEditArbitro.Name = "btn_CancelarEditArbitro";
            this.btn_CancelarEditArbitro.Primary = false;
            this.btn_CancelarEditArbitro.Size = new System.Drawing.Size(91, 36);
            this.btn_CancelarEditArbitro.TabIndex = 18;
            this.btn_CancelarEditArbitro.Text = "Cancelar";
            this.btn_CancelarEditArbitro.UseVisualStyleBackColor = true;
            this.btn_CancelarEditArbitro.Click += new System.EventHandler(this.btn_CancelarEditArbitro_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Icon = null;
            this.btnSalvar.Location = new System.Drawing.Point(364, 288);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(72, 36);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "Nome";
            this.txtNome.Location = new System.Drawing.Point(12, 114);
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(422, 23);
            this.txtNome.TabIndex = 19;
            this.txtNome.TabStop = false;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 83);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 20;
            this.materialLabel1.Text = "ID: (0)";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-4, 277);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(457, 1);
            this.materialDivider1.TabIndex = 21;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // txtIdade
            // 
            this.txtIdade.Depth = 0;
            this.txtIdade.Hint = "Idade";
            this.txtIdade.Location = new System.Drawing.Point(12, 153);
            this.txtIdade.MaxLength = 32767;
            this.txtIdade.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.PasswordChar = '\0';
            this.txtIdade.SelectedText = "";
            this.txtIdade.SelectionLength = 0;
            this.txtIdade.SelectionStart = 0;
            this.txtIdade.Size = new System.Drawing.Size(422, 23);
            this.txtIdade.TabIndex = 22;
            this.txtIdade.TabStop = false;
            this.txtIdade.UseSystemPasswordChar = false;
            // 
            // txtAltura
            // 
            this.txtAltura.Depth = 0;
            this.txtAltura.Hint = "Altura";
            this.txtAltura.Location = new System.Drawing.Point(12, 192);
            this.txtAltura.MaxLength = 32767;
            this.txtAltura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.PasswordChar = '\0';
            this.txtAltura.SelectedText = "";
            this.txtAltura.SelectionLength = 0;
            this.txtAltura.SelectionStart = 0;
            this.txtAltura.Size = new System.Drawing.Size(422, 23);
            this.txtAltura.TabIndex = 23;
            this.txtAltura.TabStop = false;
            this.txtAltura.UseSystemPasswordChar = false;
            // 
            // frmEditJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 336);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btn_CancelarEditArbitro);
            this.Controls.Add(this.btnSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEditJogador";
            this.Text = "Gerenciar Jogador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btn_CancelarEditArbitro;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdade;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAltura;
    }
}