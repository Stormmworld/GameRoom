using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Abilities.Static;

namespace MTG.Model.Cards
{
    public class Juggernaut : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=26
        *  
        *  Juggernaut attacks each combat if able.
        *   Juggernaut can't be blocked by Walls.
        *  
        * Rulings
        * 2016-06-08: If, during your declare attackers step, Juggernaut is tapped, is affected by a spell or ability that says it can't attack, or you haven't controlled it continuously since the beginning of your turn, then it doesn't attack. If there's a cost associated with having Juggernaut attack, you aren't forced to pay that cost, so it doesn't have to attack in that case either.

        *
        */
        public Juggernaut() : base()
        {
            MultiverseId = 26;
            Name = "Juggernaut";
            Set(5, 3);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 4)));
            Add(SubType.Juggernaut);
            Add(CardType.Artifact);
            Add(CardType.Creature);
            Add(new Unblockable() { NotBlockableBySubType = SubType.Wall });
        }
        public Juggernaut(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
