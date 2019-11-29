using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabelaFut.Forms;
using static System.Windows.Forms.ListViewItem;

namespace TabelaFut
{
    public partial class MainForm : MaterialForm
    {
        private int PaginaPartidas = 1;
        private int IdTime = 1;

        public class IntegerComparer : IComparer
        {
            private int _colIndex;
            public IntegerComparer(int colIndex)
            {
                _colIndex = colIndex;
            }
            public int Compare(object x, object y)
            {
                int nx = int.Parse((x as ListViewItem).SubItems[_colIndex].Text);
                int ny = int.Parse((y as ListViewItem).SubItems[_colIndex].Text);
                return ny.CompareTo(nx);
            }
        }

        public MainForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            this.StartPosition = FormStartPosition.CenterScreen;


            lvClassificacoes.ListViewItemSorter = new IntegerComparer(3);
            lvClassificacoes.Sort();
        }

        private void RefreshClassificacao()
        {
            lvClassificacoes.Items.Clear();

            foreach (var item in Manager.Instance.dBTimes.Times)
            {
                string[] arr = new string[10];
                arr[0] = "";
                arr[1] = "0";
                arr[2] = item.Nome;
                arr[3] = item.Pontos.ToString();
                arr[4] = item.Vitorias.ToString();
                arr[5] = item.Empates.ToString();
                arr[6] = item.Derrotas.ToString();
                arr[7] = item.GolsFeitos.ToString();
                arr[8] = item.GolsSofridos.ToString();
                arr[9] = item.SaldoDeGols.ToString();
                ListViewItem lvi = new ListViewItem(arr);
                lvClassificacoes.Items.Add(lvi);
            }

            lvClassificacoes.Sort();

            int index = 1;
            foreach (ListViewItem item in lvClassificacoes.Items)
            {
                item.SubItems[1].Text = index++.ToString();
                item.UseItemStyleForSubItems = false;

                if (index % 2 == 1)
                {
                    foreach (ListViewSubItem sub in item.SubItems)
                    {
                        sub.BackColor = Color.FromArgb(230, 230, 230);
                    }
                }

                if (index <= 5)
                {
                    item.SubItems[1].BackColor = Color.FromArgb(66, 133, 244);
                }
                else if (index <= 7)
                    item.SubItems[1].BackColor = Color.FromArgb(250, 123, 23);
                else if (index <= 13)
                    item.SubItems[1].BackColor = Color.FromArgb(52, 168, 83);
                else if (index > 17)
                    item.SubItems[1].BackColor = Color.FromArgb(234, 67, 53);
            }

        }

        private void RefreshPartidas(int Rodada)
        {
            int index = 0;

            var rodada = Manager.Instance.dBRodadas.Rodadas.Find(x => x.ID == Rodada);

            foreach (var partida in rodada.Partidas)
            {
                index = partida.ID;

                if (partida.ID > 10)
                {
                    index = partida.ID % 10;
                    if (index == 0)
                    {
                        index = 10;
                    }
                }

                var lblTimeA = Controls.Find($"TimeA_{index}", true).FirstOrDefault() as Label;
                var lblTimeB = Controls.Find($"TimeB_{index}", true).FirstOrDefault() as Label;
                var lblGolsTimeA = Controls.Find($"GolsTimeA_{index}", true).FirstOrDefault() as Label;
                var lblGolsTimeB = Controls.Find($"GolsTimeB_{index}", true).FirstOrDefault() as Label;
                var lblIDPartida = Controls.Find($"IDPartida_{index}", true).FirstOrDefault() as Label;

                lblTimeA.Text = partida.TimeA.Nome;
                lblTimeB.Text = partida.TimeB.Nome;
                lblGolsTimeA.Text = partida.GolsTimeA.ToString();
                lblGolsTimeB.Text = partida.GolsTimeB.ToString();
                lblIDPartida.Text = partida.ID.ToString();
                lblIDPartida.Hide();
            }

            lblRodada.Text = $"Rodada {Rodada} de 19";
            PaginaPartidas = Rodada;
        }

