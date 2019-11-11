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
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using TabelaFut.Forms;

namespace TabelaFut
{
    public partial class frmGerenciarTimes : MaterialForm
    {

        public LayoutTimes _time;

        public frmGerenciarTimes()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            this.StartPosition = FormStartPosition.CenterScreen;

            Refresh();

        }

        private void LbTimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lb = (ListBox)sender;

            var sel = (int)lb.SelectedItem;

            var arr = Manager.Instance.dBTimes.Times.Find(x => x.ID == sel).Jogadores.ToArray();
            lbAtletas.DataSource = arr;

            lblJogadoresNoTime.Text = $"Jogadores do Time ({arr.Count()})";

        }

        private void LbAtletas_Format(object sender, ListControlConvertEventArgs e)
        {
            int lbID = (int)e.ListItem;

            e.Value = Manager.Instance.dBJogadores.Jogadores.Find(x => x.ID == lbID).Nome;
        }

        private void FrmGerenciarTimes_FormClosing(object sender, FormClosingEventArgs e)
        {
           // DBManager.Serialize(Manager.Instance.dBTimes);
        }

        private void Btn_AddTime_Click(object sender, EventArgs e)
        {
            var frm = new frmEditTime(false, null);
            frm.ShowDialog();

            Refresh();
        }

        private void Btn_EditTime_Click(object sender, EventArgs e)
        {
            if(lbTimes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um time para editar.");
                return;
            }

            int id = (int)lbTimes.SelectedItem;

            var frm = new frmEditTime(true, Manager.Instance.dBTimes.Times.Find(x => x.ID == id));

            frm.ShowDialog();

            Refresh();

            int newID = (int)lbTimes.SelectedItem;

            lbAtletas.DataSource = Manager.Instance.dBTimes.Times.Find(x => x.ID == newID).Jogadores.ToArray();
        }

        private void LbTimes_Format(object sender, ListControlConvertEventArgs e)
        {
            int lbID = (int)e.ListItem;

            e.Value = Manager.Instance.dBTimes.Times.Find(x => x.ID == lbID).Nome;
        }


        private void Refresh()
        {
            var arr = Manager.Instance.dBTimes.Times.Select(x => x.ID).ToArray();
            lbTimes.DataSource = arr;
            lblTimes.Text = $"Times ({arr.Count()})";
        }

        private void btn_FecharGerenciarTimes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ExcluirTime_Click(object sender, EventArgs e)
        {
            if (lbTimes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um time para remover.");
                return;
            }

            int id = (int)lbTimes.SelectedItem;
            var remover = Manager.Instance.dBTimes.Times.Find(x => x.ID == id);

            var msgBox = new CustomMsgBox("Remover Time", $"Tem certeza de que deseja remover {remover.Nome}?", MessageBoxType.E_CancelarConfirmar);
            var result = msgBox.ShowDialog();

            if (result == DialogResult.OK)
            {
                Manager.Instance.dBTimes.Times.Remove(remover);
                DBManager.Serialize(Manager.Instance.dBTimes);
            }

            Refresh();
        }
    }
}
