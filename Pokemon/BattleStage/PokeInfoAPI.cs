using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleStage
{
    class PokeInfoAPI
    {
        public Sprites sprites { get; set; }
        public List<Stats> stats { get; set; }
        public List<Types> types { get; set; }

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
    }
}
