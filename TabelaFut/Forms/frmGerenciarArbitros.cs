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
    public partial class frmGerenciarArbitros : MaterialForm
    {
        public frmGerenciarArbitros()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            this.StartPosition = FormStartPosition.CenterScreen;

            Refresh();
        }

        private void lbArbitros_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lb = (ListBox)sender;
            var sel = (int)lb.SelectedItem;
        }

        private void lbArbitros_Format(object sender, ListControlConvertEventArgs e)
        {
            int lbID = (int)e.ListItem;

            e.Value = Manager.Instance.dBArbitros.Arbitros.Find(x => x.ID == lbID).Nome;
        }

        private void Refresh()
        {
            var arr = Manager.Instance.dBArbitros.Arbitros.Select(x => x.ID).ToArray();
            lbArbitros.DataSource = arr;
            lblArbitros.Text = $"Árbitros ({arr.Count()})";
        }

        private void btn_FecharGerenciarTimes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddArbitro_Click(object sender, EventArgs e)
        {
            var frm = new frmEditArbitro(false, null);
            frm.ShowDialog();

            Refresh();
        }

        private void btn_EditArbitro_Click(object sender, EventArgs e)
        {
            if (lbArbitros.SelectedIndex == -1)
            {
                var msgBox = new CustomMsgBox("Ops!", $"Selecione um árbitro para editar.", MessageBoxType.E_OK);
                var result = msgBox.ShowDialog();
                return;
            }

            int id = (int)lbArbitros.SelectedItem;

            var frm = new frmEditArbitro(true, Manager.Instance.dBArbitros.Arbitros.Find(x => x.ID == id));

            frm.ShowDialog();

            Refresh();
        }

        private void btn_ExcluirArbitro_Click(object sender, EventArgs e)
        {
            if (lbArbitros.SelectedIndex == -1)
            {
                var errorMsgBox = new CustomMsgBox("Ops!", $"Selecione um árbitro para remover.", MessageBoxType.E_OK);
                var errorResult = errorMsgBox.ShowDialog();
                return;
            }

            int id = (int)lbArbitros.SelectedItem;
            var remover = Manager.Instance.dBArbitros.Arbitros.Find(x => x.ID == id);

            var msgBox = new CustomMsgBox("Remover Árbitro", $"Tem certeza de que deseja remover o árbitro {remover.Nome}?", MessageBoxType.E_CancelarConfirmar);
            var result = msgBox.ShowDialog();

            if (result == DialogResult.OK)
            {
                Manager.Instance.dBArbitros.Arbitros.Remove(remover);
                DBManager.Serialize(Manager.Instance.dBArbitros);

                var infoMsgBox = new CustomMsgBox("Informações Atualizadas!", $"Árbitro {remover.Nome} removido com sucesso.", MessageBoxType.E_CancelarConfirmar);
                var infoResult = infoMsgBox.ShowDialog();
            }

            Refresh();
        }
    }
}
