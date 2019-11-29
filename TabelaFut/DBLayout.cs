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

        [JsonProperty(PropertyName = "Ultimo ID")]
        public int UltimoID = 0;

        [JsonIgnore]
        public string[] Nomes => Times.Select(x => x.Nome).ToArray();
    }

    public class LayoutTimes
    {
        public int ID;
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

        public List<int> Jogadores = new List<int>();
    }

    public class DBJogadores
    {
        public List<LayoutJogadores> Jogadores = new List<LayoutJogadores>();
        [JsonProperty(PropertyName = "Ultimo ID")]
        public int UltimoID = 0;
        [JsonIgnore]
        public string[] Nomes => Jogadores.Select(x => x.Nome).ToArray();
    }

    public class LayoutJogadores
    {
        public int ID;
        public string Nome;
        public int Idade;
        public int Altura;
        public int Gols;
    }

    public class DBArbitros
    {
        public List<LayoutArbitros> Arbitros = new List<LayoutArbitros>();
        [JsonProperty(PropertyName = "Ultimo ID")]
        public int UltimoID = 0;
        [JsonIgnore]
        public string[] Nomes => Arbitros.Select(x => x.Nome).ToArray();
    }

    public class LayoutArbitros
    {
        public int ID;
        public string Nome;
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
                var ret = (T)Activator.CreateInstance(typeof(T));
                return ret;
            }

            return JsonConvert.DeserializeObject<T>(File.ReadAllText($"{Application.StartupPath}\\{typeof(T).Name.ToString()}.json"));
        }
    }

    public class DBEstadios
    {
        [JsonProperty(PropertyName = "Ultimo ID")]
        public int UltimoID = 0;
        public List<LayoutEstadios> Estadios = new List<LayoutEstadios>();
    }

    public class LayoutEstadios
    {
        public int ID;
        public string Nome;
        public List<int> IDTimes = new List<int>();
    }

    public class DBPartidas
    {
        [JsonProperty(PropertyName = "Ultimo ID")]
        public int UltimoID = 0;
        public List<LayoutPartidas> Partidas = new List<LayoutPartidas>();
    }

    public class LayoutPartidas
    {
        public int ID;
        public LayoutTimes TimeA;
        public LayoutTimes TimeB;

        public LayoutTimes TimeVencedor;

        public int GolsTimeA;
        public int GolsTimeB;

        public List<LayoutArbitros> Arbitros = new List<LayoutArbitros>(4);
        public LayoutEstadios Estadio;
    }

    public class DBRodadas
    {
        [JsonProperty(PropertyName = "Ultimo ID")]
        public int UltimoID = 0;
        public List<LayoutRodadas> Rodadas = new List<LayoutRodadas>();
    }

    public class LayoutRodadas
    {
        public int ID;
        public int Rodada;
        public List<LayoutPartidas> Partidas = new List<LayoutPartidas>(10);
    }
}
