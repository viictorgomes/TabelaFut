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
    public partial class frmEditJogador : MaterialForm
    {
        private bool bEdit;

        public LayoutJogadores _jogador;


        public frmEditJogador(bool Edit, LayoutJogadores Jogador)
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            this.StartPosition = FormStartPosition.CenterScreen;

            bEdit = Edit;


            if (!bEdit)
            {
                this.Text = "Adicionar Jogador";
                _jogador = new LayoutJogadores();
            }
            else
            {
                this.Text = "Editar Jogador";

                if (Jogador == null)
                    throw new Exception("Falha na instância frmEditJogador::_jogador");

                _jogador = Jogador;
                txtNome.Text = _jogador.Nome;
                txtIdade.Text = _jogador.Idade.ToString();
                txtAltura.Text = _jogador.Altura.ToString();
            }
        }

        private void btn_CancelarEditArbitro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length == 0 || txtIdade.Text.Length == 0 || txtAltura.Text.Length == 0)
            {
                var msgBox = new CustomMsgBox("Dados inválidos", $"Existem campos em branco ou preenchidos com valores inválidos", MessageBoxType.E_OK);
                var result = msgBox.ShowDialog();
                return;
            }

            _jogador.Nome = txtNome.Text;
            _jogador.Idade = Convert.ToInt32(txtIdade.Text);
            _jogador.Altura = Convert.ToInt32(txtAltura.Text);

            if (bEdit)
            {
                var find = Manager.Instance.dBJogadores.Jogadores.Find(x => x.ID == _jogador.ID);
                find = _jogador;
            }
            else
            {
                _jogador.ID = ++Manager.Instance.dBJogadores.UltimoID;
                Manager.Instance.dBJogadores.Jogadores.Add(_jogador);
            }

            var infoMsgBox = new CustomMsgBox("Informações Atualizadas!", $"Informações de jogadores atualizadas com sucesso!", MessageBoxType.E_OK);
            var infoResult = infoMsgBox.ShowDialog();

            DBManager.Serialize(Manager.Instance.dBJogadores);
            this.Close();
        }
    }
}
