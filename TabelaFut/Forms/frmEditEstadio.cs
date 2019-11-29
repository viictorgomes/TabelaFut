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
    public partial class frmEditEstadio : MaterialForm
    {
        private bool bEdit;

        public LayoutEstadios _estadio;

        //public LayoutTimes _time;

        public frmEditEstadio(bool Edit, LayoutEstadios Estadio)
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            this.StartPosition = FormStartPosition.CenterScreen;

            bEdit = Edit;

            if (!bEdit)
            {
                this.Text = "Adicionar Estádio";
                _estadio = new LayoutEstadios();
            }
            else
            {
                this.Text = "Editar Estádio";

                if (Estadio == null)
                    throw new Exception("Falha na instância frmEditEstadio::_estadio");

                _estadio = Estadio;
                txtNome.Text = _estadio.Nome;
            }

            Refresh();
        }

        private void Refresh()
        {
            ListarTimesDisponiveis();

            var arr = _estadio.IDTimes.ToArray();
            lbTimesLocais.DataSource = arr;
            lblTimesLocais.Text = $"Times Locais ({arr.Count()})";
        }

        void ListarTimesDisponiveis()
        {
            List<int> TimesDisponiveis;

            var allTimes = Manager.Instance.dBTimes.Times;
            var allEstadios = Manager.Instance.dBEstadios.Estadios;

            var all = allTimes.Select(x => x.ID).ToArray();
            TimesDisponiveis = new List<int>(all);

            foreach (var estadio in allEstadios)
            {
                var times = estadio.IDTimes.Where(x => TimesDisponiveis.Contains(x));

                if (times.Count() > 0)
                {
                    foreach (var x in times)
                    {
                        TimesDisponiveis.Remove(x);
                    }
                }
            }

            foreach (var time in _estadio.IDTimes)
            {
                TimesDisponiveis.Remove(time);
            }

            lbDisponiveis.DataSource = TimesDisponiveis;
            lblTimesDisponiveis.Text = $"Times Disponíveis ({TimesDisponiveis.Count})";
        }


        private void lbDisponiveis_Format(object sender, ListControlConvertEventArgs e)
        {
            int lbID = (int)e.ListItem;

            e.Value = Manager.Instance.dBTimes.Times.Find(x => x.ID == lbID).Nome;
        }

        private void lbTimesLocais_Format(object sender, ListControlConvertEventArgs e)
        {
            int lbID = (int)e.ListItem;

            e.Value = Manager.Instance.dBTimes.Times.Find(x => x.ID == lbID).Nome;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lbDisponiveis.Items.Count == 0)
            {
                var msgBox = new CustomMsgBox("Ops!", $"Para adicionar, é necessário selecionar um time disponível.", MessageBoxType.E_OK);
                var result = msgBox.ShowDialog();
                return;
            }

            if (lbDisponiveis.SelectedIndex == -1)
            {
                var msgBox = new CustomMsgBox("Ops!", $"Para adicionar, é necessário selecionar um time disponível.", MessageBoxType.E_OK);
                var result = msgBox.ShowDialog();
                return;
            }

            var selID = (int)lbDisponiveis.SelectedItem;
            _estadio.IDTimes.Add(selID);

            Refresh();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbTimesLocais.Items.Count == 0)
            {
                var msgBox = new CustomMsgBox("Ops!", $"Para remover, é necessário selecionar um time.", MessageBoxType.E_OK);
                var result = msgBox.ShowDialog();
                return;
            }

            if (lbTimesLocais.SelectedIndex == -1)
            {
                var msgBox = new CustomMsgBox("Ops!", $"Para remover, é necessário selecionar um time.", MessageBoxType.E_OK);
                var result = msgBox.ShowDialog();
                return;
            }

            var selID = (int)lbTimesLocais.SelectedItem;
            _estadio.IDTimes.Remove(selID);
            Refresh();
        }

        private void btn_CancelarEditEstadio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length == 0)
            {
                var msgBox = new CustomMsgBox("Nome Inválido", $"Insira um nome válido!", MessageBoxType.E_OK);
                var result = msgBox.ShowDialog();
                return;
            }
            _estadio.Nome = txtNome.Text;

            if (bEdit)
            {
                var find = Manager.Instance.dBEstadios.Estadios.Find(x => x.ID == _estadio.ID);
                find = _estadio;
            }
            else
            {
                _estadio.ID = ++Manager.Instance.dBEstadios.UltimoID;
                Manager.Instance.dBEstadios.Estadios.Add(_estadio);
            }

            var infoMsgBox = new CustomMsgBox("Informações Atualizadas!", $"Informações de estádios atualizadas com sucesso!", MessageBoxType.E_OK);
            var infoResult = infoMsgBox.ShowDialog();

            DBManager.Serialize(Manager.Instance.dBEstadios);
            this.Close();
        }
    }
}
