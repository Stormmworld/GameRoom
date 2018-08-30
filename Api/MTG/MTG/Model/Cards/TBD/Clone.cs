using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Clone : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=99
        *  
        *  You may have Clone enter the battlefield as a copy of any creature on the battlefield.
        *  
        * Rulings
        * 2007-07-15: If the chosen creature is copying something else (for example, if the chosen creature is another Clone), then your Clone enters the battlefield as whatever the chosen creature copied.
        * 2007-07-15: If the chosen creature is a token, Clone copies the original characteristics of that token as stated by the effect that put it onto the battlefield. Clone is not a token.
        * 2007-07-15: Any enters-the-battlefield abilities of the copied creature will trigger when Clone enters the battlefield. Any "as [this creature] enters the battlefield" or "[this creature] enters the battlefield with" abilities of the chosen creature will also work.
        * 2009-10-01: If the chosen creature has {X} in its mana cost (such as Protean Hydra), X is considered to be zero.
        * 2012-07-01: Clone copies exactly what was printed on the original creature and nothing more (unless that creature is copying something else or is a token; see below). It doesn't copy whether that creature is tapped or untapped, whether it has any counters on it or Auras attached to it, or any non-copy effects that have changed its power, toughness, types, color, or so on.
        * 2012-07-01: If Clone somehow enters the battlefield at the same time as another creature, Clone can't become a copy of that creature. You may choose only a creature that's already on the battlefield.
        * 2012-07-01: You can choose not to copy anything. In that case, Clone enters the battlefield as a 0/0 Shapeshifter creature, and is probably put into the graveyard immediately.
        * 2013-07-01: Clone's ability doesn't target the chosen creature.
        *
        */
        public Clone() : base()
        {
            MultiverseId = 99;
            Name = "Clone";
            Set(0, 0);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Shapeshifter);
            Add(CardType.Creature);

            throw new NotImplementedException("Clone");
        }
        public Clone(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
