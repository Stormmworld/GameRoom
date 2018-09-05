using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Static;
using MTG.Model.Abilities.Triggered;

namespace MTG.Model.Cards
{
    public class Consecrate_Land : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=245
        *  
        *  Enchant land
        *  Enchanted land has indestructible and can't be enchanted by other Auras.
        *  
        * Rulings
        * 2005-04-01: The land can be targeted by land-destroying spells and the spell will resolve, but the land will simply not be destroyed.
        * 2006-09-25: If Consecrate Land enters the battlefield attached to a land that's enchanted by other Auras, those Auras are put into their owners' graveyards.
        * 2013-07-01: A permanent with indestructible can't be destroyed, but it can still be sacrificed, exiled, put into a graveyard, and so on.
        *
        */
        public Consecrate_Land() :  base(new TargetCardRequirements() { HasType = CardType.Land, InZone = TargetZone.Battlefield })
        {
            MultiverseId = 245;
            Name = "Consecrate Land";
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new AddAbility(EffectTrigger.Aura_Detached, new AuraProof() { BoundCardId = Id }));
            Add(new RemoveAbility(EffectTrigger.Aura_Detached, new AuraProof() { BoundCardId = Id }));
            Add(new AddAbility(EffectTrigger.Aura_Detached, new Indestructible() { BoundCardId = Id }));
            Add(new RemoveAbility(EffectTrigger.Aura_Detached, new Indestructible() { BoundCardId = Id }));
        }
        public Consecrate_Land(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
