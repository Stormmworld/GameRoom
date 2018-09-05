using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Abilities.Static;

namespace MTG.Model.Cards
{
    public class Blue_Ward : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=239
        *  
        *  Enchant creature
Enchanted creature has protection from blue. This effect doesn't remove Blue Ward.
        *  
        * Rulings

        *
        */
        public Blue_Ward() :  base(new TargetCardRequirements() { HasType = CardType.Creature, InZone = TargetZone.Battlefield })
        {
            MultiverseId = 239;
            Name = "Blue Ward";
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new AddAbility(EffectTrigger.Aura_Attached, Protection.From(new List<Color>() { Color.Blue })) { BoundCardId = Id });
            Add(new RemoveAbility(EffectTrigger.Aura_Detached, Protection.From(new List<Color>() { Color.Blue })) { BoundCardId = Id });
        }
        public Blue_Ward(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
