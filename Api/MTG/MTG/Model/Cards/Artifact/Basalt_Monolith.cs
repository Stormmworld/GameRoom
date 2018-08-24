using MTG.Model.Abilities.Activated;
using MTG.Model.Effects;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Basalt_Monolith : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=2
            *  
            *  Basalt Monolith doesn't untap during your untap step.
                {T}: Add {C}{C}{C} to your mana pool.
                {3}: Untap Basalt Monolith.
            *  
            * Rulings
		2004-10-04: It can be untapped as often as you can pay for it.

            *  
            */
        public Basalt_Monolith() : base()
        {
            MultiverseId = 2;
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Colorless, Count = 3 } });
            Name = "Basalt Monolith";
            Add(Enumerations.CardType.Artifact);
            Add(new DoesNotUntap());
            CastingCost untapCost = new CastingCost();
            untapCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Colorless, Count = 3 } });
            Add(new Untap(untapCost, false));
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.Colorless, Count = 3 }) { RequiresTap = true });
        }
        public Basalt_Monolith(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
