using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Giant_Growth : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=153
            *  
            *  Target creature gets +3/+3 until end of turn.
            *  
            * Rulings

            *  
            */
        public Giant_Growth() : base()
        {
            MultiverseId = 153;
            Name = "Giant Growth";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Giant Growth");
        }
        public Giant_Growth(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
