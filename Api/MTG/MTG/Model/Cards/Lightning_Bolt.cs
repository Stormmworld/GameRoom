using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Lightning_Bolt : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=209
            *  
            *  Lightning Bolt deals 3 damage to target creature or player.
            *  
            * Rulings

            *  
            */
        public Lightning_Bolt() : base()
        {
            MultiverseId = 209;
            Name = "Lightning Bolt";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Lightning Bolt");
        }
        public Lightning_Bolt(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
