using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Tranquility : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=176
            *  
            *  Destroy all enchantments.
            *  
            * Rulings

            *  
            */
        public Tranquility() : base()
        {
            MultiverseId = 176;
            Name = "Tranquility";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Tranquility");
        }
        public Tranquility(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
