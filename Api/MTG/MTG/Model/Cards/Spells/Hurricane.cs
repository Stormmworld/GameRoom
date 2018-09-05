using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using MTG.Model.Data_Objects;
using MTG.Model.Effects;
using MTG.Model.Abilities.Static;

namespace MTG.Model.Cards
{
    public class Hurricane : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=156
        *  
        *  Hurricane deals X damage to each creature with flying and each player.
        *  
        * Rulings
        * 2004-10-04: Whether or not a creature has flying is only checked on resolution.
        *
        */
        public Hurricane() : base()
        {
            MultiverseId = 156;
            Name = "Hurricane";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, true)));
            abilityCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(CardType.Sorcery);
            Add(new CreateEffect(abilityCost, new TargetRequirements(TargetScope.All, TargetType.Player), typeof(DamageEffect), false));
            Add(new CreateEffect(abilityCost, new TargetRequirements(TargetScope.All, TargetType.Card, new TargetCardRequirements() { HasType = CardType.Creature, HasAbility = typeof(Flying),InZone= TargetZone.Battlefield  }), typeof(DamageEffect), true));
        }
        public Hurricane(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
