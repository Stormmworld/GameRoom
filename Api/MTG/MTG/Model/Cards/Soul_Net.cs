using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Soul_Net : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=41
            *  
            *  Whenever a creature dies, you may pay {1}. If you do, you gain 1 life.
            *  
            * Rulings
		2004-10-04: If animated so it is a creature, it can be triggered off its own destruction.

            *  
            */
        public Soul_Net() : base()
        {
            MultiverseId = 41;
            Name = "Soul Net";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Soul Net");
        }
        public Soul_Net(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
