using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using MTG.Model.Data_Objects;
using MTG.Model.Effects;

namespace MTG.Model.Cards
{
    public class Sinkhole : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=85
        *  
        *  Destroy target land.
        *  
        * Rulings

        *
        */
        public Sinkhole() : base()
        {
            MultiverseId = 85;
            Name = "Sinkhole";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            abilityCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(CardType.Sorcery);
            Add(new CreateEffect(abilityCost, new TargetRequirements(TargetScope.Single, TargetType.Card, new TargetCardRequirements() { HasType = CardType.Land, InZone = TargetZone.Battlefield }), typeof(DestroyEffect), false));
        }
        public Sinkhole(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
