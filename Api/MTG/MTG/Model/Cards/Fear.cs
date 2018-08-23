using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Fear : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=64
            *  
            *  Enchant creature (Target a creature as you cast this. This card enters the battlefield attached to that creature.)
Enchanted creature has fear. (It can't be blocked except by artifact creatures and/or black creatures.)
            *  
            * Rulings

            *  
            */
        public Fear() : base()
        {
            MultiverseId = 64;
            Name = "Fear";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Fear");
        }
        public Fear(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
