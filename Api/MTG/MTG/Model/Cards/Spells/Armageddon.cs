using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using MTG.Model.Data_Objects;
using System.Collections.Generic;
using MTG.Model.Abilities.Activated;
using MTG.Model.Effects;

namespace MTG.Model.Cards
{
    public class Armageddon : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=233
        *  
        *  Destroy all lands.
        *  
        * Rulings

        *
        */
        public Armageddon() : base()
        {
            MultiverseId = 233;
            Name = "Armageddon";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            abilityCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(CardType.Sorcery);
            Add(new CreateEffect(abilityCost,new TargetRequirements(TargetScope.All,  TargetType.Card, new TargetCardRequirements() { HasType = CardType.Land, InZone = TargetZone.Battlefield} ), typeof(DestroyEffect), false));
        }
        public Armageddon(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
