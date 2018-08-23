using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Farmstead : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=250
            *  
            *  Enchant land
Enchanted land has "At the beginning of your upkeep, you may pay {W}{W}. If you do, you gain 1 life."
            *  
            * Rulings

            *  
            */
        public Farmstead() : base()
        {
            MultiverseId = 250;
            Name = "Farmstead";
	Add(Enumerations.Colors.White);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Farmstead");
        }
        public Farmstead(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
