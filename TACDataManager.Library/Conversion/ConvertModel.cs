using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TACDataManager.Library.Models;
using TACDataManager.Library.Models.Enums;

namespace TACDataManager.Library.Conversion
{
    public class ConvertModel : IConvertModel
    {
        private readonly IConvertEnum _convertEnum;
        private readonly IConvertString _convertString;
        private readonly IConvertInt _convertInt;

        public ConvertModel(IConvertEnum convertEnum, IConvertString convertString, IConvertInt convertInt)
        {
            _convertEnum = convertEnum;
            _convertString = convertString;
            _convertInt = convertInt;
        }

        public AutoClickDBModel ConvertToDBModel(AutoClickAPIModel model)
        {
            AutoClickDBModel toReturn = new AutoClickDBModel();

            //Map health and mana over as theyre the same type
            toReturn.MinHealth = model.MinHealth;
            toReturn.MinMana = model.MinMana;

            //Convert the list of enums to strings
            toReturn.Accessories = _convertString.ConvertListOfStringToString(model.Accessories);
            toReturn.Potions = _convertString.ConvertListOfStringToString(model.Potions);
            toReturn.Buffs = _convertString.ConvertListOfStringToString(model.Buffs);
            toReturn.Weapons = _convertString.ConvertListOfStringToString(model.Weapons);

            //Convert the enums to strings
            toReturn.Armor = model.Armor.ToString();
            toReturn.Mount = model.Mount.ToString();
            toReturn.Minions = model.Minions.ToString();
            toReturn.Grapple = model.Grapple.ToString();
            toReturn.Boss = model.Boss.ToString();

            //Convert the list of string to strings
            toReturn.SequenceOfMoves = _convertString.ConvertListOfStringToString(model.SequenceOfMoves.Moves);
            toReturn.Timing = _convertInt.ConvertListOfIntToString(model.SequenceOfMoves.Timing);

            return toReturn;
        }

        public AutoClickBEModel ConvertToBEModel(AutoClickDBModel model)
        {
            AutoClickBEModel toReturn = new AutoClickBEModel();

            toReturn.MinHealth = model.MinHealth;
            toReturn.MinMana = model.MinMana;

            toReturn.Accessories = _convertEnum.ConvertStringToListOfEnum<EnumAccessories>(model.Accessories);
            toReturn.Potions = _convertEnum.ConvertStringToListOfEnum<EnumPotion>(model.Potions);
            toReturn.Buffs = _convertEnum.ConvertStringToListOfEnum<EnumBuffs>(model.Buffs);
            toReturn.Weapons = _convertEnum.ConvertStringToListOfEnum<EnumWeapons>(model.Weapons);

            toReturn.Armor = _convertEnum.ConvertStringToEnum<EnumArmor>(model.Armor);
            toReturn.Mount = _convertEnum.ConvertStringToEnum<EnumMount>(model.Mount);
            toReturn.Minions = _convertEnum.ConvertStringToEnum<EnumMinion>(model.Minions);
            toReturn.Grapple = _convertEnum.ConvertStringToEnum<EnumGrapple>(model.Grapple);
            toReturn.Boss = _convertEnum.ConvertStringToEnum<EnumBoss>(model.Boss);

            toReturn.SequenceOfMoves = new MoveModel()
            {
                Moves = _convertString.ConvertStringToListOfString(model.SequenceOfMoves),
                Timing = _convertInt.ConvertStringToListOfInt(model.Timing)
            };

            return toReturn;
        }
    }
}
