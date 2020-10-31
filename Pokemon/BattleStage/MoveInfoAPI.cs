using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleStage
{
    public class MoveInfoAPI
    {
        public Nullable<int> accuracy { get; set; }
        public Damage_Class damage_class { get; set; }
        public Meta meta { get; set; }
        public string name { get; set; }
        public Nullable<int> power { get; set; }
        public int pp { get; set; }
        public int priority { get; set; }
        public List<Stat_Changes> stat_changes { get; set; }
        public Target target { get; set; }
        public Type type { get; set; }

        

    }

    public class Damage_Class
    {
        public string name { get; set; }
    }
    public class Meta
    {
        public Ailment ailment { get; set; }
        public int ailment_chance { get; set; }
        public int crit_chance { get; set; }
        public int drain { get; set; }
        public int flinch_chance { get; set; }
        public int healing { get; set; }
        public Nullable<int> max_hits { get; set; }
        public Nullable<int> max_turns { get; set; }
        public Nullable<int> min_hits { get; set; }
        public Nullable<int> min_turns { get; set; }
        public int stat_chance { get; set; }
    }
    public class Ailment
    {
        public string name { get; set; }
    }
    public class Stat_Changes
    {
        public int change { get; set; }
        public Stat stat { get; set; }
    }
    public class Target
    {
        public string name { get; set; }
    }
}
