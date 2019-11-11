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
    public partial class frmEditArbitro : MaterialForm
    {
        private bool bEdit;

        public LayoutArbitros _arbitro;

        public frmEditArbitro(bool Edit, LayoutArbitros Arbitro)
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            this.StartPosition = FormStartPosition.CenterScreen;

            bEdit = Edit;

            if (!bEdit)
            {
                this.Text = "Adicionar Árbitro";
                _arbitro = new LayoutArbitros();
            }
            else
            {
                this.Text = "Editar Árbitro";

                if (Arbitro == null)
                    throw new Exception("Falha na instância frmEditArbitro::_arbitro");

                _arbitro = Arbitro;
                txtNome.Text = _arbitro.Nome;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length == 0)
            {
                var msgBox = new CustomMsgBox("Nome Inválido", $"Insira um nome válido!", MessageBoxType.E_OK);
                var result = msgBox.ShowDialog();
                return;
            }

            _arbitro.Nome = txtNome.Text;

            if (bEdit)
            {
                var find = Manager.Instance.dBArbitros.Arbitros.Find(x => x.ID == _arbitro.ID);
                find = _arbitro;
            }
            else
            {
                _arbitro.ID = ++Manager.Instance.dBArbitros.UltimoID;
                Manager.Instance.dBArbitros.Arbitros.Add(_arbitro);
            }

            var infoMsgBox = new CustomMsgBox("Informações Atualizadas!", $"Informações de árbitros atualizadas com sucesso!", MessageBoxType.E_OK);
            var infoResult = infoMsgBox.ShowDialog();

            DBManager.Serialize(Manager.Instance.dBArbitros);
            this.Close();
        }

        private void btn_CancelarEditArbitro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
