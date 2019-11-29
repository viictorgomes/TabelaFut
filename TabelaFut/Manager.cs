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
        #region Default Setup

        private readonly string[] _times = {"Athletico Paranaense", "Atlético Mineiro", "Avaí", "Bahia", "Botafogo", "Ceará", "Chapecoense", "Corinthians", "Cruzeiro", "CSA", "Flamengo", "Fluminense", "Fortaleza", "Goiás", "Grêmio", "Internacional", "Palmeiras", "Santos", "São Paulo", "Vasco da Gama"};

        private readonly string[] _jogadores = { "Liam", "Noah", "William", "James", "Logan", "Benjamin", "Mason", "Elijah", "Oliver", "Jacob", "Lucas", "Michael", "Alexander", "Ethan", "Daniel", "Matthew", "Aiden", "Henry", "Joseph", "Jackson", "Samuel", "Sebastian", "David", "Carter", "Wyatt", "Jayden", "John", "Owen", "Dylan", "Luke", "Gabriel", "Anthony", "Isaac", "Grayson", "Jack", "Julian", "Levi", "Christopher", "Joshua", "Andrew", "Lincoln", "Mateo", "Ryan", "Jaxon", "Nathan", "Aaron", "Isaiah", "Thomas", "Charles", "Caleb", "Josiah", "Christian", "Hunter", "Eli", "Jonathan", "Connor", "Landon", "Adrian", "Asher", "Cameron", "Leo", "Theodore", "Jeremiah", "Hudson", "Robert", "Easton", "Nolan", "Nicholas", "Ezra", "Colton", "Angel", "Brayden", "Jordan", "Dominic", "Austin", "Ian", "Adam", "Elias", "Jaxson", "Greyson", "Jose", "Ezekiel", "Carson", "Evan", "Maverick", "Bryson", "Jace", "Cooper", "Xavier", "Parker", "Roman", "Jason", "Santiago", "Chase", "Sawyer", "Gavin", "Leonardo", "Kayden", "Ayden", "Jameson", "Kevin", "Bentley", "Zachary", "Everett", "Axel", "Tyler", "Micah", "Vincent", "Weston", "Miles", "Wesley", "Nathaniel", "Harrison", "Brandon", "Cole", "Declan", "Luis", "Braxton", "Damian", "Silas", "Tristan", "Ryder", "Bennett", "George", "Emmett", "Justin", "Kai", "Max", "Diego", "Luca", "Ryker", "Carlos", "Maxwell", "Kingston", "Ivan", "Maddox", "Juan", "Ashton", "Jayce", "Rowan", "Kaiden", "Giovanni", "Eric", "Jesus", "Calvin", "Abel", "King", "Camden", "Amir", "Blake", "Alex", "Brody", "Malachi", "Emmanuel", "Jonah", "Beau", "Jude", "Antonio", "Alan", "Elliott", "Elliot", "Waylon", "Xander", "Timothy", "Victor", "Bryce", "Finn", "Brantley", "Edward", "Abraham", "Patrick", "Grant", "Karter", "Hayden", "Richard", "Miguel", "Joel", "Gael", "Tucker", "Rhett", "Avery", "Steven", "Graham", "Kaleb", "Jasper", "Jesse", "Matteo", "Dean", "Zayden", "Preston", "August", "Oscar", "Jeremy", "Alejandro", "Marcus", "Dawson", "Lorenzo", "Messiah", "Zion", "Maximus", "River", "Zane", "Mark", "Brooks", "Nicolas", "Paxton", "Judah", "Emiliano", "Kaden", "Bryan", "Kyle", "Myles", "Peter", "Charlie", "Kyrie", "Thiago", "Brian", "Kenneth", "Andres", "Lukas", "Aidan", "Jax", "Caden", "Milo", "Paul", "Beckett", "Brady", "Colin", "Omar", "Bradley", "Javier", "Knox", "Jaden", "Barrett", "Israel", "Matias", "Jorge", "Zander", "Derek", "Josue", "Cayden", "Holden", "Griffin", "Arthur", "Leon", "Felix", "Remington", "Jake", "Killian", "Clayton", "Sean", "Adriel", "Riley", "Archer", "Legend", "Erick", "Enzo", "Corbin", "Francisco", "Dallas", "Emilio", "Gunner", "Simon", "Andre", "Walter", "Damien", "Chance", "Phoenix", "Colt", "Tanner", "Stephen", "Kameron", "Tobias", "Manuel", "Amari", "Emerson", "Louis", "Cody", "Finley", "Iker", "Martin", "Rafael", "Nash", "Beckham", "Cash", "Karson", "Rylan", "Reid", "Theo", "Ace", "Eduardo", "Spencer", "Raymond", "Maximiliano", "Anderson", "Ronan", "Lane", "Cristian", "Titus", "Travis", "Jett", "Ricardo", "Bodhi", "Gideon", "Jaiden", "Fernando", "Mario", "Conor", "Keegan", "Ali", "Cesar", "Ellis", "Jayceon", "Walker", "Cohen", "Arlo", "Hector", "Dante", "Kyler", "Garrett", "Donovan", "Seth", "Jeffrey", "Tyson", "Jase", "Desmond", "Caiden", "Gage", "Atlas", "Major", "Devin", "Edwin", "Angelo", "Orion", "Conner", "Julius", "Marco", "Jensen", "Daxton", "Peyton", "Zayn", "Collin", "Jaylen", "Dakota", "Prince", "Johnny", "Kayson", "Cruz", "Hendrix", "Atticus", "Troy", "Kane", "Edgar", "Sergio", "Kash", "Marshall", "Johnathan", "Romeo", "Shane", "Warren", "Joaquin", "Wade", "Leonel", "Trevor", "Dominick", "Muhammad", "Erik", "Odin", "Quinn", "Jaxton", "Dalton", "Nehemiah", "Frank", "Grady", "Gregory", "Andy", "Solomon", "Malik", "Rory", "Clark", "Reed", "Harvey", "Zayne", "Jay", "Jared", "Noel", "Shawn", "Fabian", "Ibrahim", "Adonis", "Ismael", "Pedro", "Leland", "Malakai", "Malcolm", "Alexis", "Kason", "Porter", "Sullivan", "Raiden", "Allen", "Ari", "Russell", "Princeton", "Winston", "Kendrick", "Roberto", "Lennox", "Hayes", "Finnegan", "Nasir", "Kade", "Nico", "Emanuel", "Landen", "Moises", "Ruben", "Hugo", "Abram", "Adan", "Khalil", "Zaiden", "Augustus", "Marcos", "Philip", "Phillip", "Cyrus", "Esteban", "Braylen", "Albert", "Bruce", "Kamden", "Lawson", "Jamison", "Sterling", "Damon", "Gunnar", "Kyson", "Luka", "Franklin", "Ezequiel", "Pablo", "Derrick", "Zachariah", "Cade", "Jonas", "Dexter", "Kolton", "Remy", "Hank", "Tate", "Trenton", "Kian", "Drew", "Mohamed", "Dax", "Rocco", "Bowen", "Mathias", "Ronald", "Francis", "Matthias", "Milan", "Maximilian", "Royce", "Skyler", "Corey", "Kasen", "Drake", "Gerardo", "Jayson", "Sage", "Braylon", "Benson", "Moses", "Alijah", "Rhys", "Otto", "Oakley", "Armando" };

        private readonly string[] _arbitros = { "Miguel", "Arthur", "Heitor", "Bernardo", "Davi", "Théo", "Lorenzo", "Gabriel", "Pedro", "Benjamin", "Matheus", "Lucas", "Nicolas", "Joaquim", "Samuel", "Henrique", "Rafael", "Guilherme", "Enzo", "Murilo", "Benício", "Gustavo", "Isaac", "João", "Miguel Lucca", "Enzo Gabriel", "Pedro Henrique", "Felipe", "João  Pedro", "Pietro", "Anthony", "Daniel", "Bryan", "Davi Lucca", "Leonardo", "Vicente", "Eduardo", "Antônio", "Vitor Noah", "Caio", "João Emanuel", "Cauã", "João Lucas", "Calebe", "Enrico", "Vinícius Bento", "Thales", "Thiago", "Giulio", "Estêvão" };

        private readonly string[] _estadios = { "Arena da Baixada", "Independência", "Ressacada", "Arena Fonte Nova", "Nilton Santos", "Arena Castelão", "Arena Condá", "Arena Corinthians", "Mineirão", "Rei Pelé", "Maracanã", "Serra Dourada", "Arena do Grêmio", "Beira-Rio", "Allianz Parque", "Vila Belmiro", "Morumbi", "São Januário" };

        public enum Estadios
        {
            NONE,

            ArenadaBaixada,
            Independencia,
            Ressacada,
            ArenaFonteNova,
            NiltonSantos,
            ArenaCastelao,
            ArenaConda,
            ArenaCorinthians,
            Mineirao,
            ReiPele,
            Maracana,
            SerraDourada,
            ArenadoGremio,
            BeiraRio,
            AllianzParque,
            VilaBelmiro,
            Morumbi,
            SaoJanuario
        }

        #endregion

        private static Manager _inst;

        private static Random rand = new Random();

        public static Manager Instance => _inst;
        public static string[] TimesDefault => _inst._times;
        public static string[] JogadoresDefault => _inst._jogadores;
        public static string[] ArbitrosDefault => _inst._arbitros;

        public DBTimes dBTimes = new DBTimes();
        public DBEstadios dBEstadios = new DBEstadios();
        public DBJogadores dBJogadores = new DBJogadores();
        public DBArbitros dBArbitros = new DBArbitros();

        public DBPartidas dBPartidas = new DBPartidas();
        public DBRodadas dBRodadas = new DBRodadas();

        public static void Initialize()
        {
            if (_inst != null)
                throw new System.ArgumentException("Instância já existente, não utilize mais de um Initialize no Manager, utilize Manager.Instance para obter a instância já existente.");
            _inst = new Manager();

            _inst.dBEstadios = DBManager.Deserialize<DBEstadios>();
            _inst.dBJogadores = DBManager.Deserialize<DBJogadores>();
            _inst.dBTimes = DBManager.Deserialize<DBTimes>();
            _inst.dBArbitros = DBManager.Deserialize<DBArbitros>();
            _inst.dBRodadas = DBManager.Deserialize<DBRodadas>();
            _inst.dBPartidas = DBManager.Deserialize<DBPartidas>();

            if (_inst.dBEstadios.Estadios.Count == 0)
                _inst.CarregarEstadiosDefault();

            if (_inst.dBJogadores.Jogadores.Count == 0)
                _inst.CarregarJogadoresDefault();

            if (_inst.dBTimes.Times.Count == 0)
                _inst.CarregarTimesDefault();

            if (_inst.dBArbitros.Arbitros.Count == 0)
                _inst.CarregarArbitrosDefault();

            if(_inst.dBRodadas.Rodadas.Count == 0 && _inst.dBPartidas.Partidas.Count == 0)
                _inst.CriarCampeonato();
        }

        public static List<LayoutEstadios> EstadiosDisponiveis;
        public static List<LayoutArbitros> ArbitrosDisponiveis;

        /* TODO: 
         * Inserir de forma aleatória, 4 árbitros por partida;    --FEITO
         * Randomizar quantidade de gols na partida e determinar o time vencedor de acordo com o número de gols feito;
         * Randomizar 1 jogador do time por cada gol feito;
         * Preencher o estadio das partidas de acordo com as restrições;     --FEITO
         * */
        public void CriarCampeonato()
        {

            dBRodadas.Rodadas.Clear();
            dBPartidas.Partidas.Clear();
            dBRodadas.UltimoID = 0;
            dBPartidas.UltimoID = 0;

            var rodadas = new List<LayoutRodadas>(19);
            var partidas = new List<LayoutPartidas>(190);

            var times = _inst.dBTimes.Times;
            var timesA = times.GetRange(0, 10);
            var timesB = times.GetRange(10, 10);

            for (int i = 0; i < 19; i++)
            {

                EstadiosDisponiveis = new List<LayoutEstadios>();
                ArbitrosDisponiveis = new List<LayoutArbitros>();

                for (int aux = 0; aux < _inst.dBEstadios.Estadios.Count; aux++)
                {
                    EstadiosDisponiveis.Add(_inst.dBEstadios.Estadios[aux]);
                }

                for (int aux = 0; aux < _inst.dBArbitros.Arbitros.Count; aux++)
                {
                    ArbitrosDisponiveis.Add(_inst.dBArbitros.Arbitros[aux]);
                }

                var rodada = new LayoutRodadas();
                for (int j = 0; j < 10; j++)
                {
                    rodada.Rodada = i + 1;
                    var partida = new LayoutPartidas
                    {
                        ID = ++dBPartidas.UltimoID,
                        TimeA = timesA[j],
                        TimeB = timesB[j],
                        Arbitros = GetArbitros(),
                        Estadio = GetEstadio(timesA[j], timesB[j])
                    };
                    dBPartidas.Partidas.Add(partida);
                    rodada.Partidas.Add(partida);
                }

                var antigoTimesA = new List<LayoutTimes>();
                var antigoTimesB = new List<LayoutTimes>();

                for (int j = 0; j < 10; j++)
                {
                    antigoTimesA.Add(timesA[j]);
                    antigoTimesB.Add(timesB[j]);
                }

                timesA[1] = timesB[0];

                timesB[9] = timesA[9];

                for (int k = 2; k < 10; k++)
                {
                    timesA[k] = antigoTimesA[k - 1];
                }

                for (int k = 0; k < 9; k++)
                {
                    timesB[k] = antigoTimesB[k + 1];
                }

                rodada.ID = ++dBRodadas.UltimoID;
                rodadas.Add(rodada);
                dBRodadas.Rodadas.Add(rodada);
            }

            DBManager.Serialize(dBRodadas);
            DBManager.Serialize(dBPartidas);
        }
        
        public void JogarTodasRodadas()
        {
            var rodadas = dBRodadas.Rodadas;

            foreach (var rodada in rodadas)
            {
                if (!rodada.FoiJogada)
                {
                    JogarRodada(rodada);
                }
            }
        }

        public void JogarRodada(LayoutRodadas rodada)
        {
            if (rodada.FoiJogada)
                return;

            var _rodada = dBRodadas.Rodadas.Find(r => r.Rodada == rodada.ID);

            foreach (var partidaDb in _rodada.Partidas)
            {
                var partida = dBPartidas.Partidas.Find(p => p.ID == partidaDb.ID);

                partida.GolsTimeA = GetGolsDoTime(true);
                partida.GolsTimeB = GetGolsDoTime(false);
                
                if (partida.GolsTimeA != partida.GolsTimeB)
                {
                    LayoutTimes timeVencedor;
                    LayoutTimes timePerdedor;
                    int golsVencedor;
                    int golsPerdedor;

                    if (partida.GolsTimeA > partida.GolsTimeB)
                    {
                        timeVencedor = dBTimes.Times.Find(x => x.ID == partida.TimeA.ID);
                        timePerdedor = dBTimes.Times.Find(x => x.ID == partida.TimeB.ID);
                        golsVencedor = partida.GolsTimeA;
                        golsPerdedor = partida.GolsTimeB;
                    }
                    else
                    {
                        timeVencedor = dBTimes.Times.Find(x => x.ID == partida.TimeB.ID);
                        timePerdedor = dBTimes.Times.Find(x => x.ID == partida.TimeA.ID);
                        golsVencedor = partida.GolsTimeB;
                        golsPerdedor = partida.GolsTimeA;
                    }

                    partida.TimeVencedor = timeVencedor;

                    timeVencedor.Vitorias++;
                    timePerdedor.Derrotas++;

                    timeVencedor.Pontos += 3;

                    timeVencedor.GolsFeitos += golsVencedor;
                    timeVencedor.GolsSofridos += golsPerdedor;
                    timeVencedor.SaldoDeGols = timeVencedor.GolsFeitos - timeVencedor.GolsSofridos;

                    timePerdedor.GolsFeitos += golsPerdedor;
                    timePerdedor.GolsSofridos += golsVencedor;
                    timePerdedor.SaldoDeGols = timePerdedor.GolsFeitos - timePerdedor.GolsSofridos;

                }
                else
                {
                    var timeA = dBTimes.Times.Find(x => x.ID == partida.TimeA.ID);
                    var timeB = dBTimes.Times.Find(x => x.ID == partida.TimeB.ID);

                    timeA.Empates++;
                    timeB.Empates++;

                    timeA.Pontos++;
                    timeB.Pontos++;

                    timeA.GolsFeitos += partida.GolsTimeA;
                    timeA.GolsSofridos += partida.GolsTimeB;

                    timeB.GolsFeitos += partida.GolsTimeB;
                    timeB.GolsSofridos += partida.GolsTimeA;

                }
            }

            rodada.FoiJogada = true;

            DBManager.Serialize(dBTimes);
            DBManager.Serialize(dBPartidas);
            DBManager.Serialize(dBRodadas);
        }

        private int GetGolsDoTime(bool ehTimeMandante)
        {
            var golsTimeMandante = new List<int>();
            
            golsTimeMandante.AddRange(CriarProbabilidadeDeGols(0, 4));
            golsTimeMandante.AddRange(CriarProbabilidadeDeGols(1, 5));
            golsTimeMandante.AddRange(CriarProbabilidadeDeGols(2, 5));
            golsTimeMandante.AddRange(CriarProbabilidadeDeGols(3, 3));
            golsTimeMandante.AddRange(CriarProbabilidadeDeGols(4, 2));
            golsTimeMandante.AddRange(CriarProbabilidadeDeGols(5, 1));

            var golsTimeVisitante = new List<int>();

            golsTimeVisitante.AddRange(CriarProbabilidadeDeGols(0, 5));
            golsTimeVisitante.AddRange(CriarProbabilidadeDeGols(1, 4));
            golsTimeVisitante.AddRange(CriarProbabilidadeDeGols(2, 3));
            golsTimeVisitante.AddRange(CriarProbabilidadeDeGols(3, 3));
            golsTimeVisitante.AddRange(CriarProbabilidadeDeGols(4, 2));
            golsTimeVisitante.AddRange(CriarProbabilidadeDeGols(5, 1));

            if (ehTimeMandante)
            {
                int index = rand.Next(golsTimeMandante.Count - 1);
                return golsTimeMandante[index];
            }
            else
            {
                int index = rand.Next(golsTimeVisitante.Count - 1);
                return golsTimeVisitante[index];
            }
        }

        private List<int> CriarProbabilidadeDeGols(int quantidade, int probabilidade)
        {
            var list = new List<int>();
            for (int i = 0; i < probabilidade; i++)
            {
                list.Add(quantidade);
            }
            return list;
        }

        private static LayoutEstadios GetEstadio(LayoutTimes timeA, LayoutTimes timeB)
        {
            LayoutEstadios estadioAtual = null;

            foreach (var estadio in EstadiosDisponiveis)
            {
                if (estadio.IDTimes.Contains(timeA.ID) || estadio.IDTimes.Contains(timeB.ID))
                {
                    estadioAtual = estadio;
                    EstadiosDisponiveis.Remove(estadio);
                    break;
                }
            }

            return estadioAtual;
        }

        public static List<LayoutArbitros> GetArbitros()
        {
            var rand = new Random();
            var arbitros = new List<LayoutArbitros>(4);

            for (int i = 0; i < 4; i++)
            {
                var index = rand.Next(0, ArbitrosDisponiveis.Count);
                arbitros.Add(ArbitrosDisponiveis[index]);
                ArbitrosDisponiveis.RemoveAt(index);
            }

            return arbitros;
        }

        private List<int> SetupTimesPorEstadio(int estadio)
        {
            var times = new List<int>();
            
            switch (estadio)
            {
                case (int)Manager.Estadios.ArenadaBaixada:
                    {
                        times.Add(1); // Athletico Paranaense
                    }
                    break;
                case (int)Manager.Estadios.Independencia:
                    {
                        times.Add(2); // Atlético Mineiro
                    }
                    break;
                case (int)Manager.Estadios.Ressacada:
                    {
                        times.Add(3); // Avaí
                    }
                    break;
                case (int)Manager.Estadios.ArenaFonteNova:
                    {
                        times.Add(4); // Bahia
                    }
                    break;
                case (int)Manager.Estadios.NiltonSantos:
                    {
                        times.Add(5); // Botafogo
                    }
                    break;
                case (int)Manager.Estadios.ArenaCastelao:
                    {
                        times.Add(6); // Ceará
                        times.Add(13); // Fortaleza
                    }
                    break;
                case (int)Manager.Estadios.ArenaConda:
                    {
                        times.Add(7); // Chapecoense
                    }
                    break;
                case (int)Manager.Estadios.ArenaCorinthians:
                    {
                        times.Add(8); // Corinthians
                    }
                    break;
                case (int)Manager.Estadios.Mineirao:
                    {
                        times.Add(9); // Cruzeiro
                    }
                    break;
                case (int)Manager.Estadios.ReiPele:
                    {
                        times.Add(10); // CSA
                    }
                    break;
                case (int)Manager.Estadios.Maracana:
                    {
                        times.Add(11); // Flamengo
                        times.Add(12); // Fluminense
                    }
                    break;
                case (int)Manager.Estadios.SerraDourada:
                    {
                        times.Add(14); // Goiás
                    }
                    break;
                case (int)Manager.Estadios.ArenadoGremio:
                    {
                        times.Add(15); // Grêmio
                    }
                    break;
                case (int)Manager.Estadios.BeiraRio:
                    {
                        times.Add(16); // Internacional
                    }
                    break;
                case (int)Manager.Estadios.AllianzParque:
                    {
                        times.Add(17); // Palmeiras
                    }
                    break;
                case (int)Manager.Estadios.VilaBelmiro:
                    {
                        times.Add(18); // Santos
                    }
                    break;
                case (int)Manager.Estadios.Morumbi:
                    {
                        times.Add(19); // São Paulo
                    }
                    break;
                case (int)Manager.Estadios.SaoJanuario:
                    {
                        times.Add(20); // Vasco da Gama
                    }
                    break;
            }
            
            return times;
        }

        public void CarregarTimesDefault()
        {
            dBTimes.Times.Clear();
            Queue<int> atleta = new Queue<int>();
            for (int i = 0; i < dBJogadores.Jogadores.Count; i++)
            {
                atleta.Enqueue(i);
            }

            foreach (var Time in _times)
            {
                List<int> JogadoresDoTime = new List<int>();
                for (int i = 0; i < 24; i++)
                {
                    var jogador = dBJogadores.Jogadores[atleta.Dequeue()].ID;
                    JogadoresDoTime.Add(jogador);
                }

                dBTimes.Times.Add(new LayoutTimes()
                {
                    ID = ++dBTimes.UltimoID,
                    Nome = Time,
                    Jogadores = JogadoresDoTime
                });
            }

            DBManager.Serialize(dBTimes);
        }

        public void CarregarEstadiosDefault()
        {
            dBEstadios.Estadios.Clear();

            foreach (var estadio in _estadios)
            {
                var times = new List<LayoutTimes>();

                dBEstadios.Estadios.Add(new LayoutEstadios()
                {
                    ID = ++dBEstadios.UltimoID,
                    Nome = estadio,
                    IDTimes = SetupTimesPorEstadio(dBEstadios.UltimoID)
                });
            }

            DBManager.Serialize(dBEstadios);
        }

        public void CarregarJogadoresDefault()
        {
            dBJogadores.Jogadores.Clear();

            foreach (var jogador in _jogadores)
            {
                dBJogadores.Jogadores.Add(new LayoutJogadores()
                {
                    ID = ++dBJogadores.UltimoID,
                    Nome = jogador,
                    Altura = rand.Next(160, 191),
                    Gols = 0,
                    Idade = rand.Next(19, 37)
                });
            }

            DBManager.Serialize(dBJogadores);
        }

        public void CarregarArbitrosDefault()
        {
            dBArbitros.Arbitros.Clear();

            foreach (var arbitro in _arbitros)
            {
                dBArbitros.Arbitros.Add(new LayoutArbitros()
                {
                    ID = ++dBArbitros.UltimoID,
                    Nome = arbitro
                });
            }

            DBManager.Serialize(dBArbitros);
        }
    }
}
