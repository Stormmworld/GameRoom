using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Juggernaut : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=26
            *  
            *  Juggernaut attacks each combat if able.
Juggernaut can't be blocked by Walls.
            *  
            * Rulings
		2016-06-08: If, during your declare attackers step, Juggernaut is tapped, is affected by a spell or ability that says it can't attack, or you haven't controlled it continuously since the beginning of your turn, then it doesn't attack. If there's a cost associated with having Juggernaut attack, you aren't forced to pay that cost, so it doesn't have to attack in that case either.

            *  
            */
        public Juggernaut() : base()
        {
            MultiverseId = 26;
            Name = "Juggernaut";
	Add(Enumerations.SubType.Juggernaut);
	Add(Enumerations.CardType.Artifact);
	Add(Enumerations.CardType.Creature);
	_Power = 5;
		_Toughness = 3;

            throw new NotImplementedException("Juggernaut");
        }
        public Juggernaut(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
