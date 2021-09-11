using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TACUI.Library.Models;

namespace TACUI.Library.Conversion
{
    public class ConvertModel : IConvertModel
    {
        public AutoClickAPIModel ConvertUIModelToAPIModel(AutoClickUIModel autoClickUIModel)
        {
            AutoClickAPIModel autoClickAPIModel = new AutoClickAPIModel();

            autoClickAPIModel.MinHealth = autoClickUIModel.MinHealth;
            autoClickAPIModel.MinMana = autoClickUIModel.MinMana;
            autoClickAPIModel.Armor = autoClickUIModel.Armor;
            autoClickAPIModel.Accessories = new List<string>();

            if (autoClickUIModel.Accessories != null)
            {
                foreach (var accessorie in autoClickUIModel.Accessories)
                {
                    autoClickAPIModel.Accessories.Add(accessorie.ToString());
                } 
            }

            autoClickAPIModel.Mount = autoClickUIModel.Mount;
            autoClickAPIModel.Minions = autoClickUIModel.Minions;
            autoClickAPIModel.Grapple = autoClickUIModel.Grapple;
            autoClickAPIModel.Potions = new List<string>();

            if (autoClickUIModel.Potions != null)
            {
                foreach (var potion in autoClickUIModel.Potions)
                {
                    autoClickAPIModel.Potions.Add(potion.ToString());
                }
            }

            autoClickAPIModel.Buffs = new List<string>();

            if (autoClickUIModel.Buffs != null)
            {
                foreach (var buff in autoClickUIModel.Buffs)
                {
                    autoClickAPIModel.Buffs.Add(buff.ToString());
                } 
            }

            autoClickAPIModel.Weapons = new List<string>();

            if (autoClickUIModel.Weapons != null)
            {
                foreach (var weapon in autoClickUIModel.Weapons)
                {
                    autoClickAPIModel.Weapons.Add(weapon.ToString());
                } 
            }

            autoClickAPIModel.Boss = autoClickUIModel.Boss;
            autoClickAPIModel.SequenceOfMoves = autoClickUIModel.SequenceOfMoves;

            return autoClickAPIModel;
        }
    }
}
