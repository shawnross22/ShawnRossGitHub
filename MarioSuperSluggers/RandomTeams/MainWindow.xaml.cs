using System;
using System.Collections.Generic;
using System.Linq;
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

namespace RandomTeams
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {


            InitializeComponent();
            

        }

        private void btnRandomTeams_Click(object sender, RoutedEventArgs e)
        {
            List<string> urls = new List<string>();
            urls.Add("https://www.mariowiki.com/images/e/e4/MSS_Mario_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/5/50/MSS_Luigi_Character_Select_Sprite_1.png");
            urls.Add("https://www.mariowiki.com/images/f/f4/MSS_Peach_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/3/3e/MSS_Daisy_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/5/5b/MSS_Yoshi_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/6/6a/MSS_Blue_Yoshi_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/5/56/MSS_Light-Blue_Yoshi_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/9/94/MSS_Pink_Yoshi_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/3/34/MSS_Red_Yoshi_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/6/6c/MSS_Yellow_Yoshi_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/6/69/MSS_Birdo_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/9/96/MSS_Wario_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/9/9e/MSS_Waluigi_Character_Select_Sprite_1.png");
            urls.Add("https://www.mariowiki.com/images/c/c5/MSS_Donkey_Kong_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/6/61/MSS_Diddy_Kong_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/5/5e/MSS_Bowser_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/3/34/MSS_Bowser_Jr_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/8/8b/MSS_Baby_Mario_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/1/1c/MSS_Baby_Luigi_Character_Select_Sprite_1.png");
            urls.Add("https://www.mariowiki.com/images/4/49/MSS_Baby_Peach_Character_Select_Sprite_1.png");
            urls.Add("https://www.mariowiki.com/images/7/72/MSS_Baby_Daisy_Character_Select_Sprite_1.png");
            urls.Add("https://www.mariowiki.com/images/e/ef/MSS_Baby_Donkey_Kong_Character_Select_Sprite_1.png");
            urls.Add("https://www.mariowiki.com/images/6/62/MSS_Red_Toad_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/4/48/MSS_Blue_Toad_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/c/ca/MSS_Green_Toad_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/6/67/MSS_Purple_Toad_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/e/e9/MSS_Yellow_Toad_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/8/87/MSS_Toadette_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/5/5f/MSS_Toadsworth_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/0/05/MSS_Blue_Pianta_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/d/d9/MSS_Red_Pianta_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/e/ef/MSS_Yellow_Pianta_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/8/8a/MSS_Blue_Noki_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/5/5e/MSS_Green_Noki_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/f/f0/MSS_Red_Noki_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/e/e1/MSS_Dixie_Kong_Character_Select_Sprite_1.png");
            urls.Add("https://www.mariowiki.com/images/9/93/MSS_Funky_Kong_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/8/84/MSS_Tiny_Kong_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/c/c2/MSS_King_K_Rool_Character_Select_Sprite_1.png");
            urls.Add("https://www.mariowiki.com/images/6/61/MSS_Green_Kritter_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/f/f4/MSS_Blue_Kritter_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/0/0c/MSS_Brown_Kritter_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/b/b7/MSS_Red_Kritter_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/f/ff/MSS_Goomba_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/7/70/MSS_Paragoomba_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/3/36/MSS_Red_Koopa_Troopa_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/a/ac/MSS_Green_Koopa_Troopa_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/9/9c/MSS_Red_Koopa_Paratroopa_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/f/fd/MSS_Green_Koopa_Paratroopa_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/3/34/MSS_Blue_Magikoopa_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/7/70/MSS_Green_Magikoopa_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/2/2f/MSS_Red_Magikoopa_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/e/e9/MSS_Yellow_Magikoopa_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/a/a4/MSS_Hammer_Bro_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/c/ce/MSS_Fire_Bro_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/6/66/MSS_Boomerang_Bro_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/d/d2/MSS_Dry_Bones_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/6/68/MSS_Dark_Bones_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/2/23/MSS_Blue_Dry_Bones_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/6/66/MSS_Green_Dry_Bones_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/c/ca/MSS_Boo_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/7/74/MSS_King_Boo_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/0/05/MSS_Petey_Piranha_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/8/81/MSS_Wiggler_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/0/0a/MSS_Blue_Shy_Guy_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/7/7f/MSS_Gray_Shy_Guy_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/f/f2/MSS_Green_Shy_Guy_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/0/0c/MSS_Red_Shy_Guy_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/7/71/MSS_Yellow_Shy_Guy_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/e/e1/MSS_Monty_Mole_Character_Select_Sprite.png");
            urls.Add("https://www.mariowiki.com/images/8/86/MSS_Blooper_Character_Select_Sprite.png");

            Dictionary<string, int> slugCharacters = new Dictionary<string, int>();
            slugCharacters.Add("Mario", 1);
            slugCharacters.Add("Luigi", 1);
            slugCharacters.Add("Peach", 1);
            slugCharacters.Add("Daisy", 1);
            slugCharacters.Add("Yoshi", 6);
            slugCharacters.Add("Birdo", 1);
            slugCharacters.Add("Wario", 1);
            slugCharacters.Add("Waluigi", 1);
            slugCharacters.Add("Donkey_Kong", 1);
            slugCharacters.Add("Diddy_Kong", 1);
            slugCharacters.Add("Bowser", 1);
            slugCharacters.Add("Bowser_Jr", 1);
            slugCharacters.Add("Baby_Mario", 1);
            slugCharacters.Add("Baby_Luigi", 1);
            slugCharacters.Add("Baby_Peach", 1);
            slugCharacters.Add("Baby_Daisy", 1);
            slugCharacters.Add("Baby_Donkey_Kong", 1);
            slugCharacters.Add("Toad", 5);
            slugCharacters.Add("Toadette", 1);
            slugCharacters.Add("Toadsworth", 1);
            slugCharacters.Add("Pianta", 3);
            slugCharacters.Add("Noki", 3);
            slugCharacters.Add("Dixie_Kong", 1);
            slugCharacters.Add("Funky_Kong", 1);
            slugCharacters.Add("Tiny_Kong", 1);
            slugCharacters.Add("King_K_Rool", 1);
            slugCharacters.Add("Kritter", 4);
            slugCharacters.Add("Goomba", 1);
            slugCharacters.Add("Paragoomba", 1);
            slugCharacters.Add("Koopa_Troopa", 2);
            slugCharacters.Add("Paratroopa", 2);
            slugCharacters.Add("Magikoopa", 4);
            slugCharacters.Add("Bros", 3);
            slugCharacters.Add("Bones", 4);
            slugCharacters.Add("Boo", 1);
            slugCharacters.Add("King_Boo", 1);
            slugCharacters.Add("Petey_Piranha", 1);
            slugCharacters.Add("Wiggler", 1);
            slugCharacters.Add("Shy_Guy", 5);
            slugCharacters.Add("Monty_Mole", 1);
            slugCharacters.Add("Blooper", 1);

            List<string> Yoshis = new List<string>();
            Yoshis.Add("Yoshi");
            Yoshis.Add("Red_Yoshi");
            Yoshis.Add("Blue_Yoshi");
            Yoshis.Add("Yellow_Yoshi");
            Yoshis.Add("Light-Blue_Yoshi");
            Yoshis.Add("Pink_Yoshi");

            List<string> Toads = new List<string>();
            Toads.Add("Red_Toad");
            Toads.Add("Blue_Toad");
            Toads.Add("Yellow_Toad");
            Toads.Add("Green_Toad");
            Toads.Add("Purple_Toad");

            List<string> Piantas = new List<string>();
            Piantas.Add("Blue_Pianta");
            Piantas.Add("Red_Pianta");
            Piantas.Add("Yellow_Pianta");

            List<string> Nokis = new List<string>();
            Nokis.Add("Blue_Noki");
            Nokis.Add("Red_Noki");
            Nokis.Add("Green_Noki");

            List<string> Kritters = new List<string>();
            Kritters.Add("Green_Kritter");
            Kritters.Add("Blue_Kritter");
            Kritters.Add("Red_Kritter");
            Kritters.Add("Brown_Kritter");

            List<string> Koopas = new List<string>();
            Koopas.Add("Green_Koopa_Troopa");
            Koopas.Add("Red_Koopa_Troopa");

            List<string> Paratroopas = new List<string>();
            Paratroopas.Add("Red_Koopa_Paratroopa");
            Paratroopas.Add("Green_Koopa_Paratroopa");

            List<string> Magikoopas = new List<string>();
            Magikoopas.Add("Blue_Magikoopa");
            Magikoopas.Add("Red_Magikoopa");
            Magikoopas.Add("Green_Magikoopa");
            Magikoopas.Add("Yellow_Magikoopa");

            List<string> Bros = new List<string>();
            Bros.Add("Hammer_Bro");
            Bros.Add("Fire_Bro");
            Bros.Add("Boomerang_Bro");

            List<string> Bones = new List<string>();
            Bones.Add("Dry_Bones");
            Bones.Add("Green_Dry_Bones");
            Bones.Add("Dark_Bones");
            Bones.Add("Blue_Dry_Bones");

            List<string> ShyGuys = new List<string>();
            ShyGuys.Add("Red_Shy_Guy");
            ShyGuys.Add("Blue_Shy_Guy");
            ShyGuys.Add("Yellow_Shy_Guy");
            ShyGuys.Add("Green_Shy_Guy");
            ShyGuys.Add("Gray_Shy_Guy");

            List<string> Captains = new List<string>();
            Captains.Add("Mario");
            Captains.Add("Luigi");
            Captains.Add("Peach");
            Captains.Add("Daisy");
            Captains.Add("Wario");
            Captains.Add("Waluigi");
            Captains.Add("Yoshi");
            Captains.Add("Birdo");
            Captains.Add("Bowser");
            Captains.Add("Bowser_Jr");
            Captains.Add("Donkey_Kong");
            Captains.Add("Diddy_Kong");

            Image[] awayteamimages = new Image[] { imgAway1, imgAway2, imgAway3, imgAway4, imgAway5, imgAway6, imgAway7, imgAway8, imgAway9 };
            Image[] hometeamimages = new Image[] { imgHome1, imgHome2, imgHome3, imgHome4, imgHome5, imgHome6, imgHome7, imgHome8, imgHome9 };
            int YoshiCounter = 0;
            int ToadCounter = 0;
            int PiantaCounter = 0;
            int NokiCounter = 0;
            int KritterCounter = 0;
            int KoopaCounter = 0;
            int ParatroopaCounter = 0;
            int MagikoopaCounter = 0;
            int BrosCounter = 0;
            int BonesCounter = 0;
            int ShyGuyCounter = 0;

            Random random = new Random();
            List<string> awaychosenurls = new List<string>();
            List<string> homechosenurls = new List<string>();
            for (int i = 0; i < 2; i++)
            {
                int index = random.Next(Captains.Count);
                string captain = Captains.ElementAt(index);
                string subcaptain = $"MSS_{captain}_Character";
                string charurl;
                foreach (var url in urls)
                {
                    if (url.Contains(subcaptain) == true)
                    {
                        charurl = url;
                        if (i==0)
                        {
                            awaychosenurls.Add(charurl);
                        }
                        else if (i==1)
                        {
                            homechosenurls.Add(charurl);
                        }
                        
                        
                    }
                    if (captain == "Yoshi")
                    {
                        Yoshis.Remove(captain);
                        slugCharacters.Remove(captain);
                        Captains.Remove(captain);
                    }
                    
                    {
                        slugCharacters.Remove(captain);
                        Captains.Remove(captain);
                    }


                }


            }
            for (int i = 0; i < 16; i++)
            {
                int listindex;
                int index = random.Next(slugCharacters.Count);
                KeyValuePair<string, int> pair = slugCharacters.ElementAt(index);
                if (pair.Value > 1)
                {
                    if (pair.Key == "Yoshi")
                    {
                        listindex = random.Next(Yoshis.Count);
                        string pick = Yoshis.ElementAt(listindex);
                        string subpick = $"MSS_{pick}_Character";
                        string charurl;
                        foreach (var url in urls)
                        {
                            if (url.Contains(subpick) == true)
                            {
                                charurl = url;
                                if (i<8)
                                {
                                    awaychosenurls.Add(charurl);
                                }
                                else if (i>=8)
                                {
                                    homechosenurls.Add(charurl);
                                }
                            }

                        }
                        Yoshis.Remove(pick);
                        YoshiCounter = YoshiCounter + 1;
                        if (YoshiCounter == pair.Value)
                        {
                            slugCharacters.Remove(pair.Key);
                        }

                    }
                    else if (pair.Key == "Toad")
                    {
                        listindex = random.Next(Toads.Count);
                        string pick = Toads.ElementAt(listindex);
                        string subpick = $"MSS_{pick}_Character";
                        string charurl;
                        foreach (var url in urls)
                        {
                            if (url.Contains(subpick) == true)
                            {
                                charurl = url;
                                if (i < 8)
                                {
                                    awaychosenurls.Add(charurl);
                                }
                                else if (i >= 8)
                                {
                                    homechosenurls.Add(charurl);
                                }
                                Toads.Remove(pick);
                                ToadCounter = ToadCounter + 1;
                                if (ToadCounter == pair.Value)
                                {
                                    slugCharacters.Remove(pair.Key);
                                }
                            }
                        }

                    }
                    else if (pair.Key == "Pianta")
                    {
                        listindex = random.Next(Piantas.Count);
                        string pick = Piantas.ElementAt(listindex);
                        string subpick = $"MSS_{pick}_Character";
                        string charurl;
                        foreach (var url in urls)
                        {
                            if (url.Contains(subpick) == true)
                            {
                                charurl = url;
                                if (i < 8)
                                {
                                    awaychosenurls.Add(charurl);
                                }
                                else if (i >= 8)
                                {
                                    homechosenurls.Add(charurl);
                                }
                                Piantas.Remove(pick);
                                PiantaCounter = PiantaCounter + 1;
                                if (PiantaCounter == pair.Value)
                                {
                                    slugCharacters.Remove(pair.Key);
                                }
                            }
                        }
                    }
                    else if (pair.Key == "Noki")
                    {
                        listindex = random.Next(Nokis.Count);
                        string pick = Nokis.ElementAt(listindex);
                        string subpick = $"MSS_{pick}_Character";
                        string charurl;
                        foreach (var url in urls)
                        {
                            if (url.Contains(subpick) == true)
                            {

                                charurl = url;
                                if (i < 8)
                                {
                                    awaychosenurls.Add(charurl);
                                }
                                else if (i >= 8)
                                {
                                    homechosenurls.Add(charurl);
                                }
                                Nokis.Remove(pick);
                                NokiCounter = NokiCounter + 1;
                                if (NokiCounter == pair.Value)
                                {
                                    slugCharacters.Remove(pair.Key);
                                }
                            }
                        }
                    }
                    else if (pair.Key == "Kritter")
                    {
                        listindex = random.Next(Kritters.Count);
                        string pick = Kritters.ElementAt(listindex);
                        string subpick = $"MSS_{pick}_Character";
                        string charurl;
                        foreach (var url in urls)
                        {
                            if (url.Contains(subpick) == true)
                            {
                                charurl = url;
                                if (i < 8)
                                {
                                    awaychosenurls.Add(charurl);
                                }
                                else if (i >= 8)
                                {
                                    homechosenurls.Add(charurl);
                                }
                                Kritters.Remove(pick);
                                KritterCounter = KritterCounter + 1;
                                if (KritterCounter == pair.Value)
                                {
                                    slugCharacters.Remove(pair.Key);
                                }
                            }
                        }
                    }
                    else if (pair.Key == "Koopa_Troopa")
                    {
                        listindex = random.Next(Koopas.Count);
                        string pick = Koopas.ElementAt(listindex);
                        string subpick = $"MSS_{pick}_Character";
                        string charurl;
                        foreach (var url in urls)
                        {
                            if (url.Contains(subpick) == true)
                            {
                                charurl = url;
                                if (i < 8)
                                {
                                    awaychosenurls.Add(charurl);
                                }
                                else if (i >= 8)
                                {
                                    homechosenurls.Add(charurl);
                                }
                                Koopas.Remove(pick);
                                KoopaCounter = KoopaCounter + 1;
                                if (KoopaCounter == pair.Value)
                                {
                                    slugCharacters.Remove(pair.Key);
                                }
                            }
                        }
                    }
                    else if (pair.Key == "Paratroopa")
                    {
                        listindex = random.Next(Paratroopas.Count);
                        string pick = Paratroopas.ElementAt(listindex);
                        string subpick = $"MSS_{pick}_Character";
                        string charurl;
                        foreach (var url in urls)
                        {
                            if (url.Contains(subpick) == true)
                            {
                                charurl = url;
                                if (i < 8)
                                {
                                    awaychosenurls.Add(charurl);
                                }
                                else if (i >= 8)
                                {
                                    homechosenurls.Add(charurl);
                                }
                                Paratroopas.Remove(pick);
                                ParatroopaCounter = ParatroopaCounter + 1;
                                if (ParatroopaCounter == pair.Value)
                                {
                                    slugCharacters.Remove(pair.Key);
                                }
                            }
                        }
                    }
                    else if (pair.Key == "Magikoopa")
                    {
                        listindex = random.Next(Magikoopas.Count);
                        string pick = Magikoopas.ElementAt(listindex);
                        string subpick = $"MSS_{pick}_Character";
                        string charurl;
                        foreach (var url in urls)
                        {
                            if (url.Contains(subpick) == true)
                            {
                                charurl = url;
                                if (i < 8)
                                {
                                    awaychosenurls.Add(charurl);
                                }
                                else if (i >= 8)
                                {
                                    homechosenurls.Add(charurl);
                                }
                                Magikoopas.Remove(pick);
                                MagikoopaCounter = MagikoopaCounter + 1;
                                if (MagikoopaCounter == pair.Value)
                                {
                                    slugCharacters.Remove(pair.Key);
                                }
                            }
                        }
                    }
                    else if (pair.Key == "Bros")
                    {
                        listindex = random.Next(Bros.Count);
                        string pick = Bros.ElementAt(listindex);
                        string subpick = $"MSS_{pick}_Character";
                        string charurl;
                        foreach (var url in urls)
                        {
                            if (url.Contains(subpick) == true)
                            {
                                charurl = url;
                                if (i < 8)
                                {
                                    awaychosenurls.Add(charurl);
                                }
                                else if (i >= 8)
                                {
                                    homechosenurls.Add(charurl);
                                }
                                Bros.Remove(pick);
                                BrosCounter = BrosCounter + 1;
                                if (BrosCounter == pair.Value)
                                {
                                    slugCharacters.Remove(pair.Key);
                                }
                            }
                        }
                    }
                    else if (pair.Key == "Bones")
                    {
                        listindex = random.Next(Bones.Count);
                        string pick = Bones.ElementAt(listindex);
                        string subpick = $"MSS_{pick}_Character";
                        string charurl;
                        foreach (var url in urls)
                        {
                            if (url.Contains(subpick) == true)
                            {
                                charurl = url;
                                if (i < 8)
                                {
                                    awaychosenurls.Add(charurl);
                                }
                                else if (i >= 8)
                                {
                                    homechosenurls.Add(charurl);
                                }
                                Bones.Remove(pick);
                                BonesCounter = BonesCounter + 1;
                                if (BonesCounter == pair.Value)
                                {
                                    slugCharacters.Remove(pair.Key);
                                }
                            }
                        }
                    }
                    else if (pair.Key == "Shy_Guy")
                    {
                        listindex = random.Next(ShyGuys.Count);
                        string pick = ShyGuys.ElementAt(listindex);
                        string subpick = $"MSS_{pick}_Character";
                        string charurl;
                        foreach (var url in urls)
                        {
                            if (url.Contains(subpick) == true)
                            {
                                charurl = url;
                                if (i < 8)
                                {
                                    awaychosenurls.Add(charurl);
                                }
                                else if (i >= 8)
                                {
                                    homechosenurls.Add(charurl);
                                }
                                ShyGuys.Remove(pick);
                                ShyGuyCounter = ShyGuyCounter + 1;
                                if (ShyGuyCounter == pair.Value)
                                {
                                    slugCharacters.Remove(pair.Key);
                                }
                            }
                        }

                    }



                }
                else
                {
                    string pick = pair.Key;
                    string subpick = $"MSS_{pick}_Character";
                    string charurl;
                    foreach (var url in urls)
                    {
                        if (url.Contains(subpick) == true)
                        {
                            charurl = url;
                            if (i < 8)
                            {
                                awaychosenurls.Add(charurl);
                            }
                            else if (i >= 8)
                            {
                                homechosenurls.Add(charurl);
                            }

                        }
                    }
                    slugCharacters.Remove(pair.Key);
                }
                

            }
            for (int i = 0; i < 9; i++)
            {
                int index = random.Next(awaychosenurls.Count);
                string url = awaychosenurls.ElementAt(index);
                Uri uri = new Uri(url);
                BitmapImage picture = new BitmapImage(uri);

                awayteamimages[i].Source = picture;
                awaychosenurls.Remove(url);
            }
            for (int i = 0; i < 9; i++)
            {
                int index = random.Next(homechosenurls.Count);
                string url = homechosenurls.ElementAt(index);
                Uri uri = new Uri(url);
                BitmapImage picture = new BitmapImage(uri);

                hometeamimages[i].Source = picture;
                homechosenurls.Remove(url);
            }
        }
    }
}

