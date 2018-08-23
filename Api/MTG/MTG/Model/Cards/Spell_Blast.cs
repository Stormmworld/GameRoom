using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Spell_Blast : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=127
            *  
            *  Counter target spell with converted mana cost X. (For example, if that spell's mana cost is {3}{U}{U}, X is 5.)
            *  
            * Rulings
		2013-07-01: Alternative costs, additional costs, cost increases, and cost reductions don't affect a spell's converted mana cost.
		2013-07-01: If the target spell has {X} in its mana cost, include the value chosen for that X when determining the value of the {X} in Spell Blast's mana cost. For example, if you wish to counter Volcanic Geyser (a spell with mana cost {X}{R}{R}) whose X is 7, you'll need to choose 9 for Spell Blast's X and pay {9}{U}.

            *  
            */
        public Spell_Blast() : base()
        {
            MultiverseId = 127;
            Name = "Spell Blast";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Spell Blast");
        }
        public Spell_Blast(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
