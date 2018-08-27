using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Rock_Hydra : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=219
        *  
        *  Rock Hydra enters the battlefield with X +1/+1 counters on it.
For each 1 damage that would be dealt to Rock Hydra, if it has a +1/+1 counter on it, remove a +1/+1 counter from it and prevent that 1 damage.
{R}: Prevent the next 1 damage that would be dealt to Rock Hydra this turn.
{R}{R}{R}: Put a +1/+1 counter on Rock Hydra. Activate this ability only during your upkeep.
        *  
        * Rulings
        * 2004-10-04: If put onto the battlefield without casting it from your hand, X will be zero.
        * 2004-10-04: Once on the battlefield, the X is considered to be zero when calculating its mana cost.
        * 2008-08-01: You can activate the activated ability that prevents damage any time, even if no source seems likely to deal damage to you in the near future. It will prevent the next 1 damage that would be dealt this turn, even if that turns out to be much later in the turn.
        * 2008-08-01: If damage that would be dealt to Rock Hydra can't be prevented, you still remove a +1/+1 counter from it for each 1 damage dealt.

        *
        */
        public Rock_Hydra() : base()
        {
            MultiverseId = 219;
            Name = "Rock Hydra";
            Set(0, 0);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, true)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Hydra);
            Add(CardType.Creature);

            throw new NotImplementedException("Rock Hydra");
        }
        public Rock_Hydra(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
