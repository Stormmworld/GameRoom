using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Abilities.Static;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Black_Ward : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=236
        *  
        *  Enchant creature
        *       Enchanted creature has protection from black. This effect doesn't remove Black Ward.
        *  
        * Rulings

        *
        */
        public Black_Ward() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 236;
            Name = "Black Ward";
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new AddAbility(EffectTrigger.Aura_Attached, Protection.From(new List<Color>() {Color.Black })));
            Add(new RemoveAbility(EffectTrigger.Aura_Detached, Protection.From(new List<Color>() { Color.Black })));
        }
        public Black_Ward(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
