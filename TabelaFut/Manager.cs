using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabelaFut
{
    public class Manager
    {


        private string[] _times = {"Athletico Paranaense", "Atlético Mineiro", "Avaí", "Bahia", "Botafogo", "Ceará", "Chapecoense", "Corinthians", "Cruzeiro", "CSA", "Flamengo",
                           "Fluminense", "Fortaleza", "Goiás", "Grêmio", "Internacional", "Palmeiras", "Santos", "São Paulo", "Vasco da Gama"};


        private static Manager _inst;

        public static void Initialize()
        {
            if (_inst != null)
                throw new System.ArgumentException("Instância já existente, não utilize mais de um Initialize no Manager, utilize Manager.Instance para obter a instância já existente.");
            _inst = new Manager();

            _inst.dBTimes = DBManager.Deserialize<DBTimes>();

        }

        public static Manager Instance =>_inst;
        public static string[] Times => _inst._times;



        public DBTimes dBTimes = new DBTimes();


        public void CarregarTimesDefault()
        {
            dBTimes.Times.Clear();

            foreach (var Clube in _times)
            {
                dBTimes.Times.Add(new LayoutTimes()
                {
                    Nome = Clube
                });
            }

            DBManager.Serialize(dBTimes);
        }
    }
}
