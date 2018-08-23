using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Burrowing : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=186
            *  
            *  Enchant creature
Enchanted creature has mountainwalk. (It can't be blocked as long as defending player controls a Mountain.)
            *  
            * Rulings

            *  
            */
        public Burrowing() : base()
        {
            MultiverseId = 186;
            Name = "Burrowing";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Burrowing");
        }
        public Burrowing(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
