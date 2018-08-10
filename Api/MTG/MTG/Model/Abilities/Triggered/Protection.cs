using MTG.Interfaces;
using MTG.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using MTG.Model.Objects;
using MTG.ArgumentDefintions.Triggered_Ability_Arguments;

namespace MTG.Model.Abilities.Triggered
{ 
    public class Protection : ITriggeredAbility
    {
        /*
                * https://mtg.gamepedia.com/Protection
                    702.16a Protection is a static ability, written “Protection from [quality].” This quality is usually a color 
                            (as in “protection from black”) but can be any characteristic value or information. If the quality
                            happens to be a card name, it is treated as such only if the protection ability specifies that the 
                            quality is a name. If the quality is a card type, subtype, or supertype, the ability applies to sources 
                            that are permanents with that card type, subtype, or supertype and to any sources not on the battlefield 
                            that are of that card type, subtype, or supertype. This is an exception to rule 109.2.
                    702.16b A permanent or player with protection can’t be targeted by spells with the stated quality and can’t 
                            be targeted by abilities from a source with the stated quality.
                    702.16c A permanent or player with protection can’t be enchanted by Auras that have the stated quality. Such 
                            Auras attached to the permanent or player with protection will be put into their owners’ graveyards 
                            as a state-based action. (See rule 704, “State-Based Actions.”)
                    702.16d A permanent with protection can’t be equipped by Equipment that have the stated quality or fortified 
                            by Fortifications that have the stated quality. Such Equipment or Fortifications become unattached 
                                    from that permanent as a state-based action, but remain on the battlefield. (See rule 704, 
                                    “State-Based Actions.”)
                    702.16e Any damage that would be dealt by sources that have the stated quality to a permanent or player with 
                            protection is prevented.
                    702.16f Attacking creatures with protection can’t be blocked by creatures that have the stated quality.
                    702.16g “Protection from [quality A] and from [quality B]” is shorthand for “protection from [quality A]” and 
                            “protection from [quality B]”; it behaves as two separate protection abilities. If an effect causes 
                            an object with such an ability to lose protection from [quality A], for example, that object would 
                            still have protection from [quality B].
                    702.16h “Protection from all [characteristic]” is shorthand for “protection from [quality A],” “protection 
                            from [quality B],” and so on for each possible quality the listed characteristic could have; it behaves 
                                    as multiple separate protection abilities. If an effect causes an object with such an ability 
                                    to lose protection from [quality A], for example, that object would still have protection from 
                                    [quality B], [quality C], and so on.
                    702.16i “Protection from everything” is a variant of the protection ability. A permanent with protection from 
                            everything has protection from each object regardless of that object’s characteristic values. Such a 
                            permanent can’t be targeted by spells or abilities, enchanted by Auras, equipped by Equipment, fortified 
                            by Fortifications, or blocked by creatures, and all damage that would be dealt to it is prevented.
                    702.16j “Protection from [a player]” is a variant of the protection ability. A permanent with protection from 
                            a specific player has protection from each object the player controls and protection from each object 
                            the player owns not controlled by another player, regardless of that object’s characteristic values. 
                            Such a permanent can’t be targeted by spells or abilities the player controls, enchanted by Auras the 
                            player controls, equipped by Equipment the player controls, fortified by Fortifications the player 
                            controls, or blocked by creatures the player controls, and all damage that would be dealt to it by 
                            sources controlled by the player or owned by the player but not controlled by another player is prevented.
                    702.16k Multiple instances of protection from the same quality on the same permanent or player are redundant.
                    702.16m Some Auras both give the enchanted creature protection and say “this effect doesn’t remove” either that 
                            specific Aura or all Auras. This means that the specified Auras can legally enchant that creature and 
                            aren’t put into their owners’ graveyards as a state-based action. If the creature has other instances 
                            of protection from the same quality, those instances affect Auras as normal.
                */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Variables
        private List<Colors> _Colors;
        private List<SubType> _SubTypes;
        private List<CardType> _CardTypes;
        #endregion

        #region Collection Properties
        public IReadOnlyCollection<CardType> CardTypes { get { return _CardTypes.AsReadOnly(); } }
        public IReadOnlyCollection<Colors> Colors { get { return _Colors.AsReadOnly(); } }
        public IReadOnlyCollection<SubType> SubTypes { get { return _SubTypes.AsReadOnly(); } }
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        public EffectTrigger Trigger { get { return EffectTrigger.Card_RecievesDamage; } }
        public AbilityType Type { get { return AbilityType.Static; } }
        #endregion

        #region Constructors
        public Protection()
        {
            Id = Guid.NewGuid();
            _Colors = new List<Colors>();
            _SubTypes = new List<SubType>();
            _CardTypes = new List<CardType>();
        }
        #endregion

        #region Methods
        public void Add(Colors color)
        {
            _Colors.Add(color);
        }
        public void Add(SubType subType)
        {
            _SubTypes.Add(subType);
        }
        public void Add(CardType cardType)
        {
            _CardTypes.Add(cardType);
        }
        public ITriggeredAbilityArgs GenerateArgs(ITriggeredAbilityArgs triggeredAbilityArgs, Card originCard)
        {
            throw new NotImplementedException("Protection.GenerateArgs");
        }
        public void Process(ITriggeredAbilityArgs e)
        {
            ProtectionTriggeredAbilityArgs args = (ProtectionTriggeredAbilityArgs)e;
            //no damage from a color when we have protection
            if (Colors.Intersect(args.OriginCard.Colors).Count() > 0)
                PreventDamage(args.TargetCard,  args.Damage);    
            //no damage from a card sub type when we have protection
            if (CardTypes.Intersect(args.OriginCard.CardTypes).Count() > 0)
                PreventDamage(args.TargetCard, args.Damage);
            //no damage from a card type when we have protection
            if (SubTypes.Intersect(args.OriginCard.SubTypes).Count() > 0)
                PreventDamage(args.TargetCard, args.Damage);
        }
        private void PreventDamage(Card recievingCard, Damage damage)
        {
            if (damage.OriginCard.HasType(CardType.Creature))
                damage.AddPrevention(damage.BaseValue);
        }
        public void Remove(Colors color)
        {
            _Colors.Remove(color);
        }
        public void Remove(SubType subType)
        {
            _SubTypes.Remove(subType);
        }
        public void Remove(CardType cardType)
        {
            _CardTypes.Remove(cardType);
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}
