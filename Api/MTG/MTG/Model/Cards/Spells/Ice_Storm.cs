using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using MTG.Model.Data_Objects;
using MTG.Model.Effects;

namespace MTG.Model.Cards
{
    public class Ice_Storm : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=157
        *  
        *  Destroy target land.
        *  
        * Rulings
        *
        */
        public Ice_Storm() : base()
        {
            MultiverseId = 157;
            Name = "Ice Storm";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            abilityCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(CardType.Sorcery);
            Add(new CreateEffect(abilityCost, new TargetRequirements(TargetScope.Single, TargetType.Card, new TargetCardRequirements() { HasType = CardType.Land, InZone = TargetZone.Battlefield}),typeof(DestroyEffect),false));
        }
        public Ice_Storm(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
