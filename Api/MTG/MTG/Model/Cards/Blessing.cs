using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Blessing : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=238
            *  
            *  Enchant creature
{W}: Enchanted creature gets +1/+1 until end of turn.
            *  
            * Rulings

            *  
            */
        public Blessing() : base()
        {
            MultiverseId = 238;
            Name = "Blessing";
	Add(Enumerations.Colors.White);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Blessing");
        }
        public Blessing(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
