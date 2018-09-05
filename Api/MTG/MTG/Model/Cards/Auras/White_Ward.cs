using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Abilities.Static;

namespace MTG.Model.Cards
{
    public class White_Ward : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=275
        *  
        *  Enchant creature
        *  Enchanted creature has protection from white. This effect doesn't remove White Ward.
        *  
        * Rulings

        *
        */
        public White_Ward() :  base(new TargetCardRequirements() { HasType = CardType.Creature, InZone = TargetZone.Battlefield })
        {
            MultiverseId = 275;
            Name = "White Ward";
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new AddAbility(EffectTrigger.Aura_Attached, Protection.From(new List<Color>() { Color.White })){ BoundCardId = Id });
            Add(new RemoveAbility(EffectTrigger.Aura_Detached, Protection.From(new List<Color>() { Color.White })) { BoundCardId = Id });
        }
        public White_Ward(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
