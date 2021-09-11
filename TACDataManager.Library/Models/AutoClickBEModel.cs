using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TACDataManager.Library.Models.Enums;

namespace TACDataManager.Library.Models
{
    public class AutoClickBEModel
    {
        public int MinHealth { get; set; }
        public int MinMana { get; set; }
        public EnumArmor Armor { get; set; }
        public List<Enum> Accessories { get; set; }
        public EnumMount Mount { get; set; }
        public EnumMinion Minions { get; set; }
        public EnumGrapple Grapple { get; set; }
        public List<Enum> Potions { get; set; }
        public List<Enum> Buffs { get; set; }
        public List<Enum> Weapons { get; set; }
        public EnumBoss Boss { get; set; }
        public MoveModel SequenceOfMoves { get; set; }
    }
}
