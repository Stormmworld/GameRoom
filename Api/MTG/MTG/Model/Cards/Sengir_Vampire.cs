using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Sengir_Vampire : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=83
        *  
        *  Flying (This creature can't be blocked except by creatures with flying or reach.)
Whenever a creature dealt damage by Sengir Vampire this turn dies, put a +1/+1 counter on Sengir Vampire.
        *  
        * Rulings
        * 2007-07-15: If Sengir Vampire deals nonlethal damage to a creature and then a different effect or damage source causes that creature to be put into a graveyard later in the turn, Sengir Vampire's ability will trigger and it will get a +1/+1 counter.
        * 2011-09-22: Each time a creature is put into a graveyard from the battlefield, check whether Sengir Vampire had dealt any damage to it at any time during that turn. If so, Sengir Vampire's ability will trigger. It doesn't matter who controlled the creature or whose graveyard it was put into.
        * 2011-09-22: If Sengir Vampire and a creature it dealt damage to are both put into a graveyard at the same time, Sengir Vampire's ability will trigger, but it will do nothing when it resolves.

        *
        */
        public Sengir_Vampire() : base()
        {
            MultiverseId = 83;
            Name = "Sengir Vampire";
            Set(4, 4);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Vampire);
            Add(CardType.Creature);

            throw new NotImplementedException("Sengir Vampire");
        }
        public Sengir_Vampire(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
