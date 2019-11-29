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
    public partial class DetalhesPartida : MaterialForm
    {
        private LayoutPartidas _partida = new LayoutPartidas();

        public DetalhesPartida(LayoutPartidas Partida)
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            this.StartPosition = FormStartPosition.CenterScreen;

            _partida = Partida;
        }

        private void DetalhesPartida_Load(object sender, EventArgs e)
        {
            lblPartidaID.Text = $"ID: {_partida.ID.ToString()}";
            TimeA.Text = _partida.TimeA.Nome;
            TimeB.Text = _partida.TimeB.Nome;
            GolsTimeA.Text = _partida.GolsTimeA.ToString();
            GolsTimeB.Text = _partida.GolsTimeB.ToString();
            lblEstadio.Text = $"Estádio: {_partida.Estadio.Nome}";

            var arr = _partida.Arbitros.Select(x => x.ID).ToArray();
            lbArbitros.DataSource = arr;
        }

        private void lbArbitros_Format(object sender, ListControlConvertEventArgs e)
        {
            int lbID = (int)e.ListItem;

            e.Value = Manager.Instance.dBArbitros.Arbitros.Find(x => x.ID == lbID).Nome;
        }

        private void btn_FecharDetalhesPartida_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
