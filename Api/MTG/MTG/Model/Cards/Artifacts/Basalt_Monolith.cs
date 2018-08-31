using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Activated;
using System.Collections.Generic;
using MTG.Model.Abilities.Static;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Effects;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Basalt_Monolith : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=2
        *  
        *  Basalt Monolith doesn't untap during your untap step.
        *   {T}: Add {C}{C}{C} to your mana pool.
        *   {3}: Untap Basalt Monolith.
        *  
        * Rulings
        * 2004-10-04: It can be untapped as often as you can pay for it.
        *
        */
        public Basalt_Monolith() : base()
        {
            MultiverseId = 2;
            Name = "Basalt Monolith";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            Add(CardType.Artifact);
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Colorless, 1) }));
            Add(new DoesNotUntap());
            Add(new EffectGenerator(false, new CastingCost(new List<IManaCost>() { new ManaCost(new Mana(Color.Colorless, 3)) }), typeof(UntapEffect), new TargetRequirements(TargetScope.Self, new List<TargetType>()), false));
        }
        public Basalt_Monolith(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
