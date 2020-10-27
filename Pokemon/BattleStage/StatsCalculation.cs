using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BattleStage
{
    class StatsCalculation
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

            foreach (var stat in stats)
            {
                int index = random.Next(stats.Count);
                string statname = stats.ElementAt(index);
                int value = random.Next(0, 252);
                maximum = maximum + value;
                if (maximum<=510)
                {
                    int E = value / 4;
                    EVSpread.Add(statname, E);
                }
                else if (maximum>510)
                {
                    int E = 0;
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
            
        

        public int CalculateHP()
        {
            StatsCalculation stats = new StatsCalculation();
            Random random = new Random();
            int iv = random.Next(0, 31);
            int[] evs = GetEVs();
            int ev = evs[0];
            double unroundedHP = (2 * stats.BaseHP + iv + ev) * stats.Level / 100 + stats.Level + 10;
            int HP = Convert.ToInt32(Math.Round(unroundedHP, 0));


            return HP;
        }
    }

}
