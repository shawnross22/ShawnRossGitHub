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
            Dictionary<string, int> pokemon1basestats = new Dictionary<string, int>();
            Dictionary<string, int> pokemon2basestats = new Dictionary<string, int>();
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
                        pokemon1basestats.Add(stat.stat.name, stat.base_stat);
                    }
                    
                    foreach (var stat in pokemon1basestats)
                    {
                        if (stat.Key == "hp")
                        {
                            pokemon1Calc.BaseHP = stat.Value;
                        }
                        else if (stat.Key == "attack")
                        {
                            pokemon1Calc.BaseAttack = stat.Value;
                        }
                        else if (stat.Key == "defense")
                        {
                            pokemon1Calc.BaseDefense = stat.Value;
                        }
                        else if (stat.Key == "special-attack")
                        {
                            pokemon1Calc.BaseSpecialAttack = stat.Value;
                        }
                        else if (stat.Key == "special-defense")
                        {
                            pokemon1Calc.BaseSpecialDefense = stat.Value;
                        }
                        else if (stat.Key == "speed")
                        {
                            pokemon1Calc.BaseSpeed = stat.Value;
                        }
                    }
                    pokemon1Calc.Level = 50;
                    string nature = pokemon1Calc.GetNature();
                    pokemon1Calc.Nature = nature;
                    int[] pokemon1calculatedstats = pokemon1Calc.CalculateStats();
                    pokemon1Calc.HP = pokemon1calculatedstats[0];
                    pokemon1Calc.Attack = pokemon1calculatedstats[1];
                    pokemon1Calc.Defense = pokemon1calculatedstats[2];
                    pokemon1Calc.SpecialAttack = pokemon1calculatedstats[3];
                    pokemon1Calc.SpecialDefense = pokemon1calculatedstats[4];
                    pokemon1Calc.Speed = pokemon1calculatedstats[5];
                    txtPlayerHP.Text = $"{pokemon1Calc.HP}/{pokemon1Calc.HP}";

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
                    foreach (var stat in pokemon2stats)
                    {
                        pokemon2basestats.Add(stat.stat.name, stat.base_stat);
                    }
                    foreach (var stat in pokemon1basestats)
                    {
                        if (stat.Key == "hp")
                        {
                            pokemon2Calc.BaseHP = stat.Value;
                        }
                        else if (stat.Key == "attack")
                        {
                            pokemon2Calc.BaseAttack = stat.Value;
                        }
                        else if (stat.Key == "defense")
                        {
                            pokemon2Calc.BaseDefense = stat.Value;
                        }
                        else if (stat.Key == "special-attack")
                        {
                            pokemon2Calc.BaseSpecialAttack = stat.Value;
                        }
                        else if (stat.Key == "special-defense")
                        {
                            pokemon2Calc.BaseSpecialDefense = stat.Value;
                        }
                        else if (stat.Key == "speed")
                        {
                            pokemon2Calc.BaseSpeed = stat.Value;
                        }
                    }
                    pokemon2Calc.Level = 50;
                    string nature = pokemon2Calc.GetNature();
                    pokemon2Calc.Nature = nature;
                    int[] pokemon1calculatedstats = pokemon2Calc.CalculateStats();
                    pokemon2Calc.HP = pokemon1calculatedstats[0];
                    pokemon2Calc.Attack = pokemon1calculatedstats[1];
                    pokemon2Calc.Defense = pokemon1calculatedstats[2];
                    pokemon2Calc.SpecialAttack = pokemon1calculatedstats[3];
                    pokemon2Calc.SpecialDefense = pokemon1calculatedstats[4];
                    pokemon2Calc.Speed = pokemon1calculatedstats[5];
                }



            }

            
    
        }
        public StatsCalculation pokemon1Calc = new StatsCalculation();
        public StatsCalculation pokemon2Calc = new StatsCalculation();
        private void btnPokemon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"HP: {pokemon1Calc.HP}, Attack: {pokemon1Calc.Attack}, Defense: {pokemon1Calc.Defense}, Special Attack: {pokemon1Calc.SpecialAttack}, Special Defense: {pokemon1Calc.SpecialDefense}, Speed: {pokemon1Calc.Speed}");
            MessageBox.Show($"HP: {pokemon1Calc.BaseHP}, Attack: {pokemon1Calc.BaseAttack}, Defense: {pokemon1Calc.BaseDefense}, Special Attack: {pokemon1Calc.BaseSpecialAttack}, Special Defense: {pokemon1Calc.BaseSpecialDefense}, Speed: {pokemon1Calc.BaseSpeed}");
            MessageBox.Show($"HP: {pokemon2Calc.HP}, Attack: {pokemon2Calc.Attack}, Defense: {pokemon2Calc.Defense}, Special Attack: {pokemon2Calc.SpecialAttack}, Special Defense: {pokemon2Calc.SpecialDefense}, Speed: {pokemon2Calc.Speed}");
            MessageBox.Show($"HP: {pokemon2Calc.BaseHP}, Attack: {pokemon2Calc.BaseAttack}, Defense: {pokemon2Calc.BaseDefense}, Special Attack: {pokemon2Calc.BaseSpecialAttack}, Special Defense: {pokemon2Calc.BaseSpecialDefense}, Speed: {pokemon2Calc.BaseSpeed}");
        }
    }
    
}
