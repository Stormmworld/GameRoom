using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Counters;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Animate_Dead : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=48
        *  
        *  Enchant creature card in a graveyard
            When Animate Dead enters the battlefield, if it's on the battlefield, it loses "enchant creature card in a graveyard" and gains "enchant creature put onto the battlefield with Animate Dead." Return enchanted creature card to the battlefield under your control and attach Animate Dead to it. When Animate Dead leaves the battlefield, that creature's controller sacrifices it.
            Enchanted creature gets -1/-0.
        *  
        * Rulings
        * 2016-06-08: Animate Dead is an Aura, albeit with an unusual enchant ability. You target a creature card in a graveyard when you cast it. It enters the battlefield attached to that card. Then it returns that card to the battlefield, and attaches itself to the card again (since the card is a new object on the battlefield). Animate Dead itself never moves into a graveyard during this process.
        * 2016-06-08: If Animate Dead isn't on the battlefield as its triggered ability resolves, none of its effects happen. The creature card won't be returned to the battlefield.
        * 2016-06-08: Abilities such as shroud and protection function only on the battlefield unless otherwise specified. A creature card with shroud may be targeted by Animate Dead, and Animate Dead will become attached to the creature that enters the battlefield.
        * 2016-06-08: If the creature put onto the battlefield has protection from black—or if the creature can't legally be enchanted by Animate Dead for another reason—Animate Dead won't be able to attach to it. It will be put into the graveyard as a state-based action, causing its delayed triggered ability to trigger. When the trigger resolves, if the creature's still on the battlefield, its controller will sacrifice it.
        * 2016-06-08: Once the creature is returned to the battlefield, Animate Dead can't be attached to anything other than it (unless Animate Dead somehow manages to put a different creature onto the battlefield). Attempting to move Animate Dead to another creature won't work.

        *
        */
        public Animate_Dead() : base(new TargetCardRequirements() { HasType = CardType.Creature, InZone = TargetZone.Graveyard })
        {
            MultiverseId = 48;
            Name = "Animate Dead";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new MoveToZone(EffectTrigger.Aura_Attached, TargetZone.Battlefield, TargetZone.Graveyard));
            Add(new AddCounter(EffectTrigger.Aura_Attached, new PlusXPlusY(-1, 0)));
        }
        public Animate_Dead(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
