using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Crusade : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=247
            *  
            *  White creatures get +1/+1.
            *  
            * Rulings

            *  
            */
        public Crusade() : base()
        {
            MultiverseId = 247;
            Name = "Crusade";
	Add(Enumerations.Colors.White);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Crusade");
        }
        public Crusade(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
