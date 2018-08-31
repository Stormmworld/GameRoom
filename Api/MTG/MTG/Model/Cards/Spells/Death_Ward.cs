using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using MTG.Model.Data_Objects;
using System.Collections.Generic;
using MTG.Model.Effects;

namespace MTG.Model.Cards
{
    public class Death_Ward : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=248
        *  
        *  Regenerate target creature.
        *  
        * Rulings
        *
        */
        public Death_Ward() : base()
        {
            MultiverseId = 248;
            Name = "Death Ward";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(CardType.Instant);
            Add(new CreateEffect(abilityCost, new TargetRequirements(TargetScope.Single, new List<TargetType>() { TargetType.Card }, new TargetCardRequirements() { HasType = CardType.Creature, InZone = TargetZone.Battlefield}),typeof(RegenerationEffect),false));
        }

        public Death_Ward(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
