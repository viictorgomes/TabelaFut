using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TabelaFut
{

    public class DBTimes 
    {
        public List<LayoutTimes> Times = new List<LayoutTimes>();
    }

    public class LayoutTimes
    {
        public string Nome;
        public int Pontos;
        public int Vitorias;
        public int Empates;
        public int Derrotas;

        [JsonProperty(PropertyName = "Gols Feitos")]
        public int GolsFeitos;

        [JsonProperty(PropertyName = "Gols Sofridos")]
        public int GolsSofridos;

        [JsonProperty(PropertyName = "Saldo de Gols")]
        public int SaldoDeGols;



    }

    public class DBJogadores
    {
        public string Nome;
        public int Idade;
        public int Altura;
        public int Gols;
    }

    public class DBManager
    {
        public static void Serialize<T>(T obj)
        {
            File.WriteAllText($"{Application.StartupPath}\\{obj.GetType().Name}.json", JsonConvert.SerializeObject(obj, Formatting.Indented));
        }

        public static T Deserialize<T>()
        {
            if(!File.Exists($"{Application.StartupPath}\\{typeof(T).Name.ToString()}.json"))
            {
                MessageBox.Show(typeof(T).Name.ToString());
                var ret = (T)Activator.CreateInstance(typeof(T));
                return ret;
            }

            return JsonConvert.DeserializeObject<T>(File.ReadAllText($"{Application.StartupPath}\\{typeof(T).Name.ToString()}.json"));

        }
    }
}
