using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BattleStage
{
    public class StatsCalculation
    {
        public int Level { get; set; }
        public int BaseHP { get; set; }
        public int BaseAttack { get; set; }
        public int BaseDefense { get; set; }
        public int BaseSpecialAttack { get; set; }
        public int BaseSpecialDefense { get; set; }
        public int BaseSpeed {get; set;}
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
        

        public string Nature { get; set; }

        public StatsCalculation()
        {
            Level = 50;
            BaseHP = 0;
            BaseAttack = 0;
            BaseDefense = 0;
            BaseSpecialAttack = 0;
            BaseSpecialDefense = 0;
            BaseSpeed = 0;
            HP = 0;
            Attack = 0;
            Defense = 0;
            SpecialAttack = 0;
            SpecialDefense = 0;
            Speed = 0;

            Nature = "";
        }

        public string GetNature()
        {
            Random random = new Random();
            List<string> natures = new List<string>();
            natures.Add("Hardy");
            natures.Add("Lonely");
            natures.Add("Brave");
            natures.Add("Adamant");
            natures.Add("Naughty");
            natures.Add("Docile");
            natures.Add("Bold");
            natures.Add("Relaxed");
            natures.Add("Impish");
            natures.Add("Lax");
            natures.Add("Serious");
            natures.Add("Timid");
            natures.Add("Hasty");
            natures.Add("Jolly");
            natures.Add("Naive");
            natures.Add("Bashful");
            natures.Add("Modest");
            natures.Add("Mild");
            natures.Add("Quiet");
            natures.Add("Rash");
            natures.Add("Quirky");
            natures.Add("Calm");
            natures.Add("Gentle");
            natures.Add("Sassy");
            natures.Add("Careful");
            int index = random.Next(natures.Count);
            string nature = natures.ElementAt(index);
            return nature;
        }

        public int[] GetEVs()
        {
            
            Dictionary<string, int> EVSpread = new Dictionary<string, int>();
            Random random = new Random();
            List<string> stats = new List<string>();
            stats.Add("HP");
            stats.Add("Attack");
            stats.Add("Defense");
            stats.Add("Special Attack");
            stats.Add("Special Defense");
            stats.Add("Speed");
            int maximum = 0;
            int E = 0;
            

            for (int i = 0; i < 5; i++)
            {
                int index = random.Next(stats.Count);
                string statname = stats.ElementAt(index);
                stats.Remove(statname);
                int EV = random.Next(0, 252);
                maximum = maximum + EV;
                if (maximum <= 510)
                {
                    E = EV / 4;
                    EVSpread.Add(statname, E);
                }
                else if (maximum > 510)
                {
                    EV = EV-(maximum - 510);
                    maximum = 510;
                    E = EV / 4;
                    EVSpread.Add(statname, E);
                }
            }
           
            int HPE=0;
            int AttackE=0;
            int DefenseE=0;
            int SpecialAttackE=0;
            int SpecialDefenseE=0;
            int SpeedE=0;
            foreach (var Spread in EVSpread)
            {
                if (Spread.Key=="HP")
                {
                    HPE = Spread.Value;
                }
                else if (Spread.Key=="Attack")
                {
                    AttackE = Spread.Value;
                }
                else if (Spread.Key == "Defense")
                {
                    DefenseE = Spread.Value;
                }
                else if (Spread.Key == "Special Attack")
                {
                    SpecialAttackE = Spread.Value;
                }
                else if (Spread.Key == "Special Defense")
                {
                    SpecialDefenseE = Spread.Value;
                }
                else if (Spread.Key == "Speed")
                {
                    SpeedE = Spread.Value;
                }
                
            }
            int[] EVs = new int[] { HPE, AttackE, DefenseE, SpecialAttackE, SpecialDefenseE, SpeedE };
            
            return EVs;
        }
            
        

        public int[] CalculateStats()
        {
            
            Random random = new Random();
            int HPIV = random.Next(0, 31);
            int[] evs = GetEVs();
            int HPEV = evs[0];
            double unroundedHP = (2 * BaseHP + HPIV + HPEV) * Level / 100 + Level + 10;
            int HP = Convert.ToInt32(Math.Round(unroundedHP, 0));
            int AttackIV = random.Next(0, 31);
            int AttackEV = evs[1];
            double unroundedAttack = (2*BaseAttack + AttackIV + AttackEV)*Level/100+5;
            int Attack = Convert.ToInt32(Math.Round(unroundedAttack, 0));
            int DefenseIV = random.Next(0, 31);
            int DefenseEV = evs[2];
            double unroundedDefense = (2 * BaseDefense + DefenseIV + DefenseEV) * Level / 100 + 5;
            int Defense = Convert.ToInt32(Math.Round(unroundedDefense, 0));
            int SpecialAttackIV = random.Next(0, 31);
            int SpecialAttackEV = evs[3];
            double unroundedSpecialAttack = (2 * BaseSpecialAttack + SpecialAttackIV + SpecialAttackEV) * Level / 100 + 5;
            int SpecialAttack = Convert.ToInt32(Math.Round(unroundedSpecialAttack, 0));
            int SpecialDefenseIV = random.Next(0, 31);
            int SpecialDefenseEV = evs[4];
            double unroundedSpecialDefense = (2 * BaseSpecialDefense + SpecialDefenseIV + SpecialDefenseEV) * Level / 100 + 5;
            int SpecialDefense = Convert.ToInt32(Math.Round(unroundedSpecialDefense, 0));
            int SpeedIV = random.Next(0, 31);
            int SpeedEV = evs[5];
            double unroundedSpeed = (2 * BaseSpeed + SpeedIV + SpeedEV) * Level / 100 + 5;
            int Speed = Convert.ToInt32(Math.Round(unroundedSpeed, 0));

            if (Nature=="Lonely")
            {
                Attack = Convert.ToInt32(Attack*1.1);
                Defense = Convert.ToInt32(Defense * 0.9);
            }
            else if (Nature == "Brave")
            {
                Attack = Convert.ToInt32(Attack * 1.1);
                Speed = Convert.ToInt32(Speed * 0.9);
            }
            else if (Nature == "Adamant")
            {
                Attack = Convert.ToInt32(Attack * 1.1);
                SpecialAttack = Convert.ToInt32(SpecialAttack * 0.9);
            }
            else if (Nature == "Naughty")
            {
                Attack = Convert.ToInt32(Attack * 1.1);
                SpecialDefense = Convert.ToInt32(SpecialDefense * 0.9);
            }
            else if (Nature == "Bold")
            {
                Defense = Convert.ToInt32(Defense * 1.1);
                Attack = Convert.ToInt32(Attack * 0.9);
            }
            else if (Nature == "Relaxed")
            {
                Defense = Convert.ToInt32(Defense * 1.1);
                Speed = Convert.ToInt32(Speed * 0.9);
            }
            else if (Nature == "Impish")
            {
                Defense = Convert.ToInt32(Defense * 1.1);
                SpecialAttack = Convert.ToInt32(SpecialAttack * 0.9);
            }
            else if (Nature == "Lax")
            {
                Defense = Convert.ToInt32(Defense * 1.1);
                SpecialDefense = Convert.ToInt32(SpecialDefense * 0.9);
            }
            else if (Nature == "Timid")
            {
                Speed = Convert.ToInt32(Speed * 1.1);
                Attack = Convert.ToInt32(Attack * 0.9);
            }
            else if (Nature == "Hasty")
            {
                Speed = Convert.ToInt32(Speed * 1.1);
                Defense = Convert.ToInt32(Defense * 0.9);
            }
            else if (Nature == "Jolly")
            {
                Speed = Convert.ToInt32(Speed * 1.1);
                SpecialAttack = Convert.ToInt32(SpecialAttack * 0.9);
            }
            else if (Nature == "Naive")
            {
                Speed = Convert.ToInt32(Speed * 1.1);
                SpecialDefense = Convert.ToInt32(SpecialDefense* 0.9);
            }
            else if (Nature == "Modest")
            {
                SpecialAttack = Convert.ToInt32(SpecialAttack * 1.1);
                Attack = Convert.ToInt32(Attack * 0.9);
            }
            else if (Nature == "Mild")
            {
                SpecialAttack = Convert.ToInt32(Defense * 1.1);
                Defense = Convert.ToInt32(Defense * 0.9);
            }
            else if (Nature == "Quiet")
            {
                SpecialAttack = Convert.ToInt32(SpecialAttack * 1.1);
                Speed = Convert.ToInt32(Speed * 0.9);
            }
            else if (Nature == "Rash")
            {
                SpecialAttack = Convert.ToInt32(SpecialAttack * 1.1);
                SpecialDefense = Convert.ToInt32(SpecialDefense * 0.9);
            }
            else if (Nature == "Calm")
            {
                SpecialDefense = Convert.ToInt32(SpecialDefense * 1.1);
                Attack = Convert.ToInt32(Attack * 0.9);
            }
            else if (Nature == "Gentle")
            {
                SpecialDefense = Convert.ToInt32(SpecialDefense * 1.1);
                Defense = Convert.ToInt32(Defense * 0.9);
            }
            else if (Nature == "Sassy")
            {
                SpecialDefense = Convert.ToInt32(SpecialDefense * 1.1);
                Speed = Convert.ToInt32(Speed * 0.9);
            }
            else if (Nature == "Careful")
            {
                SpecialDefense = Convert.ToInt32(SpecialDefense * 1.1);
                SpecialAttack = Convert.ToInt32(SpecialAttack * 0.9);
            }

            int[] Stats = { HP, Attack, Defense, SpecialAttack, SpecialDefense, Speed };
            return Stats;
        }
        
            
    }

}
