using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Holy_Armor : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=254
            *  
            *  Enchant creature
Enchanted creature gets +0/+2.
{W}: Enchanted creature gets +0/+1 until end of turn.
            *  
            * Rulings

            *  
            */
        public Holy_Armor() : base()
        {
            MultiverseId = 254;
            Name = "Holy Armor";
	Add(Enumerations.Colors.White);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Holy Armor");
        }
        public Holy_Armor(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
