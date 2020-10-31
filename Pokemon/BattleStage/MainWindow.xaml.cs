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
                
                Uri uri;
                if (i == 0)
                {
                    int index = random.Next(pokemon.Count);
                    pokemon1 = pokemon.ElementAt(index);
                    string selectedpokemonurl = pokemon1.url;
                    

                    using (var client = new HttpClient())
                    {
                        string pokeInfo = client.GetStringAsync(selectedpokemonurl).Result;

                        pokeinfo1 = JsonConvert.DeserializeObject<PokeInfoAPI>(pokeInfo);
                    }

                    uri = new Uri(pokeinfo1.sprites.back_default);
                    BitmapImage backsprite = new BitmapImage(uri);
                    imgPlayerPokemon.Source = backsprite;
                    txtDecision.Text = $"What will {pokemon1.ToString().ToUpper()} do?";
                    txtPlayerPokemon.Text = pokemon1.ToString().ToUpper();
                    foreach (var stat in pokeinfo1.stats)
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
                    int index = random.Next(pokemon.Count);
                    pokemon2 = pokemon.ElementAt(index);
                    string selectedpokemonurl = pokemon2.url;
                    

                    using (var client = new HttpClient())
                    {
                        string pokeInfo = client.GetStringAsync(selectedpokemonurl).Result;

                        pokeinfo2 = JsonConvert.DeserializeObject<PokeInfoAPI>(pokeInfo);
                    }

                    uri = new Uri(pokeinfo2.sprites.front_default);
                    BitmapImage frontsprite = new BitmapImage(uri);
                    imgOpponentPokemon.Source = frontsprite;
                    txtOpponentPokemon.Text = pokemon2.ToString().ToUpper();
                    foreach (var stat in pokeinfo2.stats)
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
        public Pokemon pokemon1 = new Pokemon();
        public Pokemon pokemon2 = new Pokemon();
        public PokeInfoAPI pokeinfo1 = new PokeInfoAPI();
        public PokeInfoAPI pokeinfo2 = new PokeInfoAPI();
        public StatsCalculation pokemon1Calc = new StatsCalculation();
        public StatsCalculation pokemon2Calc = new StatsCalculation();
        
        private void btnPokemon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"HP: {pokemon1Calc.HP}, Attack: {pokemon1Calc.Attack}, Defense: {pokemon1Calc.Defense}, Special Attack: {pokemon1Calc.SpecialAttack}, Special Defense: {pokemon1Calc.SpecialDefense}, Speed: {pokemon1Calc.Speed}");
            MessageBox.Show($"HP: {pokemon1Calc.BaseHP}, Attack: {pokemon1Calc.BaseAttack}, Defense: {pokemon1Calc.BaseDefense}, Special Attack: {pokemon1Calc.BaseSpecialAttack}, Special Defense: {pokemon1Calc.BaseSpecialDefense}, Speed: {pokemon1Calc.BaseSpeed}");
            MessageBox.Show($"HP: {pokemon2Calc.HP}, Attack: {pokemon2Calc.Attack}, Defense: {pokemon2Calc.Defense}, Special Attack: {pokemon2Calc.SpecialAttack}, Special Defense: {pokemon2Calc.SpecialDefense}, Speed: {pokemon2Calc.Speed}");
            MessageBox.Show($"HP: {pokemon2Calc.BaseHP}, Attack: {pokemon2Calc.BaseAttack}, Defense: {pokemon2Calc.BaseDefense}, Special Attack: {pokemon2Calc.BaseSpecialAttack}, Special Defense: {pokemon2Calc.BaseSpecialDefense}, Speed: {pokemon2Calc.BaseSpeed}");
        }



        private void btnFight_Click(object sender, RoutedEventArgs e)
        {
            List<Moves> pokemon1moves = new List<Moves>();
            Dictionary<string, int> MovesLevelUP = new Dictionary<string, int>();
            btnMove1.Visibility = Visibility.Visible;
            btnMove2.Visibility = Visibility.Visible;
            btnMove3.Visibility = Visibility.Visible;
            btnMove4.Visibility = Visibility.Visible;
            txtPP.Visibility = Visibility.Visible;
            txtType.Visibility = Visibility.Visible;
            txtDecision.Visibility = Visibility.Hidden;
            btnFight.Visibility = Visibility.Hidden;
            btnBag.Visibility = Visibility.Hidden;
            btnPokemon.Visibility = Visibility.Hidden;
            btnRun.Visibility = Visibility.Hidden;

            foreach (var move in pokeinfo1.moves)
            {
                pokemon1moves.Add(move);
                string name = move.move.name;
                bool isMoveAlreadyAdded = false;
                foreach (var VGD in move.version_group_details)
                {
                    if (VGD.move_learn_method.name == "level-up" && VGD.version_group.name == "ultra-sun-ultra-moon")
                    {
                        foreach (var LevelUpMove in MovesLevelUP)
                        {
                            if (name == LevelUpMove.Key)
                            {
                                isMoveAlreadyAdded = true;
                            }
                        }
                        if (isMoveAlreadyAdded == false)
                        {
                            MovesLevelUP.Add(move.move.name, VGD.level_learned_at);
                        }
                        
                    }
                }

            }
            int max1 = 0;
            int max2 = 0;
            int max3 = 0;
            int max4 = 0;
            foreach (var move in MovesLevelUP)
            {
                if (move.Value >= max1)
                {
                    max4 = max3;
                    max3 = max2;
                    max2 = max1;
                    max1 = move.Value;
                    btnMove4.Content = btnMove3.Content;
                    btnMove3.Content = btnMove2.Content;
                    btnMove2.Content = btnMove1.Content;
                    btnMove1.Content = move.Key.Replace('-',' ').ToUpper();
                }
                else if (move.Value >= max2)
                {
                    max4 = max3;
                    max3 = max2;
                    max2 = move.Value;
                    btnMove4.Content = btnMove3.Content;
                    btnMove3.Content = btnMove2.Content;
                    btnMove2.Content = move.Key.Replace('-',' ').ToUpper();
                }
                else if (move.Value >= max3)
                {
                    max4 = max3;
                    max3 = move.Value;
                    btnMove4.Content = btnMove3.Content;
                    btnMove3.Content = move.Key.Replace('-',' ').ToUpper();
                }
                else if (move.Value >= max4)
                {
                    max4 = move.Value;
                    btnMove4.Content = move.Key.Replace('-',' ').ToUpper();
                }

            }

            foreach (var move in pokemon1moves)
            {
                if (move.move.name == btnMove4.Content.ToString().Replace(' ', '-').ToLower())
                {
                    string moveurl = move.move.url;
                    using (var client = new HttpClient())
                    {
                        string moveResults = client.GetStringAsync(moveurl).Result;

                        pokemon1moveinfoapi4 = JsonConvert.DeserializeObject<MoveInfoAPI>(moveResults);
                    }
                }
                else if (move.move.name == btnMove3.Content.ToString().Replace(' ', '-').ToLower())
                {
                    string moveurl = move.move.url;
                    using (var client = new HttpClient())
                    {
                        string moveResults = client.GetStringAsync(moveurl).Result;

                        pokemon1moveinfoapi3 = JsonConvert.DeserializeObject<MoveInfoAPI>(moveResults);
                    }
                }
                else if (move.move.name == btnMove2.Content.ToString().Replace(' ', '-').ToLower())
                {
                    string moveurl = move.move.url;
                    using (var client = new HttpClient())
                    {
                        string moveResults = client.GetStringAsync(moveurl).Result;

                        pokemon1moveinfoapi2 = JsonConvert.DeserializeObject<MoveInfoAPI>(moveResults);
                    }
                }
                else if (move.move.name == btnMove1.Content.ToString().Replace(' ', '-').ToLower())
                {
                    string moveurl = move.move.url;
                    using (var client = new HttpClient())
                    {
                        string moveResults = client.GetStringAsync(moveurl).Result;

                        pokemon1moveinfoapi1 = JsonConvert.DeserializeObject<MoveInfoAPI>(moveResults);
                    }
                }
                
            }
            


        }
        public MoveInfoAPI pokemon1moveinfoapi1;
        public MoveInfoAPI pokemon1moveinfoapi2;
        public MoveInfoAPI pokemon1moveinfoapi3;
        public MoveInfoAPI pokemon1moveinfoapi4;

        


        private void btnMove4_MouseEnter(object sender, MouseEventArgs e)
        {

            txtPP.Text = $"{pokemon1moveinfoapi4.pp}/{pokemon1moveinfoapi4.pp}";
            txtType.Text = $"{pokemon1moveinfoapi4.type.name.ToUpper()}";

        }
        private void btnMove3_MouseEnter(object sender, MouseEventArgs e)
        {

            txtPP.Text = $"{pokemon1moveinfoapi3.pp}/{pokemon1moveinfoapi3.pp}";
            txtType.Text = $"{pokemon1moveinfoapi3.type.name.ToUpper()}";

        }
        private void btnMove2_MouseEnter(object sender, MouseEventArgs e)
        {

            txtPP.Text = $"{pokemon1moveinfoapi2.pp}/{pokemon1moveinfoapi2.pp}";
            txtType.Text = $"{pokemon1moveinfoapi2.type.name.ToUpper()}";

        }
        private void btnMove1_MouseEnter(object sender, MouseEventArgs e)
        {

            txtPP.Text = $"{pokemon1moveinfoapi1.pp}/{pokemon1moveinfoapi1.pp}";
            txtType.Text = $"{pokemon1moveinfoapi1.type.name.ToUpper()}";

        }

        public int damagetaken = 0;

        private void btnMove1_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double unroundeddamage = 0;
            TypeInfoAPI poke1type1info = new TypeInfoAPI();
            TypeInfoAPI poke1type2info = new TypeInfoAPI();
            TypeInfoAPI poke2type1info = new TypeInfoAPI();
            TypeInfoAPI poke2type2info = new TypeInfoAPI();
            List<TypeInfoAPI> poke1typeInfoAPIs = new List<TypeInfoAPI>();
            TypeInfoAPI poke1move1typeinfo = new TypeInfoAPI();
            TypeInfoAPI poke1move2typeinfo = new TypeInfoAPI();
            TypeInfoAPI poke1move3typeinfo = new TypeInfoAPI();
            TypeInfoAPI poke1move4typeinfo = new TypeInfoAPI();
            poke1typeInfoAPIs.Add(poke1move1typeinfo);
            poke1typeInfoAPIs.Add(poke1move2typeinfo);
            poke1typeInfoAPIs.Add(poke1move3typeinfo);
            poke1typeInfoAPIs.Add(poke1move4typeinfo);

            double stab = 1;
            double weakness = 1;
            double resistance = 1;
            int randomnumber = random.Next(85, 100);


            if (pokeinfo1.types.Count > 1)
            {
                string poke1type1infourl = pokeinfo1.types[0].type.url;
                
                using (var client = new HttpClient())
                {
                    string typeResults = client.GetStringAsync(poke1type1infourl).Result;

                    poke1type1info = JsonConvert.DeserializeObject<TypeInfoAPI>(typeResults);
                }

                string poke1type2infourl = pokeinfo1.types[1].type.url;
                
                using (var client = new HttpClient())
                {
                    string typeResults = client.GetStringAsync(poke1type2infourl).Result;

                    poke1type2info = JsonConvert.DeserializeObject<TypeInfoAPI>(typeResults);
                }

            }
            else
            {
                string poke1type1infourl = pokeinfo1.types[0].type.url;
                
                using (var client = new HttpClient())
                {
                    string typeResults = client.GetStringAsync(poke1type1infourl).Result;

                    poke1type1info = JsonConvert.DeserializeObject<TypeInfoAPI>(typeResults);
                }
            }

            if (pokeinfo2.types.Count > 1)
            {
                string poke2type1infourl = pokeinfo2.types[0].type.url;
                
                using (var client = new HttpClient())
                {
                    string typeResults = client.GetStringAsync(poke2type1infourl).Result;

                    poke2type1info = JsonConvert.DeserializeObject<TypeInfoAPI>(typeResults);
                }

                string poke2type2infourl = pokeinfo2.types[1].type.url;
                
                using (var client = new HttpClient())
                {
                    string typeResults = client.GetStringAsync(poke2type2infourl).Result;

                    poke2type2info = JsonConvert.DeserializeObject<TypeInfoAPI>(typeResults);
                }

            }
            else
            {
                string poke2type1infourl = pokeinfo2.types[0].type.url;
                
                using (var client = new HttpClient())
                {
                    string typeResults = client.GetStringAsync(poke2type1infourl).Result;

                    poke2type1info = JsonConvert.DeserializeObject<TypeInfoAPI>(typeResults);
                }
            }

            List<string> moveurls = new List<string>();
            string poke1move1infourl = pokemon1moveinfoapi1.type.url;
            string poke1move2infourl = pokemon1moveinfoapi2.type.url;
            string poke1move3infourl = pokemon1moveinfoapi3.type.url;
            string poke1move4infourl = pokemon1moveinfoapi4.type.url;
            moveurls.Add(poke1move1infourl);
            moveurls.Add(poke1move2infourl);
            moveurls.Add(poke1move3infourl);
            moveurls.Add(poke1move4infourl);

            for (int i = 0; i < 4; i++)
            {
                using (var client = new HttpClient())
                {
                    string typeResults = client.GetStringAsync(moveurls[i]).Result;

                    poke1typeInfoAPIs[i] = JsonConvert.DeserializeObject<TypeInfoAPI>(typeResults);
                }
            }
            if (pokeinfo2.types.Count>1)
            {
                if (pokemon1moveinfoapi1.type.name == pokeinfo2.types[0].type.name || pokemon1moveinfoapi1.type.name == pokeinfo2.types[1].type.name)
                {
                    stab = 1.5;
                }
            }
            else
            {
                if (pokemon1moveinfoapi1.type.name == pokeinfo2.types[0].type.name)
                {
                    stab = 1.5;
                }
            }
            
            if (pokeinfo2.types.Count > 1)
            {
                if (poke2type1info.damage_relations.double_damage_from.Contains(pokemon1moveinfoapi1.type) && poke2type2info.damage_relations.double_damage_from.Contains(pokemon1moveinfoapi1.type))
                {
                    weakness = 4;
                }
                else if (poke2type1info.damage_relations.double_damage_from.Contains(pokemon1moveinfoapi1.type))
                {
                    weakness = 2;
                }
                else if (poke2type2info.damage_relations.double_damage_from.Contains(pokemon1moveinfoapi1.type))
                {
                    weakness = 2;
                }
            }
            else
            {
                if (poke2type1info.damage_relations.double_damage_from.Contains(pokemon1moveinfoapi1.type))
                {
                    weakness = 2;
                }
            }

            if (pokeinfo2.types.Count > 1)
            {
                if (poke2type1info.damage_relations.half_damage_from.Contains(pokemon1moveinfoapi1.type) && poke2type2info.damage_relations.half_damage_from.Contains(pokemon1moveinfoapi1.type))
                {
                    resistance = 4;
                }
                else if (poke2type1info.damage_relations.half_damage_from.Contains(pokemon1moveinfoapi1.type))
                {
                    resistance = 2;
                }
                else if (poke2type2info.damage_relations.half_damage_from.Contains(pokemon1moveinfoapi1.type))
                {
                    resistance = 2;
                }
            }
            else
            {
                if (poke2type1info.damage_relations.half_damage_from.Contains(pokemon1moveinfoapi1.type))
                {
                    resistance = 2;
                }
            }
            if (pokeinfo2.types.Count > 1)
            {
                if (poke2type1info.damage_relations.no_damage_from.Contains(pokemon1moveinfoapi1.type) || poke2type2info.damage_relations.no_damage_from.Contains(pokemon1moveinfoapi1.type))
                {
                    unroundeddamage = 0;
                }
                else
                {
                    if (pokemon1moveinfoapi1.damage_class.name == "special")
                    {
                        unroundeddamage = ((((2 * pokemon1Calc.Level / 5 + 2) * pokemon1Calc.SpecialAttack * Convert.ToDouble(pokemon1moveinfoapi1.power) / pokemon2Calc.SpecialDefense) / 50) + 2) * stab * weakness / resistance * randomnumber / 100;


                        int damage = Convert.ToInt32(Math.Round(unroundeddamage, 0));
                        damagetaken = damagetaken + damage;
                        int battlehp = pokemon2Calc.HP - damagetaken;
                        double percenthealth;
                        if (battlehp < 0)
                        {
                            percenthealth = 0;
                        }
                        else
                        {
                            percenthealth = (double)battlehp / (double)pokemon2Calc.HP;
                        }
                        double width = 200 * percenthealth;
                        MessageBox.Show($"{damage}");
                        recOpponentHP.Width = width;


                    }
                    else if (pokemon1moveinfoapi1.damage_class.name == "physical")
                    {
                        unroundeddamage = ((((2 * pokemon1Calc.Level / 5 + 2) * pokemon1Calc.Attack * Convert.ToDouble(pokemon1moveinfoapi1.power) / pokemon2Calc.Defense) / 50) + 2) * stab * weakness / resistance * randomnumber / 100;
                        int damage = Convert.ToInt32(Math.Round(unroundeddamage, 0));
                        damagetaken = damagetaken + damage;
                        int battlehp = pokemon2Calc.HP - damagetaken;
                        double percenthealth;
                        if (battlehp < 0)
                        {
                            percenthealth = 0;
                        }
                        else
                        {
                            percenthealth = (double)battlehp / (double)pokemon2Calc.HP;
                        }
                        double width = 200 * percenthealth;
                        MessageBox.Show($"{damage}");
                        recOpponentHP.Width = width;
                    }
                }
            
            }
            else
            {
                if (poke2type1info.damage_relations.no_damage_from.Contains(pokemon1moveinfoapi1.type))
                {
                    unroundeddamage = 0;
                }
                else
                {
                    if (pokemon1moveinfoapi1.damage_class.name == "special")
                    {
                        unroundeddamage = ((((2 * pokemon1Calc.Level / 5 + 2) * pokemon1Calc.SpecialAttack * Convert.ToDouble(pokemon1moveinfoapi1.power) / pokemon2Calc.SpecialDefense) / 50) + 2) * stab * weakness / resistance * randomnumber / 100;
                        int damage = Convert.ToInt32(Math.Round(unroundeddamage, 0));
                        damagetaken = damagetaken + damage;
                        int battlehp = pokemon2Calc.HP - damagetaken;
                        double percenthealth;
                        if (battlehp<0)
                        {
                            percenthealth = 0;
                        }
                        else
                        {
                            percenthealth = (double)battlehp / (double)pokemon2Calc.HP;
                        }
                        
                        double width = 200 * percenthealth;
                        MessageBox.Show($"{damage}");
                        recOpponentHP.Width = width;


                    }
                    else if (pokemon1moveinfoapi1.damage_class.name == "physical")
                    {
                        unroundeddamage = ((((2 * pokemon1Calc.Level / 5 + 2) * pokemon1Calc.Attack * Convert.ToDouble(pokemon1moveinfoapi1.power) / pokemon2Calc.Defense) / 50) + 2) * stab * weakness / resistance * randomnumber / 100;
                        int damage = Convert.ToInt32(Math.Round(unroundeddamage, 0));
                        damagetaken = damagetaken + damage;
                        int battlehp = pokemon2Calc.HP - damagetaken;
                        double percenthealth;
                        if (battlehp < 0)
                        {
                            percenthealth = 0;
                        }
                        else
                        {
                            percenthealth = (double)battlehp / (double)pokemon2Calc.HP;
                        }
                        double width = 200 * percenthealth;
                        MessageBox.Show($"{damage}");
                        recOpponentHP.Width = width;
                    }
                }
            }

            
        }
    }
    
}
