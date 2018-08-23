using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Winter_Orb : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=46
            *  
            *  As long as Winter Orb is untapped, players can't untap more than one land during their untap steps.
            *  
            * Rulings
		2016-06-08: All permanents untap during a player's untap step at once. If Winter Orb is tapped as your untap step begins, your lands will all untap.
		2016-06-08: You can't tap Winter Orb just because you want to. Another ability, such as that of Glare of Subdual, must instruct or allow you to do so.

            *  
            */
        public Winter_Orb() : base()
        {
            MultiverseId = 46;
            Name = "Winter Orb";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Winter Orb");
        }
        public Winter_Orb(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
