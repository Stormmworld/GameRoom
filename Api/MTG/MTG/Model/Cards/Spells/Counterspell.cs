using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using MTG.Model.Data_Objects;
using System.Collections.Generic;
using MTG.Model.Effects;

namespace MTG.Model.Cards
{
    public class Counterspell : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=102
        *  
        *  Counter target spell.
        *  
        * Rulings
        *
        */
        public Counterspell() : base()
        {
            MultiverseId = 102;
            Name = "Counterspell";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(CardType.Instant);
            Add(new CreateEffect(abilityCost, new TargetRequirements(TargetScope.Single,  TargetType.Card , new TargetCardRequirements() { InZone = TargetZone.Stack }), typeof(CounterspellEffect), false));
        }
        public Counterspell(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
