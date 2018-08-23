using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Conservator : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=8
            *  
            *  {3}, {T}: Prevent the next 2 damage that would be dealt to you this turn.
            *  
            * Rulings

            *  
            */
        public Conservator() : base()
        {
            MultiverseId = 8;
            Name = "Conservator";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Conservator");
        }
        public Conservator(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
