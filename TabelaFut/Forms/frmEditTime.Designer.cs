namespace TabelaFut
{
    partial class frmEditTime
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
            this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbDisponiveis = new System.Windows.Forms.ListBox();
            this.lbJogadoresNoTime = new System.Windows.Forms.ListBox();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRemove = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblDisponiveis = new MaterialSkin.Controls.MaterialLabel();
            this.lblJogadoresAtual = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btn_CancelarEditTime = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Icon = null;
            this.btnSalvar.Location = new System.Drawing.Point(361, 392);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(72, 36);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "Nome";
            this.txtNome.Location = new System.Drawing.Point(12, 85);
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(422, 23);
            this.txtNome.TabIndex = 3;
            this.txtNome.TabStop = false;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // lbDisponiveis
            // 
            this.lbDisponiveis.FormattingEnabled = true;
            this.lbDisponiveis.Location = new System.Drawing.Point(11, 150);
            this.lbDisponiveis.Name = "lbDisponiveis";
            this.lbDisponiveis.Size = new System.Drawing.Size(191, 199);
            this.lbDisponiveis.TabIndex = 4;
            this.lbDisponiveis.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lb_Format);
            // 
            // lbJogadoresNoTime
            // 
            this.lbJogadoresNoTime.FormattingEnabled = true;
            this.lbJogadoresNoTime.Location = new System.Drawing.Point(243, 150);
            this.lbJogadoresNoTime.Name = "lbJogadoresNoTime";
            this.lbJogadoresNoTime.Size = new System.Drawing.Size(191, 199);
            this.lbJogadoresNoTime.TabIndex = 4;
            this.lbJogadoresNoTime.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lb_Format);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Depth = 0;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(208, 208);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(28, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.Depth = 0;
            this.btnRemove.Icon = null;
            this.btnRemove.Location = new System.Drawing.Point(208, 250);
            this.btnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Primary = true;
            this.btnRemove.Size = new System.Drawing.Size(28, 36);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // lblDisponiveis
            // 
            this.lblDisponiveis.AutoSize = true;
            this.lblDisponiveis.Depth = 0;
            this.lblDisponiveis.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDisponiveis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDisponiveis.Location = new System.Drawing.Point(7, 128);
            this.lblDisponiveis.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDisponiveis.Name = "lblDisponiveis";
            this.lblDisponiveis.Size = new System.Drawing.Size(184, 19);
            this.lblDisponiveis.TabIndex = 6;
            this.lblDisponiveis.Text = "Jogadores Disponíveis (0)";
            // 
            // lblJogadoresAtual
            // 
            this.lblJogadoresAtual.AutoSize = true;
            this.lblJogadoresAtual.Depth = 0;
            this.lblJogadoresAtual.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblJogadoresAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblJogadoresAtual.Location = new System.Drawing.Point(239, 128);
            this.lblJogadoresAtual.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblJogadoresAtual.Name = "lblJogadoresAtual";
            this.lblJogadoresAtual.Size = new System.Drawing.Size(161, 19);
            this.lblJogadoresAtual.TabIndex = 7;
            this.lblJogadoresAtual.Text = "Jogadores no Time (0)";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(373, 352);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(61, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Max: 24";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(1, 382);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(457, 1);
            this.materialDivider1.TabIndex = 9;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // btn_CancelarEditTime
            // 
            this.btn_CancelarEditTime.AutoSize = true;
            this.btn_CancelarEditTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CancelarEditTime.Depth = 0;
            this.btn_CancelarEditTime.Icon = null;
            this.btn_CancelarEditTime.Location = new System.Drawing.Point(263, 392);
            this.btn_CancelarEditTime.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_CancelarEditTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_CancelarEditTime.Name = "btn_CancelarEditTime";
            this.btn_CancelarEditTime.Primary = false;
            this.btn_CancelarEditTime.Size = new System.Drawing.Size(91, 36);
            this.btn_CancelarEditTime.TabIndex = 10;
            this.btn_CancelarEditTime.Text = "Cancelar";
            this.btn_CancelarEditTime.UseVisualStyleBackColor = true;
            this.btn_CancelarEditTime.Click += new System.EventHandler(this.btn_CancelarEditTime_Click);
            // 
            // frmEditTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 438);
            this.Controls.Add(this.btn_CancelarEditTime);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.lblJogadoresAtual);
            this.Controls.Add(this.lblDisponiveis);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbJogadoresNoTime);
            this.Controls.Add(this.lbDisponiveis);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSalvar);
            this.MaximizeBox = false;
            this.Name = "frmEditTime";
            this.Text = "Gerenciar Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private System.Windows.Forms.ListBox lbDisponiveis;
        private System.Windows.Forms.ListBox lbJogadoresNoTime;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private MaterialSkin.Controls.MaterialRaisedButton btnRemove;
        private MaterialSkin.Controls.MaterialLabel lblDisponiveis;
        private MaterialSkin.Controls.MaterialLabel lblJogadoresAtual;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialFlatButton btn_CancelarEditTime;
    }
}