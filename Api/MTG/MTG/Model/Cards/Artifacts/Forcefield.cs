using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Activated;
using MTG.Model.Data_Objects;
using MTG.Model.Effects;
using MTG.Interfaces.Mana_Interfaces;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Forcefield : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=14
        *  
        *  {1}: The next time an unblocked creature of your choice would deal combat damage to you this turn, prevent all but 1 of that damage.
        *  
        * Rulings
        * 2004-10-04: This can't be used to prevent damage caused by a blocked creature with Trample ability.
        *
        */
        public Forcefield() : base()
        {
            MultiverseId = 14;
            Name = "Forcefield";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            Add(CardType.Artifact);
            Add(new EffectGenerator(false, new List<IManaCost>() { new ManaCost(new Mana( Color.Colorless, 1))}, typeof(PreventDamageEffect), new TargetRequirements(TargetScope.Single, TargetType.Card, new TargetCardRequirements() { HasType= CardType.Creature, CombatState = CombatState.UnBlocked, CardAction = CardAction.Attacker }), GamePhase.None));
        }
        public Forcefield(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
