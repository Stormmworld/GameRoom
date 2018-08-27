using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Scavenging_Ghoul : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=82
        *  
        *  At the beginning of each end step, put a corpse counter on Scavenging Ghoul for each creature that died this turn.
Remove a corpse counter from Scavenging Ghoul: Regenerate Scavenging Ghoul.
        *  
        * Rulings
        * 2004-10-04: The Ghoul still gets to claim counters even if it enters the battlefield after the creatures died.

        *
        */
        public Scavenging_Ghoul() : base()
        {
            MultiverseId = 82;
            Name = "Scavenging Ghoul";
            Set(2, 2);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Zombie);
            Add(CardType.Creature);

            throw new NotImplementedException("Scavenging Ghoul");
        }
        public Scavenging_Ghoul(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
