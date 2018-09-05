using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using MTG.Model.Data_Objects;
using MTG.Model.Effects;

namespace MTG.Model.Cards
{
    public class Stone_Rain : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=225
        *  
        *  Destroy target land.
        *  
        * Rulings
        *
        */
        public Stone_Rain() : base()
        {
            MultiverseId = 225;
            Name = "Stone Rain";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            abilityCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(CardType.Sorcery);
            Add(new CreateEffect(abilityCost, new TargetRequirements(TargetScope.Single, TargetType.Card, new TargetCardRequirements() { HasType = CardType.Land, InZone = TargetZone.Battlefield }), typeof(DestroyEffect), false));
        }
        public Stone_Rain(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
