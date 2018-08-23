using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Lance : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=258
            *  
            *  Enchant creature
Enchanted creature has first strike.
            *  
            * Rulings

            *  
            */
        public Lance() : base()
        {
            MultiverseId = 258;
            Name = "Lance";
	Add(Enumerations.Colors.White);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Lance");
        }
        public Lance(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
