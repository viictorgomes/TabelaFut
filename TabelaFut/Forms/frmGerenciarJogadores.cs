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
    public partial class frmGerenciarJogadores : MaterialForm
    {
        public LayoutJogadores _jogador;

        public frmGerenciarJogadores()
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
            var arr = Manager.Instance.dBJogadores.Jogadores.Select(x => x.ID).ToArray();
            lbJogadores.DataSource = arr;
            lblJogadores.Text = $"Jogadores ({arr.Count()})";
        }

        private void btn_FecharGerenciarTimes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddJogador_Click(object sender, EventArgs e)
        {
            var frm = new frmEditJogador(false, null);
            frm.ShowDialog();

            Refresh();
        }

        private void btn_EditJogador_Click(object sender, EventArgs e)
        {
            if (lbJogadores.SelectedIndex == -1)
            {
                var msgBox = new CustomMsgBox("Ops!", $"Selecione um jogador para editar.", MessageBoxType.E_OK);
                var result = msgBox.ShowDialog();
                return;
            }

            int id = (int)lbJogadores.SelectedItem;

            var frm = new frmEditJogador(true, Manager.Instance.dBJogadores.Jogadores.Find(x => x.ID == id));

            frm.ShowDialog();

            Refresh();
        }

        private void btn_ExcluirJogador_Click(object sender, EventArgs e)
        {
            if (lbJogadores.SelectedIndex == -1)
            {
                var errorMsgBox = new CustomMsgBox("Ops!", $"Selecione um jogador para remover.", MessageBoxType.E_OK);
                var errorResult = errorMsgBox.ShowDialog();
                return;
            }

            int id = (int)lbJogadores.SelectedItem;
            var remover = Manager.Instance.dBJogadores.Jogadores.Find(x => x.ID == id);

            var msgBox = new CustomMsgBox("Remover Jogador", $"Tem certeza de que deseja remover o jogador {remover.Nome}?", MessageBoxType.E_CancelarConfirmar);
            var result = msgBox.ShowDialog();

            if (result == DialogResult.OK)
            {
                Manager.Instance.dBJogadores.Jogadores.Remove(remover);
                Manager.Instance.dBTimes.Times.Find(x => x.ID == id).Jogadores.Remove(id);

                DBManager.Serialize(Manager.Instance.dBJogadores);
                DBManager.Serialize(Manager.Instance.dBTimes);

                var infoMsgBox = new CustomMsgBox("Informações Atualizadas!", $"Jogador {remover.Nome} removido com sucesso.", MessageBoxType.E_CancelarConfirmar);
                var infoResult = infoMsgBox.ShowDialog();
            }

            Refresh();
        }

        private void lbJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lb = (ListBox)sender;
            var sel = (int)lb.SelectedItem;

            var jogador = Manager.Instance.dBJogadores.Jogadores.Find(x => x.ID == sel);

            lbl_Nome.Text = jogador.Nome;
            lbl_ID.Text = $"ID: {jogador.ID.ToString()}";
            lbl_Idade.Text = $"Idade: {jogador.Idade.ToString()}";
            lbl_Altura.Text = $"Altura: {jogador.Altura.ToString()}";
            lbl_Gols.Text = $"Gols: {jogador.Gols.ToString()}";
            lbl_TimeAtual.Text = $"Time Atual: {EncontrarTime(jogador.ID)}";
        }

        private string EncontrarTime(int idJogador)
        {
            LayoutTimes _timeAtual = null;

            var allJogadores = Manager.Instance.dBJogadores.Jogadores;
            var allTimes = Manager.Instance.dBTimes.Times;

            foreach (var time in allTimes)
            {
                if (time.Jogadores.Contains(idJogador))
                {
                    _timeAtual = time;
                }
            }

            if (_timeAtual != null)
                return _timeAtual.Nome;
            else
                return "Sem Time";
        }

        private void lbJogadores_Format(object sender, ListControlConvertEventArgs e)
        {
            int lbID = (int)e.ListItem;

            var nome = Manager.Instance.dBJogadores.Jogadores.Find(x => x.ID == lbID).Nome;
            var time = EncontrarTime(Manager.Instance.dBJogadores.Jogadores.Find(x => x.ID == lbID).ID);
            e.Value = $"({time}) - {nome}";
        }
    }
}
