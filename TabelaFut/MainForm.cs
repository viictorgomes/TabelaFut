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
            foreach(ListViewItem item in lvClassificacoes.Items)
            {
                item.SubItems[1].Text = index++.ToString();
                item.UseItemStyleForSubItems = false;

                if(index % 2 == 1)
                {
                    foreach(ListViewSubItem sub in item.SubItems)
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
                else if(index > 17)
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
                    if(index == 0)
                    {
                        index = 10;
                    }
                }

                var lblTimeA = Controls.Find($"TimeA_{index}", true).FirstOrDefault() as Label;
                var lblTimeB = Controls.Find($"TimeB_{index}", true).FirstOrDefault() as Label;
                var lblGolsTimeA = Controls.Find($"GolsTimeA_{index}", true).FirstOrDefault() as Label;
                var lblGolsTimeB = Controls.Find($"GolsTimeB_{index}", true).FirstOrDefault() as Label;

                lblTimeA.Text = partida.TimeA.Nome;
                lblTimeB.Text = partida.TimeB.Nome;
                lblGolsTimeA.Text = partida.GolsTimeA.ToString();
                lblGolsTimeB.Text = partida.GolsTimeB.ToString();
            }

            lblRodada.Text = $"Rodada {Rodada} de 19";
            PaginaPartidas = Rodada;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshClassificacao();
            RefreshPartidas(1);
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

        private void btnJogarTodasRodadas(object sender, EventArgs e)
        {
            if (Manager.Instance.dBRodadas.Rodadas.Any(r => !r.FoiJogada))
            {
                Manager.Instance.JogarTodasRodadas();
            }
            else
            {
                TodasAsRodadasJaForamJogadas();
            }
        }

        private void btnJogadProximaRodada(object sender, EventArgs e)
        {
            var rodada = Manager.Instance.dBRodadas.Rodadas.FirstOrDefault(x => !x.FoiJogada);
            if (rodada == null)
            {
                TodasAsRodadasJaForamJogadas();
                return;
            }

            Manager.Instance.JogarRodada(rodada);
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
            if (PaginaPartidas < 19)
                AlterarPaginaPartida(PaginaPartidas + 1);
        }

        private void btn_PagAnterior_Click(object sender, EventArgs e)
        {
            if (PaginaPartidas > 1)
                AlterarPaginaPartida(PaginaPartidas - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalhesPartida(1 + ((PaginaPartidas - 1) * 10));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetalhesPartida(2 + ((PaginaPartidas - 1) * 10));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetalhesPartida(3 + ((PaginaPartidas - 1) * 10));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DetalhesPartida(4 + ((PaginaPartidas - 1) * 10));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DetalhesPartida(5 + ((PaginaPartidas - 1) * 10));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DetalhesPartida(6 + ((PaginaPartidas - 1) * 10));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DetalhesPartida(7 + ((PaginaPartidas - 1) * 10));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DetalhesPartida(8 + ((PaginaPartidas - 1) * 10));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DetalhesPartida(9 + ((PaginaPartidas - 1) * 10));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DetalhesPartida(10 + ((PaginaPartidas - 1) * 10));
        }
    }
}
