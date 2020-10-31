using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleStage
{
    public class TypeInfoAPI
    {
        public Damage_Relations damage_relations { get; set; }
    }

    public class Damage_Relations
    {
        public List<Type> double_damage_from { get; set; }
        public List<Type> double_damage_to { get; set; }
        public List<Type> half_damage_from { get; set; }
        public List<Type> half_damage_to { get; set; }
        public List<Type> no_damage_from { get; set; }
        public List<Type> no_damage_to { get; set; }
    }
}