        private void RefreshPartidasPorTime(int Time, bool segundaPagina = false)
        {
            int index = segundaPagina ? 9 : 0;

            var time = Manager.Instance.dBTimes.Times.Find(x => x.ID == Time);
            var partidas = Manager.Instance.dBPartidas.Partidas.Where(x => x.TimeA.ID == time.ID || x.TimeB.ID == time.ID).ToList();

            List<LayoutPartidas> Partidas = new List<LayoutPartidas>();
            foreach (var partida in partidas)
            {
                Partidas.Add(partida);
            }


            foreach (var partida in Partidas)
            {
                index = ++index;

                if (index > 10)
                {
                    index = partida.ID % 10;
                    if (index == 0)
                    {
                        index = 10;
                    }
                }

                var lblTimeA = Controls.Find($"TimeA_{index}", true).FirstOrDefault() as Label;
                var lblTimeB = Controls.Find($"TimeB_{index}", true).FirstOrDefault() as Label;
                var lblGolsTimeA = Controls.Find($"GolsTimeA_{index}", true).FirstOrDefault() as Label;
                var lblGolsTimeB = Controls.Find($"GolsTimeB_{index}", true).FirstOrDefault() as Label;
                var lblIDPartida = Controls.Find($"IDPartida_{index}", true).FirstOrDefault() as Label;

                lblTimeA.Text = partida.TimeA.Nome;
                lblTimeB.Text = partida.TimeB.Nome;
                lblGolsTimeA.Text = partida.GolsTimeA.ToString();
                lblGolsTimeB.Text = partida.GolsTimeB.ToString();
                lblIDPartida.Text = partida.ID.ToString();
                lblIDPartida.Hide();
            }

            lblRodada.Text = $"Time: {time.Nome}";
            IdTime = time.ID;

            if (segundaPagina)
            {
                TimeA_10.Hide();
                TimeB_10.Hide();
                GolsTimeA_10.Hide();
                GolsTimeB_10.Hide();
                button15.Hide();
            }
            else
            {
                TimeA_10.Show();
                TimeB_10.Show();
                GolsTimeA_10.Show();
                GolsTimeB_10.Show();
                button15.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshClassificacao();
            RefreshPartidas(1);
            radioPorRodada.Checked = true;
        }

        private void LvClassificacoes_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lvClassificacoes.Columns[e.ColumnIndex].Width;
        }

