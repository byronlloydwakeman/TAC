using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TACDataManager.Library.Models;
using TACDataManager.Library.Models.Enums;

namespace TACUI.Library.Models
{
    public class AutoClickAPIModel
    {
        public int MinHealth { get; set; }
        public int MinMana { get; set; }
        public EnumArmor Armor { get; set; }
        public List<string> Accessories { get; set; }
        public EnumMount Mount { get; set; }
        public EnumMinion Minions { get; set; }
        public EnumGrapple Grapple { get; set; }
        public List<string> Potions { get; set; }
        public List<string> Buffs { get; set; }
        public List<string> Weapons { get; set; }
        public EnumBoss Boss { get; set; }
        public MoveModel SequenceOfMoves { get; set; }
    }
}
