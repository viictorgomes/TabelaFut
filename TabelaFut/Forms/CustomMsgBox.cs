using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabelaFut.Forms
{
    public enum MessageBoxType
    {
        E_CancelarConfirmar,
        E_OK
    }

    public partial class CustomMsgBox : MaterialForm
    {
        private MessageBoxType type;
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        public CustomMsgBox(string titulo, string mensagem, MessageBoxType type)
        {
            this.type = type;
            InitializeComponent();

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Text = titulo;
            this.lbl_Mensagem.Text = mensagem;

            if (type == MessageBoxType.E_OK)
            {
                btn_cancel.Hide();
            }
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_OK_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
