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
        private readonly string[] _times = {"Athletico Paranaense", "Atlético Mineiro", "Avaí", "Bahia", "Botafogo", "Ceará", "Chapecoense", "Corinthians", "Cruzeiro", "CSA", "Flamengo",
                           "Fluminense", "Fortaleza", "Goiás", "Grêmio", "Internacional", "Palmeiras", "Santos", "São Paulo", "Vasco da Gama"};

        private readonly string [] _jogadores = { "Liam", "Noah", "William", "James", "Logan", "Benjamin", "Mason", "Elijah", "Oliver", "Jacob", "Lucas", "Michael", "Alexander", "Ethan", "Daniel", "Matthew", "Aiden", "Henry", "Joseph", "Jackson", "Samuel", "Sebastian", "David", "Carter", "Wyatt", "Jayden", "John", "Owen", "Dylan", "Luke", "Gabriel", "Anthony", "Isaac", "Grayson", "Jack", "Julian", "Levi", "Christopher", "Joshua", "Andrew", "Lincoln", "Mateo", "Ryan", "Jaxon", "Nathan", "Aaron", "Isaiah", "Thomas", "Charles", "Caleb", "Josiah", "Christian", "Hunter", "Eli", "Jonathan", "Connor", "Landon", "Adrian", "Asher", "Cameron", "Leo", "Theodore", "Jeremiah", "Hudson", "Robert", "Easton", "Nolan", "Nicholas", "Ezra", "Colton", "Angel", "Brayden", "Jordan", "Dominic", "Austin", "Ian", "Adam", "Elias", "Jaxson", "Greyson", "Jose", "Ezekiel", "Carson", "Evan", "Maverick", "Bryson", "Jace", "Cooper", "Xavier", "Parker", "Roman", "Jason", "Santiago", "Chase", "Sawyer", "Gavin", "Leonardo", "Kayden", "Ayden", "Jameson", "Kevin", "Bentley", "Zachary", "Everett", "Axel", "Tyler", "Micah", "Vincent", "Weston", "Miles", "Wesley", "Nathaniel", "Harrison", "Brandon", "Cole", "Declan", "Luis", "Braxton", "Damian", "Silas", "Tristan", "Ryder", "Bennett", "George", "Emmett", "Justin", "Kai", "Max", "Diego", "Luca", "Ryker", "Carlos", "Maxwell", "Kingston", "Ivan", "Maddox", "Juan", "Ashton", "Jayce", "Rowan", "Kaiden", "Giovanni", "Eric", "Jesus", "Calvin", "Abel", "King", "Camden", "Amir", "Blake", "Alex", "Brody", "Malachi", "Emmanuel", "Jonah", "Beau", "Jude", "Antonio", "Alan", "Elliott", "Elliot", "Waylon", "Xander", "Timothy", "Victor", "Bryce", "Finn", "Brantley", "Edward", "Abraham", "Patrick", "Grant", "Karter", "Hayden", "Richard", "Miguel", "Joel", "Gael", "Tucker", "Rhett", "Avery", "Steven", "Graham", "Kaleb", "Jasper", "Jesse", "Matteo", "Dean", "Zayden", "Preston", "August", "Oscar", "Jeremy", "Alejandro", "Marcus", "Dawson", "Lorenzo", "Messiah", "Zion", "Maximus", "River", "Zane", "Mark", "Brooks", "Nicolas", "Paxton", "Judah", "Emiliano", "Kaden", "Bryan", "Kyle", "Myles", "Peter", "Charlie", "Kyrie", "Thiago", "Brian", "Kenneth", "Andres", "Lukas", "Aidan", "Jax", "Caden", "Milo", "Paul", "Beckett", "Brady", "Colin", "Omar", "Bradley", "Javier", "Knox", "Jaden", "Barrett", "Israel", "Matias", "Jorge", "Zander", "Derek", "Josue", "Cayden", "Holden", "Griffin", "Arthur", "Leon", "Felix", "Remington", "Jake", "Killian", "Clayton", "Sean", "Adriel", "Riley", "Archer", "Legend", "Erick", "Enzo", "Corbin", "Francisco", "Dallas", "Emilio", "Gunner", "Simon", "Andre", "Walter", "Damien", "Chance", "Phoenix", "Colt", "Tanner", "Stephen", "Kameron", "Tobias", "Manuel", "Amari", "Emerson", "Louis", "Cody", "Finley", "Iker", "Martin", "Rafael", "Nash", "Beckham", "Cash", "Karson", "Rylan", "Reid", "Theo", "Ace", "Eduardo", "Spencer", "Raymond", "Maximiliano", "Anderson", "Ronan", "Lane", "Cristian", "Titus", "Travis", "Jett", "Ricardo", "Bodhi", "Gideon", "Jaiden", "Fernando", "Mario", "Conor", "Keegan", "Ali", "Cesar", "Ellis", "Jayceon", "Walker", "Cohen", "Arlo", "Hector", "Dante", "Kyler", "Garrett", "Donovan", "Seth", "Jeffrey", "Tyson", "Jase", "Desmond", "Caiden", "Gage", "Atlas", "Major", "Devin", "Edwin", "Angelo", "Orion", "Conner", "Julius", "Marco", "Jensen", "Daxton", "Peyton", "Zayn", "Collin", "Jaylen", "Dakota", "Prince", "Johnny", "Kayson", "Cruz", "Hendrix", "Atticus", "Troy", "Kane", "Edgar", "Sergio", "Kash", "Marshall", "Johnathan", "Romeo", "Shane", "Warren", "Joaquin", "Wade", "Leonel", "Trevor", "Dominick", "Muhammad", "Erik", "Odin", "Quinn", "Jaxton", "Dalton", "Nehemiah", "Frank", "Grady", "Gregory", "Andy", "Solomon", "Malik", "Rory", "Clark", "Reed", "Harvey", "Zayne", "Jay", "Jared", "Noel", "Shawn", "Fabian", "Ibrahim", "Adonis", "Ismael", "Pedro", "Leland", "Malakai", "Malcolm", "Alexis", "Kason", "Porter", "Sullivan", "Raiden", "Allen", "Ari", "Russell", "Princeton", "Winston", "Kendrick", "Roberto", "Lennox", "Hayes", "Finnegan", "Nasir", "Kade", "Nico", "Emanuel", "Landen", "Moises", "Ruben", "Hugo", "Abram", "Adan", "Khalil", "Zaiden", "Augustus", "Marcos", "Philip", "Phillip", "Cyrus", "Esteban", "Braylen", "Albert", "Bruce", "Kamden", "Lawson", "Jamison", "Sterling", "Damon", "Gunnar", "Kyson", "Luka", "Franklin", "Ezequiel", "Pablo", "Derrick", "Zachariah", "Cade", "Jonas", "Dexter", "Kolton", "Remy", "Hank", "Tate", "Trenton", "Kian", "Drew", "Mohamed", "Dax", "Rocco", "Bowen", "Mathias", "Ronald", "Francis", "Matthias", "Milan", "Maximilian", "Royce", "Skyler", "Corey", "Kasen", "Drake", "Gerardo", "Jayson", "Sage", "Braylon", "Benson", "Moses", "Alijah", "Rhys", "Otto", "Oakley", "Armando"};

        private readonly string[] _arbitros = { "Árbitro 1", "Árbitro 2", "Árbitro 3", "Árbitro 4", "Árbitro 5", "Árbitro 6", "Árbitro 7", "Árbitro 8" };

        private static Manager _inst;

        private Random rand = new Random();

        public static void Initialize()
        {
            if (_inst != null)
                throw new System.ArgumentException("Instância já existente, não utilize mais de um Initialize no Manager, utilize Manager.Instance para obter a instância já existente.");
            _inst = new Manager();

            _inst.dBJogadores = DBManager.Deserialize<DBJogadores>();
            _inst.dBTimes = DBManager.Deserialize<DBTimes>();
            _inst.dBArbitros = DBManager.Deserialize<DBArbitros>();

            if (_inst.dBJogadores.Jogadores.Count == 0)
                _inst.CarregarJogadoresDefault();

            if (_inst.dBTimes.Times.Count == 0)
                _inst.CarregarTimesDefault();

            if (_inst.dBArbitros.Arbitros.Count == 0)
                _inst.CarregarArbitrosDefault();

        }

        public static Manager Instance =>_inst;
        public static string[] TimesDefault=> _inst._times;
        public static string[] JogadoresDefault => _inst._jogadores;
        public static string[] ArbitrosDefault => _inst._arbitros;



        public DBTimes dBTimes = new DBTimes();
        public DBJogadores dBJogadores = new DBJogadores();
        public DBArbitros dBArbitros = new DBArbitros();


        public void CarregarTimesDefault()
        {
            dBTimes.Times.Clear();
            Queue<int> atleta = new Queue<int>();
            for(int i = 0; i < dBJogadores.Jogadores.Count; i++)
            {
                atleta.Enqueue(i);
            }

            foreach (var Time in _times)
            {
                List<int> JogadoresDoTime = new List<int>();
                for(int i = 0; i < 24; i++)
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
