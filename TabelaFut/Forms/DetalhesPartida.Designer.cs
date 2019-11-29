namespace TabelaFut.Forms
{
    partial class DetalhesPartida
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
            this.GolsTimeB = new MaterialSkin.Controls.MaterialLabel();
            this.GolsTimeA = new MaterialSkin.Controls.MaterialLabel();
            this.TimeB = new MaterialSkin.Controls.MaterialLabel();
            this.TimeA = new MaterialSkin.Controls.MaterialLabel();
            this.lbArbitros = new System.Windows.Forms.ListBox();
            this.lblEstadio = new MaterialSkin.Controls.MaterialLabel();
            this.lblArbitros = new MaterialSkin.Controls.MaterialLabel();
            this.btn_FecharDetalhesPartida = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.lblPartidaID = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // GolsTimeB
            // 
            this.GolsTimeB.AutoSize = true;
            this.GolsTimeB.Depth = 0;
            this.GolsTimeB.Font = new System.Drawing.Font("Roboto", 11F);
            this.GolsTimeB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GolsTimeB.Location = new System.Drawing.Point(235, 143);
            this.GolsTimeB.MouseState = MaterialSkin.MouseState.HOVER;
            this.GolsTimeB.Name = "GolsTimeB";
            this.GolsTimeB.Size = new System.Drawing.Size(17, 19);
            this.GolsTimeB.TabIndex = 7;
            this.GolsTimeB.Text = "0";
            // 
            // GolsTimeA
            // 
            this.GolsTimeA.AutoSize = true;
            this.GolsTimeA.Depth = 0;
            this.GolsTimeA.Font = new System.Drawing.Font("Roboto", 11F);
            this.GolsTimeA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GolsTimeA.Location = new System.Drawing.Point(235, 116);
            this.GolsTimeA.MouseState = MaterialSkin.MouseState.HOVER;
            this.GolsTimeA.Name = "GolsTimeA";
            this.GolsTimeA.Size = new System.Drawing.Size(17, 19);
            this.GolsTimeA.TabIndex = 6;
            this.GolsTimeA.Text = "0";
            // 
            // TimeB
            // 
            this.TimeB.AutoSize = true;
            this.TimeB.Depth = 0;
            this.TimeB.Font = new System.Drawing.Font("Roboto", 11F);
            this.TimeB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TimeB.Location = new System.Drawing.Point(12, 143);
            this.TimeB.MouseState = MaterialSkin.MouseState.HOVER;
            this.TimeB.Name = "TimeB";
            this.TimeB.Size = new System.Drawing.Size(56, 19);
            this.TimeB.TabIndex = 5;
            this.TimeB.Text = "Time B";
            // 
            // TimeA
            // 
            this.TimeA.AutoSize = true;
            this.TimeA.Depth = 0;
            this.TimeA.Font = new System.Drawing.Font("Roboto", 11F);
            this.TimeA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TimeA.Location = new System.Drawing.Point(12, 116);
            this.TimeA.MouseState = MaterialSkin.MouseState.HOVER;
            this.TimeA.Name = "TimeA";
            this.TimeA.Size = new System.Drawing.Size(57, 19);
            this.TimeA.TabIndex = 4;
            this.TimeA.Text = "Time A";
            // 
            // lbArbitros
            // 
            this.lbArbitros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbArbitros.FormattingEnabled = true;
            this.lbArbitros.Location = new System.Drawing.Point(16, 263);
            this.lbArbitros.Name = "lbArbitros";
            this.lbArbitros.Size = new System.Drawing.Size(236, 67);
            this.lbArbitros.TabIndex = 17;
            this.lbArbitros.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lbArbitros_Format);
            // 
            // lblEstadio
            // 
            this.lblEstadio.AutoSize = true;
            this.lblEstadio.Depth = 0;
            this.lblEstadio.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadio.Location = new System.Drawing.Point(12, 190);
            this.lblEstadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadio.Name = "lblEstadio";
            this.lblEstadio.Size = new System.Drawing.Size(86, 19);
            this.lblEstadio.TabIndex = 18;
            this.lblEstadio.Text = "Estádio: (0)";
            // 
            // lblArbitros
            // 
            this.lblArbitros.AutoSize = true;
            this.lblArbitros.Depth = 0;
            this.lblArbitros.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblArbitros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblArbitros.Location = new System.Drawing.Point(12, 241);
            this.lblArbitros.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblArbitros.Name = "lblArbitros";
            this.lblArbitros.Size = new System.Drawing.Size(63, 19);
            this.lblArbitros.TabIndex = 19;
            this.lblArbitros.Text = "Árbitros";
            // 
            // btn_FecharDetalhesPartida
            // 
            this.btn_FecharDetalhesPartida.AutoSize = true;
            this.btn_FecharDetalhesPartida.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_FecharDetalhesPartida.Depth = 0;
            this.btn_FecharDetalhesPartida.Icon = null;
            this.btn_FecharDetalhesPartida.Location = new System.Drawing.Point(182, 360);
            this.btn_FecharDetalhesPartida.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_FecharDetalhesPartida.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_FecharDetalhesPartida.Name = "btn_FecharDetalhesPartida";
            this.btn_FecharDetalhesPartida.Primary = false;
            this.btn_FecharDetalhesPartida.Size = new System.Drawing.Size(73, 36);
            this.btn_FecharDetalhesPartida.TabIndex = 21;
            this.btn_FecharDetalhesPartida.Text = "Fechar";
            this.btn_FecharDetalhesPartida.UseVisualStyleBackColor = true;
            this.btn_FecharDetalhesPartida.Click += new System.EventHandler(this.btn_FecharDetalhesPartida_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-2, 348);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(268, 1);
            this.materialDivider1.TabIndex = 20;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // lblPartidaID
            // 
            this.lblPartidaID.AutoSize = true;
            this.lblPartidaID.Depth = 0;
            this.lblPartidaID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPartidaID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPartidaID.Location = new System.Drawing.Point(12, 71);
            this.lblPartidaID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPartidaID.Name = "lblPartidaID";
            this.lblPartidaID.Size = new System.Drawing.Size(49, 19);
            this.lblPartidaID.TabIndex = 22;
            this.lblPartidaID.Text = "ID: (0)";
            // 
            // DetalhesPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 409);
            this.Controls.Add(this.lblPartidaID);
            this.Controls.Add(this.btn_FecharDetalhesPartida);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.lblArbitros);
            this.Controls.Add(this.lblEstadio);
            this.Controls.Add(this.lbArbitros);
            this.Controls.Add(this.GolsTimeB);
            this.Controls.Add(this.GolsTimeA);
            this.Controls.Add(this.TimeB);
            this.Controls.Add(this.TimeA);
            this.MaximizeBox = false;
            this.Name = "DetalhesPartida";
            this.Text = "Detalhes da Partida";
            this.Load += new System.EventHandler(this.DetalhesPartida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel GolsTimeB;
        private MaterialSkin.Controls.MaterialLabel GolsTimeA;
        private MaterialSkin.Controls.MaterialLabel TimeB;
        private MaterialSkin.Controls.MaterialLabel TimeA;
        private System.Windows.Forms.ListBox lbArbitros;
        private MaterialSkin.Controls.MaterialLabel lblEstadio;
        private MaterialSkin.Controls.MaterialLabel lblArbitros;
        private MaterialSkin.Controls.MaterialFlatButton btn_FecharDetalhesPartida;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel lblPartidaID;
    }
}