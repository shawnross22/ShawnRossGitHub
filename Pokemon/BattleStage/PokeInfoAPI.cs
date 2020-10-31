using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleStage
{
    public class PokeInfoAPI
    {
        public Sprites sprites { get; set; }
        public List<Stats> stats { get; set; }
        public List<Types> types { get; set; }
        public List<Moves> moves { get; set; }


    }

    public class Sprites
    {
        public string back_default { get; set; }
        public string front_default { get; set; }
    }

    public class Stats
    {
        public int base_stat { get; set; }

        public Stat stat { get; set; }
    }

    public class Stat
    {
        public string name { get; set; }
    }

    public class Types
    {
        public int slot { get; set; }

        public Type type { get; set; }
    }

    public class Type
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Moves
    {
        public Move move { get; set; }
        public List<Version_Group_Details> version_group_details { get; set; }
    }
    public class Move
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version_Group_Details
    {
        public int level_learned_at { get; set; }

        public Move_Learn_Method move_learn_method { get; set; }

        public Version_Group version_group { get; set; }
    }

    public class Move_Learn_Method
    {
        public string name;
    }

    public class Version_Group
    {
        public string name;
    }
}
