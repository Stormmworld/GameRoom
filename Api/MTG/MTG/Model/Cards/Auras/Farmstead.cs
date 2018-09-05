using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Activated;
using MTG.Model.Effects;
using MTG.Interfaces.Mana_Interfaces;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Farmstead : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=250
        *  
        *  Enchant land
        *  Enchanted land has "At the beginning of your upkeep, you may pay {W}{W}. If you do, you gain 1 life."
        *  
        * Rulings
        *
        */
        public Farmstead() :  base(new TargetCardRequirements() { HasType = CardType.Land, InZone = TargetZone.Battlefield })
        {
            MultiverseId = 250;
            Name = "Farmstead";
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new EffectGenerator(false,new List<IManaCost>() { new ManaCost(new Mana(Color.White, 2)) }, typeof(GainLifeEffect), new TargetRequirements(TargetScope.Controller, TargetType.Player), false) { RestrictedPhase = GamePhase.Beginning_Upkeep});
        }
        public Farmstead(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
