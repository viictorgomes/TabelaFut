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

namespace TabelaFut
{
    public partial class frmEditTime : MaterialForm
    {
        private bool bEdit;

        public LayoutTimes _time;

        public frmEditTime(bool Edit, LayoutTimes Time)
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            this.StartPosition = FormStartPosition.CenterScreen;

            bEdit = Edit;

            if (!bEdit)
                _time = new LayoutTimes();
            else
            {
                if (Time == null)
                    throw new Exception("Falha na instância frmEditTime::_time");

                _time = Time;
                txtNome.Text = _time.Nome;
            }


            Refresh();
        }

        private void FrmEditTime_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text.Length == 0)
            {
                MessageBox.Show("Insira um nome válido!");
                return;
            }
            _time.Nome = txtNome.Text;

            if(bEdit)
            {
                var find = Manager.Instance.dBTimes.Times.Find(x => x.ID == _time.ID);
                find = _time;
            }
            else
            {
                _time.ID = ++Manager.Instance.dBTimes.UltimoID;
                Manager.Instance.dBTimes.Times.Add(_time);
            }


            DBManager.Serialize(Manager.Instance.dBTimes);
            this.Close();

        }


        void ListarJogadoresDisponiveis()
        {
            List<int> IdsDisponiveis;

            var allJogadores = Manager.Instance.dBJogadores.Jogadores;
            var allTimes = Manager.Instance.dBTimes.Times;

            var all = allJogadores.Select(x => x.ID).ToArray();
            IdsDisponiveis = new List<int>(all);


            foreach (var time in allTimes)
            {
                var jogadores = time.Jogadores.Where(x => IdsDisponiveis.Contains(x));

                if (jogadores.Count() > 0)
                {
                    foreach (var x in jogadores)
                    {
                        IdsDisponiveis.Remove(x);
                    }
                }
            }

            foreach(var jogador in _time.Jogadores)
            {
                IdsDisponiveis.Remove(jogador);
            }

            lbDisponiveis.DataSource = IdsDisponiveis;
            lblDisponiveis.Text = $"Jogadores Disponíveis ({IdsDisponiveis.Count})";
        }

        private void lb_Format(object sender, ListControlConvertEventArgs e)
        {
            int lbID = (int)e.ListItem;

            e.Value = Manager.Instance.dBJogadores.Jogadores[lbID - 1].Nome;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //lbDisponiveis.SelectedIndex

            if (lbDisponiveis.Items.Count == 0)
            {
                MessageBox.Show("Para adicionar, é necessário selecionar um jogador disponível.");
                return;
            }

            if (lbDisponiveis.SelectedIndex == -1)
            {
                MessageBox.Show("Para adicionar, é necessário selecionar um jogador disponível.");
                return;
            }

            if(_time.Jogadores.Count >= 24)
            {
                MessageBox.Show("Limite máximo de 24 jogadores por time.");
                return;
            }

            var selID = (int)lbDisponiveis.SelectedItem;
            _time.Jogadores.Add(selID);
            
            Refresh();

        }

        private void Refresh()
        {
            ListarJogadoresDisponiveis();
            var arr = _time.Jogadores.ToArray();
            lbJogadoresNoTime.DataSource = arr;
            lblJogadoresAtual.Text = $"Jogadores no Time ({arr.Count()})";
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (lbJogadoresNoTime.Items.Count == 0)
            {
                MessageBox.Show("Para remover, é necessário selecionar um jogador do time.");
                return;
            }

            if (lbJogadoresNoTime.SelectedIndex == -1)
            {
                MessageBox.Show("Para remover, é necessário selecionar um jogador do time.");
                return;
            }

            var selID = (int)lbJogadoresNoTime.SelectedItem;
            _time.Jogadores.Remove(selID);
            Refresh();

        }
    }
}
