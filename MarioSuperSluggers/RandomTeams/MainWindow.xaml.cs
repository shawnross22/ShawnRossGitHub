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
            string marioimg = "https://www.mariowiki.com/images/e/e4/MSS_Mario_Character_Select_Sprite.png";
            string luigiimg = "https://www.mariowiki.com/images/5/50/MSS_Luigi_Character_Select_Sprite_1.png";
            string peachimg = "https://www.mariowiki.com/images/f/f4/MSS_Peach_Character_Select_Sprite.png";
            string daisyimg = "https://www.mariowiki.com/images/3/3e/MSS_Daisy_Character_Select_Sprite.png";
            string yoshiimg = "https://www.mariowiki.com/images/5/5b/MSS_Yoshi_Character_Select_Sprite.png";
            string blueyoshiimg = "https://www.mariowiki.com/images/6/6a/MSS_Blue_Yoshi_Character_Select_Sprite.png";
            string lightblueyoshiimg = "https://www.mariowiki.com/images/5/56/MSS_Light-Blue_Yoshi_Character_Select_Sprite.png";
            string pinkyoshiimg = "https://www.mariowiki.com/images/9/94/MSS_Pink_Yoshi_Character_Select_Sprite.png";
            string redyoshiimg = "https://www.mariowiki.com/images/3/34/MSS_Red_Yoshi_Character_Select_Sprite.png";
            string yellowyoshiimg = "https://www.mariowiki.com/images/6/6c/MSS_Yellow_Yoshi_Character_Select_Sprite.png";
            string birdoimg = "https://www.mariowiki.com/images/6/69/MSS_Birdo_Character_Select_Sprite.png";
            string warioimg = "https://www.mariowiki.com/images/9/96/MSS_Wario_Character_Select_Sprite.png";
            string waluigiimg = "https://www.mariowiki.com/images/9/9e/MSS_Waluigi_Character_Select_Sprite_1.png";
            string donkeykongimg = "https://www.mariowiki.com/images/c/c5/MSS_Donkey_Kong_Character_Select_Sprite.png";
            string diddykongimg = "https://www.mariowiki.com/images/6/61/MSS_Diddy_Kong_Character_Select_Sprite.png";
            string bowserimg = "https://www.mariowiki.com/images/5/5e/MSS_Bowser_Character_Select_Sprite.png";
            string boswerjrimg = "https://www.mariowiki.com/images/3/34/MSS_Bowser_Jr_Character_Select_Sprite.png";
            string babymarioimg = "https://www.mariowiki.com/images/8/8b/MSS_Baby_Mario_Character_Select_Sprite.png";
            string babyluigiimg = "https://www.mariowiki.com/images/1/1c/MSS_Baby_Luigi_Character_Select_Sprite_1.png";
            string babypeachimg = "https://www.mariowiki.com/images/4/49/MSS_Baby_Peach_Character_Select_Sprite_1.png";
            string babydaisyimg = "https://www.mariowiki.com/images/7/72/MSS_Baby_Daisy_Character_Select_Sprite_1.png";
            string babydkimg = "https://www.mariowiki.com/images/e/ef/MSS_Baby_Donkey_Kong_Character_Select_Sprite_1.png";
            string redtoadimg = "https://www.mariowiki.com/images/6/62/MSS_Red_Toad_Character_Select_Sprite.png";
            string bluetoadimg = "https://www.mariowiki.com/images/4/48/MSS_Blue_Toad_Character_Select_Sprite.png";
            string greentoadimg = "https://www.mariowiki.com/images/c/ca/MSS_Green_Toad_Character_Select_Sprite.png";
            string purpletoadimg = "https://www.mariowiki.com/images/6/67/MSS_Purple_Toad_Character_Select_Sprite.png";
            string yellowtoadimg = "https://www.mariowiki.com/images/e/e9/MSS_Yellow_Toad_Character_Select_Sprite.png";
            string toadetteimg = "https://www.mariowiki.com/images/8/87/MSS_Toadette_Character_Select_Sprite.png";
            string toadsworthimg = "https://www.mariowiki.com/images/5/5f/MSS_Toadsworth_Character_Select_Sprite.png";
            string bluepiantaimg = "https://www.mariowiki.com/images/0/05/MSS_Blue_Pianta_Character_Select_Sprite.png";
            string redpiantaimg = "https://www.mariowiki.com/images/d/d9/MSS_Red_Pianta_Character_Select_Sprite.png";
            string yellowpiantaimg = "https://www.mariowiki.com/images/e/ef/MSS_Yellow_Pianta_Character_Select_Sprite.png";
            string bluenokiimg = "https://www.mariowiki.com/images/8/8a/MSS_Blue_Noki_Character_Select_Sprite.png";
            string greennokiimg = "https://www.mariowiki.com/images/5/5e/MSS_Green_Noki_Character_Select_Sprite.png";
            string rednokiimg = "https://www.mariowiki.com/images/f/f0/MSS_Red_Noki_Character_Select_Sprite.png";
            string dixiekongimg = "https://www.mariowiki.com/images/e/e1/MSS_Dixie_Kong_Character_Select_Sprite_1.png";
            string funkykongimg = "https://www.mariowiki.com/images/9/93/MSS_Funky_Kong_Character_Select_Sprite.png";
            string tinykongimg = "https://www.mariowiki.com/images/8/84/MSS_Tiny_Kong_Character_Select_Sprite.png";
            string kingkroolimg = "https://www.mariowiki.com/images/c/c2/MSS_King_K_Rool_Character_Select_Sprite_1.png";
            string kritterimg = "https://www.mariowiki.com/images/6/61/MSS_Green_Kritter_Character_Select_Sprite.png";
            string bluekritterimg = "https://www.mariowiki.com/images/f/f4/MSS_Blue_Kritter_Character_Select_Sprite.png";
            string brownkritterimg = "https://www.mariowiki.com/images/0/0c/MSS_Brown_Kritter_Character_Select_Sprite.png";
            string redkritterimg = "https://www.mariowiki.com/images/b/b7/MSS_Red_Kritter_Character_Select_Sprite.png";
            string goombaimg = "https://www.mariowiki.com/images/f/ff/MSS_Goomba_Character_Select_Sprite.png";
            string paragoombaimg = "https://www.mariowiki.com/images/7/70/MSS_Paragoomba_Character_Select_Sprite.png";
            string redkoopatroopaimg = "https://www.mariowiki.com/images/3/36/MSS_Red_Koopa_Troopa_Character_Select_Sprite.png";
            string greenkoopatroopaimg = "https://www.mariowiki.com/images/a/ac/MSS_Green_Koopa_Troopa_Character_Select_Sprite.png";
            string redparatroopaimg = "https://www.mariowiki.com/images/9/9c/MSS_Red_Koopa_Paratroopa_Character_Select_Sprite.png";
            string greenparatroopaimg = "https://www.mariowiki.com/images/a/ac/MSS_Green_Koopa_Troopa_Character_Select_Sprite.png";
            string magikoopaimg = "https://www.mariowiki.com/images/3/34/MSS_Blue_Magikoopa_Character_Select_Sprite.png";
            string greenmagikoopaimg = "https://www.mariowiki.com/images/7/70/MSS_Green_Magikoopa_Character_Select_Sprite.png";
            string redmagikoopaimg = "https://www.mariowiki.com/images/2/2f/MSS_Red_Magikoopa_Character_Select_Sprite.png";
            string yellowmagikoopaimg = "https://www.mariowiki.com/images/e/e9/MSS_Yellow_Magikoopa_Character_Select_Sprite.png";
            string hammerbroimg = "https://www.mariowiki.com/images/a/a4/MSS_Hammer_Bro_Character_Select_Sprite.png";
            string firebroimg = "https://www.mariowiki.com/images/c/ce/MSS_Fire_Bro_Character_Select_Sprite.png";
            string boomerangbroimg = "https://www.mariowiki.com/images/6/66/MSS_Boomerang_Bro_Character_Select_Sprite.png";
            string drybonesimg = "https://www.mariowiki.com/images/d/d2/MSS_Dry_Bones_Character_Select_Sprite.png";
            string darkbonesimg = "https://www.mariowiki.com/images/6/68/MSS_Dark_Bones_Character_Select_Sprite.png";
            string bluedrybonesimg = "https://www.mariowiki.com/images/2/23/MSS_Blue_Dry_Bones_Character_Select_Sprite.png";
            string greendrybonesimg = "https://www.mariowiki.com/images/6/66/MSS_Green_Dry_Bones_Character_Select_Sprite.png";
            string booimg = "https://www.mariowiki.com/images/c/ca/MSS_Boo_Character_Select_Sprite.png";
            string kingbooimg = "https://www.mariowiki.com/images/7/74/MSS_King_Boo_Character_Select_Sprite.png";
            string peteypiranhaimg = "https://www.mariowiki.com/images/0/05/MSS_Petey_Piranha_Character_Select_Sprite.png";
            string wigglerimg = "https://www.mariowiki.com/images/8/81/MSS_Wiggler_Character_Select_Sprite.png";
            string blueshyguyimg = "https://www.mariowiki.com/images/0/0a/MSS_Blue_Shy_Guy_Character_Select_Sprite.png";
            string grayshyguyimg = "https://www.mariowiki.com/images/7/7f/MSS_Gray_Shy_Guy_Character_Select_Sprite.png";
            string greenshyguyimg = "https://www.mariowiki.com/images/f/f2/MSS_Green_Shy_Guy_Character_Select_Sprite.png";
            string redshyguyimg = "https://www.mariowiki.com/images/0/0c/MSS_Red_Shy_Guy_Character_Select_Sprite.png";
            string yellowshyguyimg = "https://www.mariowiki.com/images/7/71/MSS_Yellow_Shy_Guy_Character_Select_Sprite.png";
            string montymoleimg = "https://www.mariowiki.com/images/e/e1/MSS_Monty_Mole_Character_Select_Sprite.png";
            string blooperimg = "https://www.mariowiki.com/images/8/86/MSS_Blooper_Character_Select_Sprite.png";

            Dictionary<string, int> slugCharacters = new Dictionary<string, int>();
            slugCharacters.Add("Mario", 1);
            slugCharacters.Add("Luigi", 1);
            slugCharacters.Add("Peach", 1);
            slugCharacters.Add("Daisy", 1);
            slugCharacters.Add("Yoshi", 6);
            slugCharacters.Add("Birdo", 1);
            slugCharacters.Add("Wario", 1);
            slugCharacters.Add("Waluigi", 1);
            slugCharacters.Add("Donkey Kong", 1);
            slugCharacters.Add("Diddy Kong", 1);
            slugCharacters.Add("Bowser", 1);
            slugCharacters.Add("Bowser Jr", 1);
            slugCharacters.Add("Baby Mario", 1);
            slugCharacters.Add("Baby Luigi", 1);
            slugCharacters.Add("Baby Peach", 1);
            slugCharacters.Add("Baby Daisy", 1);
            slugCharacters.Add("Baby DK", 1);
            slugCharacters.Add("Toad", 5);
            slugCharacters.Add("Toadette", 1);
            slugCharacters.Add("Toadsworth", 1);
            slugCharacters.Add("Pianta", 3);
            slugCharacters.Add("Noki", 3);
            slugCharacters.Add("Dixie Kong", 1);
            slugCharacters.Add("Funky Kong", 1);
            slugCharacters.Add("Tiny Kong", 1);
            slugCharacters.Add("King K Rool", 1);
            slugCharacters.Add("Kritter", 4);
            slugCharacters.Add("Goomba", 1);
            slugCharacters.Add("Paragoomba", 1);
            slugCharacters.Add("Koopa Troopa", 2);
            slugCharacters.Add("Paratroopa", 2);
            slugCharacters.Add("Magikoopa", 4);
            slugCharacters.Add("Bros", 3);
            slugCharacters.Add("Bones", 4);
            slugCharacters.Add("Boo", 1);
            slugCharacters.Add("King Boo", 1);
            slugCharacters.Add("Petey Piranha", 1);
            slugCharacters.Add("Wiggler", 1);
            slugCharacters.Add("Shy Guy", 5);
            slugCharacters.Add("Monty Mole", 1);
            slugCharacters.Add("Blooper", 1);

            List<string> Yoshis = new List<string>();
            Yoshis.Add("Yoshi");
            Yoshis.Add("Red Yoshi");
            Yoshis.Add("Blue Yoshi");
            Yoshis.Add("Yellow Yoshi");
            Yoshis.Add("Light Blue Yoshi");
            Yoshis.Add("Pink Yoshi");

            List<string> Toads = new List<string>();
            Toads.Add("Red Toad");
            Toads.Add("Blue Toad");
            Toads.Add("Yellow Toad");
            Toads.Add("Green Toad");
            Toads.Add("Purple Toad");

            List<string> Piantas = new List<string>();
            Piantas.Add("Blue Pianta");
            Piantas.Add("Red Pianta");
            Piantas.Add("Yellow Pianta");

            List<string> Nokis = new List<string>();
            Nokis.Add("Blue Noki");
            Nokis.Add("Red Noki");
            Nokis.Add("Green Noki");

            List<string> Kritters = new List<string>();
            Kritters.Add("Kritter");
            Kritters.Add("Blue Kritter");
            Kritters.Add("Red Kritter");
            Kritters.Add("Brown Kritter");

            List<string> Koopas = new List<string>();
            Koopas.Add("Green Koopa Troopa");
            Koopas.Add("Red Koopa Troopa");

            List<string> Paratroopas = new List<string>();
            Paratroopas.Add("Red Paratroopa");
            Paratroopas.Add("Green Paratrooopa");

            List<string> Magikoopas = new List<string>();
            Magikoopas.Add("Magikoopa");
            Magikoopas.Add("Red Magikoopa");
            Magikoopas.Add("Green Magikoopa");
            Magikoopas.Add("Yellow Magikoopa");

            List<string> Bros = new List<string>();
            Bros.Add("Hammer Bro");
            Bros.Add("Fire Bro");
            Bros.Add("Boomerang Bro");

            List<string> Bones = new List<string>();
            Bones.Add("Dry Bones");
            Bones.Add("Green Dry Bones");
            Bones.Add("Dark Bones");
            Bones.Add("Blue Dry Bones");

            List<string> ShyGuys = new List<string>();
            ShyGuys.Add("Shy Guy");
            ShyGuys.Add("Blue Shy Guy");
            ShyGuys.Add("Yellow Shy Guy");
            ShyGuys.Add("Green Shy Guy");
            ShyGuys.Add("Gray Shy Guy");

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
            Captains.Add("Bowser Jr");
            Captains.Add("Donkey Kong");
            Captains.Add("Diddy Kong");

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
            for (int i = 0; i < 2; i++)
            {
                int index = random.Next(Captains.Count);
                string captain = Captains.ElementAt(index);
                string captaintrimmed = String.Concat(captain.Where(c => !Char.IsWhiteSpace(c)));
                string url = $"{captaintrimmed.ToLower()}url";
                Uri uri = new Uri(url);
                BitmapImage picture = new BitmapImage(uri);
                if (i==0)
                {
                    awayteamimages[i].Source = picture;
                }
                else if (i == 1)
                {
                    hometeamimages[i - 1].Source = picture;
                }
                if (captain == "Yoshi")
                {
                    Yoshis.Remove(captain);
                    slugCharacters.Remove(captain);
                }
                else
                {
                    slugCharacters.Remove(captain);
                }
            }
            for (int i = 0; i < 16; i++)
            {
                int listindex;
                int index = random.Next(slugCharacters.Count);
                KeyValuePair<string, int> pair = slugCharacters.ElementAt(index);
                if (pair.Value>1)
                {
                    if (pair.Key == "Yoshi")
                    {
                        listindex = random.Next(Yoshis.Count);
                        string pick = Yoshis.ElementAt(index);
                        string picktrimmed = String.Concat(pick.Where(c => !Char.IsWhiteSpace(c)));
                        string url = $"{picktrimmed.ToLower()}url";
                        Uri uri = new Uri(url);
                        BitmapImage picture = new BitmapImage(uri);

                        if (i<8)
                        {
                            awayteamimages[i+1].Source = picture;
                        }
                        else if (i>=8)
                        {
                            hometeamimages[i - 7].Source = picture;
                        }
                        awayteamimages[i].Source = picture;
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
                        string pick = Yoshis.ElementAt(index);
                        string picktrimmed = String.Concat(pick.Where(c => !Char.IsWhiteSpace(c)));
                        string url = $"{picktrimmed.ToLower()}url";
                        Uri uri = new Uri(url);
                        BitmapImage picture = new BitmapImage(uri);

                        if (i < 8)
                        {
                            awayteamimages[i+1].Source = picture;
                        }
                        else if (i >= 8)
                        {
                            hometeamimages[i - 7].Source = picture;
                        }
                        Toads.Remove(pick);
                        ToadCounter = ToadCounter + 1;
                        if (ToadCounter == pair.Value)
                        {
                            slugCharacters.Remove(pair.Key);
                        }
                    }
                    else if (pair.Key == "Pianta")
                    {
                        listindex = random.Next(Piantas.Count);
                        string pick = Yoshis.ElementAt(index);
                        string picktrimmed = String.Concat(pick.Where(c => !Char.IsWhiteSpace(c)));
                        string url = $"{picktrimmed.ToLower()}url";
                        Uri uri = new Uri(url);
                        BitmapImage picture = new BitmapImage(uri);

                        if (i < 8)
                        {
                            awayteamimages[i+1].Source = picture;
                        }
                        else if (i >= 8)
                        {
                            hometeamimages[i - 7].Source = picture;
                        }
                        Piantas.Remove(pick); 
                        PiantaCounter = PiantaCounter + 1;
                        if (PiantaCounter == pair.Value)
                        {
                            slugCharacters.Remove(pair.Key);
                        }
                    }
                    else if (pair.Key == "Noki")
                    {
                        listindex = random.Next(Nokis.Count);
                        string pick = Yoshis.ElementAt(index);
                        string picktrimmed = String.Concat(pick.Where(c => !Char.IsWhiteSpace(c)));
                        string url = $"{picktrimmed.ToLower()}url";
                        Uri uri = new Uri(url);
                        BitmapImage picture = new BitmapImage(uri);

                        if (i < 8)
                        {
                            awayteamimages[i+1].Source = picture;
                        }
                        else if (i >= 8)
                        {
                            hometeamimages[i - 7].Source = picture;
                        }
                        Nokis.Remove(pick);
                        NokiCounter = NokiCounter + 1;
                        if (NokiCounter == pair.Value)
                        {
                            slugCharacters.Remove(pair.Key);
                        }
                    }
                    else if (pair.Key == "Kritter")
                    {
                        listindex = random.Next(Kritters.Count);
                        string pick = Yoshis.ElementAt(index);
                        string picktrimmed = String.Concat(pick.Where(c => !Char.IsWhiteSpace(c)));
                        string url = $"{picktrimmed.ToLower()}url";
                        Uri uri = new Uri(url);
                        BitmapImage picture = new BitmapImage(uri);

                        if (i < 8)
                        {
                            awayteamimages[i+1].Source = picture;
                        }
                        else if (i >= 8)
                        {
                            hometeamimages[i - 7].Source = picture;
                        }
                        Kritters.Remove(pick);
                        KritterCounter = KritterCounter + 1;
                        if (KritterCounter == pair.Value)
                        {
                            slugCharacters.Remove(pair.Key);
                        }
                    }
                    else if (pair.Key == "Koopa Troopa")
                    {
                        listindex = random.Next(Koopas.Count);
                        string pick = Yoshis.ElementAt(index);
                        string picktrimmed = String.Concat(pick.Where(c => !Char.IsWhiteSpace(c)));
                        string url = $"{picktrimmed.ToLower()}url";
                        Uri uri = new Uri(url);
                        BitmapImage picture = new BitmapImage(uri);

                        if (i < 8)
                        {
                            awayteamimages[i+1].Source = picture;
                        }
                        else if (i >= 8)
                        {
                            hometeamimages[i - 7].Source = picture;
                        }
                        Koopas.Remove(pick);
                        KoopaCounter = KoopaCounter + 1;
                        if (KoopaCounter == pair.Value)
                        {
                            slugCharacters.Remove(pair.Key);
                        }
                    }
                    else if (pair.Key == "Paratroopa")
                    {
                        listindex = random.Next(Paratroopas.Count);
                        string pick = Yoshis.ElementAt(index);
                        string picktrimmed = String.Concat(pick.Where(c => !Char.IsWhiteSpace(c)));
                        string url = $"{picktrimmed.ToLower()}url";
                        Uri uri = new Uri(url);
                        BitmapImage picture = new BitmapImage(uri);

                        if (i < 8)
                        {
                            awayteamimages[i+1].Source = picture;
                        }
                        else if (i >= 8)
                        {
                            hometeamimages[i - 7].Source = picture;
                        }
                        Paratroopas.Remove(pick);
                        ParatroopaCounter = ParatroopaCounter + 1;
                        if (ParatroopaCounter == pair.Value)
                        {
                            slugCharacters.Remove(pair.Key);
                        }
                    }
                    else if (pair.Key == "Magikoopa")
                    {
                        listindex = random.Next(Magikoopas.Count);
                        string pick = Yoshis.ElementAt(index);
                        string picktrimmed = String.Concat(pick.Where(c => !Char.IsWhiteSpace(c)));
                        string url = $"{picktrimmed.ToLower()}url";
                        Uri uri = new Uri(url);
                        BitmapImage picture = new BitmapImage(uri);

                        if (i < 8)
                        {
                            awayteamimages[i+1].Source = picture;
                        }
                        else if (i >= 8)
                        {
                            hometeamimages[i - 7].Source = picture;
                        }
                        Magikoopas.Remove(pick);
                        MagikoopaCounter = MagikoopaCounter + 1;
                        if (MagikoopaCounter == pair.Value)
                        {
                            slugCharacters.Remove(pair.Key);
                        }
                    }
                    else if (pair.Key == "Bros")
                    {
                        listindex = random.Next(Bros.Count);
                        string pick = Yoshis.ElementAt(index);
                        string picktrimmed = String.Concat(pick.Where(c => !Char.IsWhiteSpace(c)));
                        string url = $"{picktrimmed.ToLower()}url";
                        Uri uri = new Uri(url);
                        BitmapImage picture = new BitmapImage(uri);

                        if (i < 8)
                        {
                            awayteamimages[i+1].Source = picture;
                        }
                        else if (i >= 8)
                        {
                            hometeamimages[i - 7].Source = picture;
                        }
                        Bros.Remove(pick); 
                        BrosCounter = BrosCounter + 1;
                        if (BrosCounter == pair.Value)
                        {
                            slugCharacters.Remove(pair.Key);
                        }
                    }
                    else if (pair.Key == "Bones")
                    {
                        listindex = random.Next(Bones.Count);
                        string pick = Yoshis.ElementAt(index);
                        string picktrimmed = String.Concat(pick.Where(c => !Char.IsWhiteSpace(c)));
                        string url = $"{picktrimmed.ToLower()}url";
                        Uri uri = new Uri(url);
                        BitmapImage picture = new BitmapImage(uri);

                        if (i < 8)
                        {
                            awayteamimages[i+1].Source = picture;
                        }
                        else if (i >= 8)
                        {
                            hometeamimages[i - 7].Source = picture;
                        }
                        Bones.Remove(pick);
                        BonesCounter = BonesCounter + 1;
                        if (BonesCounter == pair.Value)
                        {
                            slugCharacters.Remove(pair.Key);
                        }
                    }
                    else if (pair.Key == "Shy Guy")
                    {
                        listindex = random.Next(ShyGuys.Count);
                        string pick = Yoshis.ElementAt(index);
                        string picktrimmed = String.Concat(pick.Where(c => !Char.IsWhiteSpace(c)));
                        string url = $"{picktrimmed.ToLower()}url";
                        Uri uri = new Uri(url);
                        BitmapImage picture = new BitmapImage(uri);

                        if (i < 8)
                        {
                            awayteamimages[i+1].Source = picture;
                        }
                        else if (i >= 8)
                        {
                            hometeamimages[i - 7].Source = picture;
                        }
                        ShyGuys.Remove(pick);
                        ShyGuyCounter = ShyGuyCounter + 1;
                        if (ShyGuyCounter == pair.Value)
                        {
                            slugCharacters.Remove(pair.Key);
                        }
                    }
                    
                }
                else if (pair.Value == 1)
                {
                    string pick = pair.Key;
                    string picktrimmed = String.Concat(pick.Where(c => !Char.IsWhiteSpace(c)));
                    string url = $"{picktrimmed.ToLower()}url";
                    Uri uri = new Uri(url);
                    BitmapImage picture = new BitmapImage(uri);

                    if (i < 8)
                    {
                        awayteamimages[i+1].Source = picture;
                    }
                    else if (i >= 8)
                    {
                        hometeamimages[i - 7].Source = picture;
                    }
                    slugCharacters.Remove(pair.Key);
                }
            }
        }
    }
}
