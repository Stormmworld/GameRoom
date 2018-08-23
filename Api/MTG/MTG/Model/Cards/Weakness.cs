using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Weakness : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=90
            *  
            *  Enchant creature
Enchanted creature gets -2/-1.
            *  
            * Rulings

            *  
            */
        public Weakness() : base()
        {
            MultiverseId = 90;
            Name = "Weakness";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Weakness");
        }
        public Weakness(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
