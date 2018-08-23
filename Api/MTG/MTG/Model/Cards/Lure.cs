using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Lure : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=167
            *  
            *  Enchant creature
All creatures able to block enchanted creature do so.
            *  
            * Rulings
		2017-11-17: Lure doesn't give any creatures the ability to block the target creature. It just forces those creatures that are already able to block the creature to do so.
		2017-11-17: As blockers are declared, any creature that's tapped or affected by a spell or ability that says it can't block doesn't block. If there's a cost associated with having the creature block, no player is forced to pay that cost, so it doesn't block if that cost isn't paid.

            *  
            */
        public Lure() : base()
        {
            MultiverseId = 167;
            Name = "Lure";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Lure");
        }
        public Lure(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
