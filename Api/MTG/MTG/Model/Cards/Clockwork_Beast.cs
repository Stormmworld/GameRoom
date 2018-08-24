using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Clockwork_Beast : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=7
            *  
            *  Clockwork Beast enters the battlefield with seven +1/+0 counters on it.
                At end of combat, if Clockwork Beast attacked or blocked this combat, remove a +1/+0 counter from it.
                {X}, {T}: Put up to X +1/+0 counters on Clockwork Beast. This ability can't cause the total number of +1/+0 counters on Clockwork Beast to be greater than seven. Activate this ability only during your upkeep.
            *  
            * Rulings
		        2004-10-04: Loses a counter even if it is affected by a Fog-like effect which prevents it from dealing damage.
		        2004-10-04: Can attack or block even if it has no counters.
		        2007-09-16: This is a change from the most recent wording. Now, if some other spell or ability causes +1/+0 counters to be put on Clockwork Beast, it can wind up with more than seven such counters on it.
		        2007-09-16: If Clockwork Beast has seven or fewer +1/+0 counters on it when its last ability resolves, it can wind up a maximum of seven such counters on it. If it has seven or more +1/+0 counters on it, the ability will have no effect.
		        2007-09-16: Clockwork Beast's last ability resolves, you can choose to put fewer than X +1/+0 counters on it.

            *  
            */
        public Clockwork_Beast() : base()
        {
            MultiverseId = 7;
            Name = "Clockwork Beast";
            _Power = 0;
            _Toughness = 4;
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Colorless, Count = 6 } });
            Add(Enumerations.SubType.Beast);
            Add(Enumerations.CardType.Artifact);
            Add(Enumerations.CardType.Creature);

            throw new NotImplementedException("Clockwork Beast");
        }
        public Clockwork_Beast(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
