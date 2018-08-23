using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Hurricane : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=156
            *  
            *  Hurricane deals X damage to each creature with flying and each player.
            *  
            * Rulings
		2004-10-04: Whether or not a creature has flying is only checked on resolution.

            *  
            */
        public Hurricane() : base()
        {
            MultiverseId = 156;
            Name = "Hurricane";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Hurricane");
        }
        public Hurricane(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
