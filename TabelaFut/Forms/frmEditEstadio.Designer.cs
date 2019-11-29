namespace TabelaFut.Forms
{
    partial class frmEditEstadio
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
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTimesLocais = new MaterialSkin.Controls.MaterialLabel();
            this.lblTimesDisponiveis = new MaterialSkin.Controls.MaterialLabel();
            this.btnRemove = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbTimesLocais = new System.Windows.Forms.ListBox();
            this.lbDisponiveis = new System.Windows.Forms.ListBox();
            this.btn_CancelarEditEstadio = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "Nome";
            this.txtNome.Location = new System.Drawing.Point(12, 82);
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(422, 23);
            this.txtNome.TabIndex = 4;
            this.txtNome.TabStop = false;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // lblTimesLocais
            // 
            this.lblTimesLocais.AutoSize = true;
            this.lblTimesLocais.Depth = 0;
            this.lblTimesLocais.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTimesLocais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTimesLocais.Location = new System.Drawing.Point(240, 124);
            this.lblTimesLocais.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTimesLocais.Name = "lblTimesLocais";
            this.lblTimesLocais.Size = new System.Drawing.Size(122, 19);
            this.lblTimesLocais.TabIndex = 13;
            this.lblTimesLocais.Text = "Times Locais (0)";
            // 
            // lblTimesDisponiveis
            // 
            this.lblTimesDisponiveis.AutoSize = true;
            this.lblTimesDisponiveis.Depth = 0;
            this.lblTimesDisponiveis.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTimesDisponiveis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTimesDisponiveis.Location = new System.Drawing.Point(8, 124);
            this.lblTimesDisponiveis.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTimesDisponiveis.Name = "lblTimesDisponiveis";
            this.lblTimesDisponiveis.Size = new System.Drawing.Size(155, 19);
            this.lblTimesDisponiveis.TabIndex = 12;
            this.lblTimesDisponiveis.Text = "Times Disponíveis (0)";
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.Depth = 0;
            this.btnRemove.Icon = null;
            this.btnRemove.Location = new System.Drawing.Point(209, 246);
            this.btnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Primary = true;
            this.btnRemove.Size = new System.Drawing.Size(28, 36);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Depth = 0;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(209, 204);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(28, 36);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbTimesLocais
            // 
            this.lbTimesLocais.FormattingEnabled = true;
            this.lbTimesLocais.Location = new System.Drawing.Point(244, 146);
            this.lbTimesLocais.Name = "lbTimesLocais";
            this.lbTimesLocais.Size = new System.Drawing.Size(191, 199);
            this.lbTimesLocais.TabIndex = 8;
            this.lbTimesLocais.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lbTimesLocais_Format);
            // 
            // lbDisponiveis
            // 
            this.lbDisponiveis.FormattingEnabled = true;
            this.lbDisponiveis.Location = new System.Drawing.Point(12, 146);
            this.lbDisponiveis.Name = "lbDisponiveis";
            this.lbDisponiveis.Size = new System.Drawing.Size(191, 199);
            this.lbDisponiveis.TabIndex = 9;
            this.lbDisponiveis.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lbDisponiveis_Format);
            // 
            // btn_CancelarEditEstadio
            // 
            this.btn_CancelarEditEstadio.AutoSize = true;
            this.btn_CancelarEditEstadio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CancelarEditEstadio.Depth = 0;
            this.btn_CancelarEditEstadio.Icon = null;
            this.btn_CancelarEditEstadio.Location = new System.Drawing.Point(269, 405);
            this.btn_CancelarEditEstadio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_CancelarEditEstadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_CancelarEditEstadio.Name = "btn_CancelarEditEstadio";
            this.btn_CancelarEditEstadio.Primary = false;
            this.btn_CancelarEditEstadio.Size = new System.Drawing.Size(91, 36);
            this.btn_CancelarEditEstadio.TabIndex = 16;
            this.btn_CancelarEditEstadio.Text = "Cancelar";
            this.btn_CancelarEditEstadio.UseVisualStyleBackColor = true;
            this.btn_CancelarEditEstadio.Click += new System.EventHandler(this.btn_CancelarEditEstadio_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-3, 395);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(457, 1);
            this.materialDivider1.TabIndex = 15;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Icon = null;
            this.btnSalvar.Location = new System.Drawing.Point(367, 405);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(72, 36);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmEditEstadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.btn_CancelarEditEstadio);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblTimesLocais);
            this.Controls.Add(this.lblTimesDisponiveis);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbTimesLocais);
            this.Controls.Add(this.lbDisponiveis);
            this.Controls.Add(this.txtNome);
            this.MaximizeBox = false;
            this.Name = "frmEditEstadio";
            this.Text = "Editar Estádio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private MaterialSkin.Controls.MaterialLabel lblTimesLocais;
        private MaterialSkin.Controls.MaterialLabel lblTimesDisponiveis;
        private MaterialSkin.Controls.MaterialRaisedButton btnRemove;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private System.Windows.Forms.ListBox lbTimesLocais;
        private System.Windows.Forms.ListBox lbDisponiveis;
        private MaterialSkin.Controls.MaterialFlatButton btn_CancelarEditEstadio;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
    }
}