using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BattleStage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string pokemonurl = "https://pokeapi.co/api/v2/pokemon?offset=0&limit=1100/";
            PokemonAPI pokemonapi;
            using (var client = new HttpClient())
            {
                string pokeResults = client.GetStringAsync(pokemonurl).Result;

                pokemonapi = JsonConvert.DeserializeObject<PokemonAPI>(pokeResults);
            }

            List<Pokemon> pokemon = new List<Pokemon>();
            foreach (var poke in pokemonapi.results)
            {
                pokemon.Add(poke);
            }
            List<Stats> pokemon1stats = new List<Stats>();
            List<Stats> pokemon2stats = new List<Stats>();
            Dictionary<string, int> pokemon1statsvalues = new Dictionary<string, int>();
            Dictionary<string, int> pokemon2statsvalues = new Dictionary<string, int>();
            Random random = new Random();

            for (int i = 0; i < 2; i++)
            {
                int index = random.Next(pokemon.Count);
                Pokemon selectedpokemon = pokemon.ElementAt(index);
                string selectedpokemonurl = selectedpokemon.url;
                PokeInfoAPI selectedpokeInfo;

                using (var client = new HttpClient())
                {
                    string pokeInfo = client.GetStringAsync(selectedpokemonurl).Result;

                    selectedpokeInfo = JsonConvert.DeserializeObject<PokeInfoAPI>(pokeInfo);
                }
                Uri uri;
                if (i == 0)
                {
                    
                    uri = new Uri(selectedpokeInfo.sprites.back_default);
                    BitmapImage backsprite = new BitmapImage(uri);
                    imgPlayerPokemon.Source = backsprite;
                    txtDecision.Text = $"What will {selectedpokemon.ToString().ToUpper()} do?";
                    txtPlayerPokemon.Text = selectedpokemon.ToString().ToUpper();
                    foreach (var stat in selectedpokeInfo.stats)
                    {
                        pokemon1stats.Add(stat);
                    }
                    foreach (var stat in pokemon1stats)
                    {
                        pokemon1statsvalues.Add(stat.stat.name, stat.base_stat);
                    }
                    foreach (var stat in pokemon1statsvalues)
                    {
                        if (stat.Key == "hp")
                        {
                            txtPlayerHP.Text = $"{stat.Value}/{stat.Value}";
                        }
                    }

                }
                else if (i == 1)
                {
                    uri = new Uri(selectedpokeInfo.sprites.front_default);
                    BitmapImage frontsprite = new BitmapImage(uri);
                    imgOpponentPokemon.Source = frontsprite;
                    txtOpponentPokemon.Text = selectedpokemon.ToString().ToUpper();
                    foreach (var stat in selectedpokeInfo.stats)
                    {
                        pokemon2stats.Add(stat);
                    }
                    foreach (var stat in pokemon1stats)
                    {
                        pokemon2statsvalues.Add(stat.stat.name, stat.base_stat);
                    }
                }



            }

            
    
        }
    }
    
}
