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
    public partial class frmGerenciarEstadios : MaterialForm
    {
        public frmGerenciarEstadios()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            this.StartPosition = FormStartPosition.CenterScreen;

            Refresh();
        }

        private void Refresh()
        {
            var arr = Manager.Instance.dBEstadios.Estadios.Select(x => x.ID).ToArray();
            lbEstadios.DataSource = arr;
            lblEstadios.Text = $"Estádios ({arr.Count()})";
        }

        private void btn_FecharGerenciarEstadios_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbEstadios_Format(object sender, ListControlConvertEventArgs e)
        {
            int lbID = (int)e.ListItem;

            e.Value = Manager.Instance.dBEstadios.Estadios.Find(x => x.ID == lbID).Nome;
        }

        private void btn_EditEstadio_Click(object sender, EventArgs e)
        {
            if (lbEstadios.SelectedIndex == -1)
            {
                var msgBox = new CustomMsgBox("Ops!", $"Selecione um estádio para editar.", MessageBoxType.E_OK);
                var result = msgBox.ShowDialog();
                return;
            }

            int id = (int)lbEstadios.SelectedItem;

            var frm = new frmEditEstadio(true, Manager.Instance.dBEstadios.Estadios.Find(x => x.ID == id));

            frm.ShowDialog();

            Refresh();
        }

        private void btn_AddEstadio_Click(object sender, EventArgs e)
        {
            var frm = new frmEditEstadio(false, null);
            frm.ShowDialog();

            Refresh();
        }

        private void btn_ExcluirEstadio_Click(object sender, EventArgs e)
        {
            if (lbEstadios.SelectedIndex == -1)
            {
                var errorMsgBox = new CustomMsgBox("Ops!", $"Selecione um jogador para remover.", MessageBoxType.E_OK);
                var errorResult = errorMsgBox.ShowDialog();
                return;
            }

            int id = (int)lbEstadios.SelectedItem;
            var remover = Manager.Instance.dBEstadios.Estadios.Find(x => x.ID == id);

            var msgBox = new CustomMsgBox("Remover Estádio", $"Tem certeza de que deseja remover o estádio {remover.Nome}?", MessageBoxType.E_CancelarConfirmar);
            var result = msgBox.ShowDialog();

            if (result == DialogResult.OK)
            {
                Manager.Instance.dBEstadios.Estadios.Remove(remover);
                DBManager.Serialize(Manager.Instance.dBEstadios);

                var infoMsgBox = new CustomMsgBox("Informações Atualizadas!", $"Estádio {remover.Nome} removido com sucesso.", MessageBoxType.E_CancelarConfirmar);
                var infoResult = infoMsgBox.ShowDialog();
            }

            Refresh();
        }
    }
}