        private void btnGerenciarTimes_Click(object sender, EventArgs e)
        {
            var frm = new frmGerenciarTimes();
            frm.ShowDialog();
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {
            RefreshClassificacao();
            RefreshPartidas(1);
        }

        private void btnGerenciarArbitros_Click(object sender, EventArgs e)
        {
            var frm = new frmGerenciarArbitros();
            frm.ShowDialog();
        }

        private void btnGerenciarJogadores_Click(object sender, EventArgs e)
        {
            var frm = new frmGerenciarJogadores();
            frm.ShowDialog();
        }

        private void btnGerenciarEstadios_Click(object sender, EventArgs e)
        {
            var frm = new frmGerenciarEstadios();
            frm.ShowDialog();
        }


        private static void TodasAsRodadasJaForamJogadas()
        {
            var msgBox = new CustomMsgBox("Alerta", $"Todas as rodadas já foram jogadas.", MessageBoxType.E_OK);
            var result = msgBox.ShowDialog();
        }

        private void AlterarPaginaPartida(int Pag)
        {
            RefreshPartidas(Pag);
        }

        private void DetalhesPartida(int Partida)
        {
            var partida = Manager.Instance.dBPartidas.Partidas.Find(x => x.ID == Partida);

            var frm = new DetalhesPartida(partida);
            frm.ShowDialog();
        }

        private void btn_ProxPag_Click(object sender, EventArgs e)
        {

            if (radioPorRodada.Checked)
            {
                if (PaginaPartidas < 19)
                    AlterarPaginaPartida(PaginaPartidas + 1);
            }
            else
            {
                RefreshPartidasPorTime(IdTime, true);
                //PaginaPartidas++;
            }

        }

        private void btn_PagAnterior_Click(object sender, EventArgs e)
        {
            if (radioPorRodada.Checked)
            {
                if (PaginaPartidas > 1)
                    AlterarPaginaPartida(PaginaPartidas - 1);
            }
            else
            {
                RefreshPartidasPorTime(IdTime, false);
                //PaginaPartidas--;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DetalhesPartida(Convert.ToInt32(IDPartida_1.Text) + ((PaginaPartidas - 1) * 10));
            DetalhesPartida(Convert.ToInt32(IDPartida_1.Text));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetalhesPartida(Convert.ToInt32(IDPartida_2.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetalhesPartida(Convert.ToInt32(IDPartida_3.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DetalhesPartida(Convert.ToInt32(IDPartida_4.Text));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DetalhesPartida(Convert.ToInt32(IDPartida_5.Text));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DetalhesPartida(Convert.ToInt32(IDPartida_6.Text));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DetalhesPartida(Convert.ToInt32(IDPartida_7.Text));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DetalhesPartida(Convert.ToInt32(IDPartida_8.Text));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DetalhesPartida(Convert.ToInt32(IDPartida_9.Text));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DetalhesPartida(Convert.ToInt32(IDPartida_10.Text));
        }

        private void radioPorRodada_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPorRodada.Checked)
            {
                RefreshPartidas(1);
                btnProxTime.Hide();
                btnTimeAnterior.Hide();
                PaginaPartidas = 1;

                TimeA_10.Show();
                TimeB_10.Show();
                GolsTimeA_10.Show();
                GolsTimeB_10.Show();
                button15.Show();

                lblRodada.Location = new Point(12, 472);
            }
        }

        private void radioPorTime_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPorTime.Checked)
            {
                RefreshPartidasPorTime(1);
                btnProxTime.Show();
                btnTimeAnterior.Show();
                PaginaPartidas = 1;

                lblRodada.Location = new Point(102, 472);
            }
        }

        private void btnTimeAnterior_Click(object sender, EventArgs e)
        {
            if (IdTime > 1)
                RefreshPartidasPorTime(IdTime - 1);
        }

        private void btnProxTime_Click(object sender, EventArgs e)
        {
            if (IdTime < 20)
                RefreshPartidasPorTime(IdTime + 1);
        }

        private void btnJogarRodada_Click(object sender, EventArgs e)
        {
            var rodada = Manager.Instance.dBRodadas.Rodadas.FirstOrDefault(x => !x.FoiJogada);
            if (rodada == null)
            {
                TodasAsRodadasJaForamJogadas();
                return;
            }

            Manager.Instance.JogarRodada(rodada);

            var msgBox = new CustomMsgBox("Jogar 1 Rodada", $"Rodada {rodada.Rodada} foi jogada com sucesso!", MessageBoxType.E_OK);
            var result = msgBox.ShowDialog();
        }

        private void btnTodasRodadas_Click(object sender, EventArgs e)
        {
            if (Manager.Instance.dBRodadas.Rodadas.Any(r => !r.FoiJogada))
            {
                Manager.Instance.JogarTodasRodadas();
            }
            else
            {
                TodasAsRodadasJaForamJogadas();
            }

            var msgBox = new CustomMsgBox("Jogar rodadas restantes", $"Todas as rodadas restantes foram jogadas com sucesso!", MessageBoxType.E_OK);
            var result = msgBox.ShowDialog();
        }

        private void btnLimparCamp_Click(object sender, EventArgs e)
        {
            foreach (var time in Manager.Instance.dBTimes.Times)
            {
                time.Derrotas = 0;
                time.Vitorias = 0;
                time.GolsFeitos = 0;
                time.GolsSofridos = 0;
                time.Pontos = 0;
                time.SaldoDeGols = 0;
                time.Empates = 0;
            }

            DBManager.Serialize(Manager.Instance.dBTimes);
            DBManager.Serialize(Manager.Instance.dBRodadas);
            DBManager.Serialize(Manager.Instance.dBPartidas);

            Manager.Instance.CriarCampeonato();

            var msgBox = new CustomMsgBox("Limpar Campeonato", $"O campeonato foi resetado com sucesso!", MessageBoxType.E_OK);
            var result = msgBox.ShowDialog();
        }
    }
}
